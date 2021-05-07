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
    public partial class FormProductDirectory : Form
    {
        private List<Product> Products { get; set; }

        public FormProductDirectory(LangPack langPack)
        {
            langPack.SetText(this);
            InitializeComponent();
            panel1.BackColor = StyleUI.FrameBlueColor;
            panel2.BackColor = StyleUI.FrameBlueColor;
        }

        private void BtnApply_Click(object sender, EventArgs e)
        {

        }

        private void FormProductDirectory_Load(object sender, EventArgs e)
        {
            Products = SettingManager.Load<Product>();
            if ((Products?.Count ?? 0) == 0)
            {
                Products = new List<Product>()
                {
                    new Product(){ProductID = 2, Code= "155", PLU = "33",   ProducеName = "Абрикосы", Selected = false  },
                    new Product(){ProductID = 112, Code= "15", PLU = "313", ProducеName = "Апельсин", Selected = true   },
                    new Product(){ProductID = 122, Code= "55", PLU = "123", ProducеName = "Кабачки",  Selected = false  },
                    new Product(){ProductID = 124, Code= "5", PLU = "3",    ProducеName = "Перец",    Selected = false  },
                    new Product(){ProductID = 126, Code= "544", PLU = "2",  ProducеName = "Вишня",    Selected = true   },
                    new Product(){ProductID = 135, Code= "5235", PLU = "4", ProducеName = "Ежевика",  Selected = false  },
                    new Product(){ProductID = 121, Code= "533", PLU = "67", ProducеName = "Малина",   Selected = false  },
                    new Product(){ProductID = 17, Code= "5313", PLU = "671", ProducеName = "Капуста", Selected = false  },
                    new Product(){ProductID = 154, Code= "5343", PLU = "633", ProducеName = "Груша",  Selected = false  },
                    new Product(){ProductID = 47, Code= "5333", PLU = "17", ProducеName = "Огурцы",   Selected = false  },
                };
            }
                    

            dataGrid.DataSource = Products;
            dataGrid.RowHeadersVisible = false;
            dataGrid.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
