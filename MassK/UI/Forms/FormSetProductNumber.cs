using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MassK.UI.Forms
{
    public enum ProductNumber
    {
        Operator,
        PLU
    }
    public partial class FormSetProductNumber : Form
    {
        public ProductNumber ProductNumber { get; set; } 

        public FormSetProductNumber()
        {
            InitializeComponent();
        
        }



        private void RBtnPLU_CheckedChanged(object sender, EventArgs e)
        {
            ProductNumber = ProductNumber.PLU;
            
        }

        private void RBtnOperator_CheckedChanged(object sender, EventArgs e)
        {
            ProductNumber = ProductNumber.Operator;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void FormSetProductNumber_Load(object sender, EventArgs e)
        {
            if (ProductNumber == ProductNumber.Operator)
            {
                RBtnOperator.Checked = true;

            }
            else
            {
                RBtnPLU.Checked = true;
            }
        }
    }
}
