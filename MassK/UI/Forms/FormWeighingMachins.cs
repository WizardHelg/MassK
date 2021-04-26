using MassK.BL;
using MassK.LangPacks;
using MassK.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MassK
{
    public partial class FormWeighingMachins : Form
    {
        public List<WeighingMachine> WeighingMachines { get; set; }


        LangPack _langPack;

        public FormWeighingMachins(LangPack langPack)
        {
            _langPack = langPack;
            langPack.SetText(this);
            InitializeComponent();
            panel1.BackColor = StyleUI.FrameColor;
            panel2.BackColor = StyleUI.FrameColor;
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
            dataGrid.DataSource = null;
            dataGrid.DataSource = WeighingMachines;
            dataGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGrid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }


        private void BtnAdd_Click(object sender, EventArgs e)
        {
            FormAddWeighingMachine formAddWeighingMachine = new FormAddWeighingMachine(_langPack);

            int number = WeighingMachines.OrderByDescending(i => i.Number).FirstOrDefault()?.Number ?? 0;
            
            if (formAddWeighingMachine.ShowDialog() == DialogResult.OK)
            {
                WeighingMachines.Add(
                    new WeighingMachine()
                    {
                        Name = formAddWeighingMachine.Name,
                        IP = $"{formAddWeighingMachine.IpAddress}:{formAddWeighingMachine.Port}",
                        Number = ++number
                    });

                SetData();
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SettingManager.Save(WeighingMachines);
            Close();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dataGrid.SelectedRows.Count > 0)
            {
                WeighingMachines.RemoveAt(dataGrid.SelectedRows[0].Index);
            }
            SetData();
        }

        private void BtnFind_Click(object sender, EventArgs e)
        {

        }

        private void BtnCheckConnection_Click(object sender, EventArgs e)
        {

        }

        private void ChkBox_CheckedChanged(object sender, EventArgs e)
        {
            foreach (WeighingMachine itm in WeighingMachines)
            {
                itm.Load = ChkBox.Checked;
            }
            SetData();
        }
    }
}
