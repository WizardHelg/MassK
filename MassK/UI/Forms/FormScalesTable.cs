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

namespace MassK.UI.Forms
{
    public partial class FormScalesTable : Form
    {
        public List<WeighingMachine> WeighingMachines { get; set; }


        LangPack _langPack;

        public FormScalesTable()
        {
            InitializeComponent();
            LangPack.Translate(this);
        }

        public FormScalesTable(LangPack langPack)
        {
            _langPack = langPack;
            //langPack.Translate(this);
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(55, 109, 163);
            panel2.BackColor = Color.FromArgb(55, 109, 163);
            WeighingMachines = new List<WeighingMachine>();
            dataGrid.RowHeadersVisible = false;
            dataGrid.DataError += DataGrid_DataError;
        }

        private void DataGrid_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show(e.Exception.Message, "Ошибка таблицы", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void FormWeighingMachins_Load(object sender, EventArgs e)
        {
            SetData();
        }
        private void SetData()
        {
            //dataGrid.DataSource = null;
            //dataGrid.DataSource = WeighingMachines;
            //dataGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            //dataGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            //dataGrid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }


        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            var form = new FormAddScalesConnection();
            form.ShowDialog();
            //FormAddScalesConnection formAddWeighingMachine = new FormAddScalesConnection(_langPack);

            //int number = WeighingMachines.OrderByDescending(i => i.Number).FirstOrDefault()?.Number ?? 0;
            
            //if (formAddWeighingMachine.ShowDialog() == DialogResult.OK)
            //{
            //    WeighingMachines.Add(
            //        new WeighingMachine()
            //        {
            //            Name = formAddWeighingMachine.NameMachine,
            //            IP = $"{formAddWeighingMachine.IpAddress}:{formAddWeighingMachine.Port}",
            //            Number = ++number
            //        });

            //    SetData();
            //}
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            //SettingManager.Save(WeighingMachines);
            //Close();
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            //if (dataGrid.SelectedRows.Count > 0)
            //{
            //   /// WeighingMachines.RemoveAt(dataGrid.Rows[].Index);
            //}
            //SetData();
        }

        private void ButtonFind_Click(object sender, EventArgs e)
        {

        }

       

        private void Uch_DeviceDisconnected(object sender, EventArgs e)
        {
            Debug.WriteLine("DeviceDisconnected");
        }

        private void Uch_DeviceConnected(object sender, EventArgs e)
        {
            //Debug.WriteLine("DeviceConnected");
        }

        private void ChkBox_CheckedChanged(object sender, EventArgs e)
        {
            //foreach (WeighingMachine itm in WeighingMachines)
            //{
            //    itm.Unload = ChkBox.Checked;
            //}
            //SetData();
        }
    }
}
