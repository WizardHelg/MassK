using MassK.BL;
using MassK.Data;
using MassK.UI.LangPacks;
using MassK.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MassK.Settings;

using DGASMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode;
using DGVTBColumn = System.Windows.Forms.DataGridViewTextBoxColumn;
using DGVIColumn = System.Windows.Forms.DataGridViewImageColumn;
using DGVCBColumn = System.Windows.Forms.DataGridViewCheckBoxColumn;
using DGVColumn = System.Windows.Forms.DataGridViewColumn;
using ScaleFileNum = MassK.Data.ConnectionManager.RAWFiles.ScaleFileNum;

namespace MassK.UI.Forms
{
    public partial class FormScalesTable : Form
    {
        readonly object _lock_object = new object();
        List<ScaleInfo> _scale_infos = new List<ScaleInfo>();
        readonly BindingSource _binding = new BindingSource();
        readonly Timer _timer = new Timer()
        {
            Interval = 300,
            Enabled = false
        };
        int dot_counter = 0;

        public FormScalesTable()
        {
            InitializeComponent();
            
            _timer.Tick += (o, e) =>
            {
                StringBuilder builder = new StringBuilder();
                builder.Append(LangPack.GetText("Proccess"));
                if (dot_counter++ < 3)
                    for (int i = 0; i < dot_counter; i++)
                        builder.Append(".");
                else
                    dot_counter = 0;

                ProccessLable.Text = builder.ToString();
            };
        }

        protected override void OnLoad(EventArgs e)
        {
            SetDataGrid();
            LoadConnections();
            LangPack.Translate(this, dataGrid);
            ProcessDecorator(() => ConnectionManager.Connection.CheckState(_scale_infos), 250);
            base.OnLoad(e);
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();

            base.OnKeyDown(e);
        }

        private void SetDataGrid()
        {
            dataGrid.Columns.Clear();

            dataGrid.AutoGenerateColumns = false;
            dataGrid.RowHeadersVisible = false;
            dataGrid.ShowCellErrors = false;
            dataGrid.RowTemplate.MinimumHeight = 50;
            dataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            var DGSetting = new List<(Type Type,
                                      string Name,
                                      string HeaderText,
                                      string DataPropertyName,
                                      bool ReadOnly,
                                      DGASMode AutoSizeMode,
                                      bool Visible)>()
            {
                (typeof(DGVCBColumn), "Unload", "Выгр.", "Unload", false, DGASMode.AllCells, true),
                (typeof(DGVCBColumn), "Load", "Загр.", "Load", false, DGASMode.AllCells, true),
                (typeof(DGVTBColumn), "Name", "Название весов", "Name", true, DGASMode.Fill, true),
                (typeof(DGVTBColumn), "Number", "Номер весов", "Number", true, DGASMode.AllCells, true),
                (typeof(DGVTBColumn), "Connection", "Соединение", "Connection", true, DGASMode.AllCells, true),
                (typeof(DGVTBColumn), "TextState", "Состояние", "TextState", true, DGASMode.AllCells, true),
                (typeof(DGVTBColumn), "DataExchangeDate", "Дата последнего обмена", "DataExchangeDate", true, DGASMode.AllCells, true),
                (typeof(DGVTBColumn), "State", "State", "State", true, DGASMode.AllCells, false)
            };

            foreach (var item in DGSetting)
            {
                DGVColumn col = Activator.CreateInstance(item.Type) as DGVColumn;
                col.Name = item.Name;
                col.HeaderText = item.HeaderText;
                col.DataPropertyName = item.DataPropertyName;
                col.ReadOnly = item.ReadOnly;
                col.AutoSizeMode = item.AutoSizeMode;
                col.Visible = item.Visible;
                col.SortMode = DataGridViewColumnSortMode.Programmatic;
                dataGrid.Columns.Add(col);
            }
        }

        private void LoadConnections()
        {
            _scale_infos = SettingManager.ScaleInfos;
            _binding.DataSource = _scale_infos;
            dataGrid.DataSource = _binding;
        }

        private void ProcessDecorator(Action action, int delay = 0)
        {
            Task.Run(async () =>
            {
                if (delay > 0)
                    await Task.Delay(delay);

                Invoke((Action)(() => _timer.Start()));

                lock(_lock_object)
                {
                    action.Invoke();
                }
                
                Invoke((Action)(() =>
                {
                    if (_binding.DataSource == _scale_infos)
                        _binding.ResetBindings(false);
                    else
                        _binding.DataSource = _scale_infos;

                    dot_counter = 0;
                    ProccessLable.Text = "";
                    _timer.Stop();
                }));
            });
        }

        private void ButtonFind_Click(object sender, EventArgs e)
        {
            ProcessDecorator(() => _scale_infos = ConnectionManager.Connection.Scan(_scale_infos));
        }
        private void ButtonCheckConnection_Click(object sender, EventArgs e)
        {
            ProcessDecorator(() => ConnectionManager.Connection.CheckState(_scale_infos), 250);
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            SettingManager.ScaleInfos = _scale_infos;
            DialogResult = DialogResult.OK;
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGrid.SelectedRows)
                if (_scale_infos.Find(si => si.Connection == row.Cells["Connection"].Value.ToString()) is ScaleInfo scale)
                    _scale_infos.Remove(scale);

            _binding.ResetBindings(false);
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            var form = new FormAddScalesConnection(_scale_infos);
            if(form.ShowDialog() == DialogResult.OK)
            {
                _binding.ResetBindings(false);
                ProcessDecorator(() => ConnectionManager.Connection.CheckState(_scale_infos), 250);
            }
        }

        private void ButtonHelp_Click(object sender, EventArgs e)
        {

        }
    }
}
