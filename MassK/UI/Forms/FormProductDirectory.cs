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
        // private List<Product> Products { get; set; }

        public FormProductDirectory(LangPack langPack)
        {
            langPack.SetText(this);
            InitializeComponent();
            panel1.BackColor = StyleUI.FrameBlueColor;
            panel2.BackColor = StyleUI.FrameBlueColor;

            SetColumns();
        }

        private void SetColumns()
        {
            dataGrid.Columns.Clear();
            dataGrid.RowHeadersVisible = false;

            dataGrid.Columns.Add("ID", "ID - товара");
            dataGrid.Columns.Add("Code", "Code - товара");
            dataGrid.Columns.Add("PLU", "PLU");
            dataGrid.Columns.Add("ProducеName", "Наименование товара");
            dataGrid.Columns.Add("Number", "№");
            DataGridViewCheckBoxColumn selectColumn = new DataGridViewCheckBoxColumn()
            {
                Name = "Selected",
                HeaderText = "Выбранные"
            };

            dataGrid.Columns.Add(selectColumn);
            selectColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGrid.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGrid.Columns[0].DataPropertyName = "ProductID";
            dataGrid.Columns[1].DataPropertyName = "Code";
            dataGrid.Columns[2].DataPropertyName = "PLU";
            dataGrid.Columns[3].DataPropertyName = "ProducеName";
            dataGrid.Columns[4].DataPropertyName = "Number";
            dataGrid.Columns[4].Visible = false;
            dataGrid.Columns[5].DataPropertyName = "Selected";
        }

        private void BtnApply_Click(object sender, EventArgs e)
        {
            foreach(Product product in ProjectMandger.Products)
            {
                if (product.Selected)
                {
                    ProjectMandger.KeyboardItems.Add(new KeyboardItem()
                    {
                        Name = product.ProductName,
                        ID = product.ProductID,
                        Code=product.Code,
                        Number = product.Number
                    });
                }
            }
            Close();
        }

        private void SetSorceDataGrid(List<Product> products)
        {
            dataGrid.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGrid.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGrid.DataSource = products;
        }

        private void FormProductDirectory_Load(object sender, EventArgs e)
        {
            ProjectMandger.Products = SettingManager.Load<Product>();
            if ((ProjectMandger.Products?.Count ?? 0) == 0)
            {
                ProjectMandger.Products = new List<Product>()
                {
                    new Product(){ProductID = 2, Code= "155", PLU = "33",   ProductName = "Абрикосы", Selected = false  },
                    new Product(){ProductID = 112, Code= "15", PLU = "313", ProductName = "Апельсин", Selected = true   },
                    new Product(){ProductID = 122, Code= "55", PLU = "123", ProductName = "Кабачки",  Selected = false  },
                    new Product(){ProductID = 124, Code= "5", PLU = "3",    ProductName = "Перец",    Selected = false  },
                    new Product(){ProductID = 126, Code= "544", PLU = "2",  ProductName = "Вишня",    Selected = true   },
                    new Product(){ProductID = 135, Code= "5235", PLU = "4", ProductName = "Ежевика",  Selected = false  },
                    new Product(){ProductID = 121, Code= "533", PLU = "67", ProductName = "Малина",   Selected = false  },
                    new Product(){ProductID = 17, Code= "5313", PLU = "671", ProductName = "Капуста", Selected = false  },
                    new Product(){ProductID = 154, Code= "5343", PLU = "633", ProductName = "Груша",  Selected = false  },
                    new Product(){ProductID = 47, Code= "5333", PLU = "17", ProductName = "Огурцы",   Selected = false  },
                    new Product(){ProductID = 2, Code= "155", PLU = "33",   ProductName = "Абрикосы", Selected = false  },
                    new Product(){ProductID = 112, Code= "15", PLU = "313", ProductName = "Апельсин", Selected = true   },
                    new Product(){ProductID = 122, Code= "55", PLU = "123", ProductName = "Кабачки",  Selected = false  },
                    new Product(){ProductID = 124, Code= "5", PLU = "3",    ProductName = "Перец",    Selected = false  },
                    new Product(){ProductID = 126, Code= "544", PLU = "2",  ProductName = "Вишня",    Selected = true   },
                    new Product(){ProductID = 135, Code= "5235", PLU = "4", ProductName = "Ежевика",  Selected = false  },
                    new Product(){ProductID = 121, Code= "533", PLU = "67", ProductName = "Малина",   Selected = false  },
                    new Product(){ProductID = 17, Code= "5313", PLU = "671", ProductName = "Капуста", Selected = false  },
                    new Product(){ProductID = 154, Code= "5343", PLU = "633", ProductName = "Груша",  Selected = false  },
                    new Product(){ProductID = 47, Code= "5333", PLU = "17", ProductName = "Огурцы",   Selected = false  }
                };
            }

            //  dataGrid.DataSource = ProjectMandger.Products;

            SetSorceDataGrid(ProjectMandger.Products);

          
           // dataGrid.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            FillFields();
        }

        Dictionary<string, int> fields;
        private Dictionary<string, int> GetFields()
        {
            if (fields is null)
            {
                fields = new Dictionary<string, int>();
                foreach (DataGridViewColumn column in dataGrid.Columns)
                {
                    if (!fields.ContainsKey(column.HeaderText) && fields.Count < 4)
                    {
                        fields.Add(column.HeaderText, fields.Count);
                    }
                }
            }
            return fields;
        }

        private void FillFields()
        {
            CBoxFields.Items.Clear();
           fields = GetFields();
            foreach (string field in fields.Keys)
            {
                CBoxFields.Items.Add(field);
            }
            CBoxFields.SelectedIndex = 0;
        }

        private void TboxFilter_TextChanged(object sender, EventArgs e)
        {
            string selectedField = CBoxFields.Text;
            List<Product> filterItems = default;
            if (!fields.ContainsKey(selectedField)) return;

            if (fields[selectedField] == 0)
            {
                filterItems = ProjectMandger.Products.Where(x => x.ProductID.ToString().IndexOf(TboxFilter.Text, 0, StringComparison.InvariantCultureIgnoreCase) >= 0).ToList();
            }
            else if (fields[selectedField] == 1)
            {
                filterItems = ProjectMandger.Products.Where(x => x.Code.IndexOf(TboxFilter.Text, 0, StringComparison.InvariantCultureIgnoreCase) >= 0).ToList();
            }
            else if (fields[selectedField] == 2)
            {
                filterItems = ProjectMandger.Products.Where(x => x.PLU.IndexOf(TboxFilter.Text, 0, StringComparison.InvariantCultureIgnoreCase) >= 0).ToList();
            }
            else if (fields[selectedField] == 3)
            {
                filterItems = ProjectMandger.Products.Where(x => x.ProductName.ToString().IndexOf(TboxFilter.Text, 0, StringComparison.InvariantCultureIgnoreCase) >= 0).ToList();
            }


            if (string.IsNullOrEmpty(TboxFilter.Text))
            {
                SetSorceDataGrid(ProjectMandger.Products);
            }
            else
            {               
                SetSorceDataGrid(filterItems);
            }

            //if ((filterItems?.Count ?? 0) != 0)
            //{

            //}
            //else
        }
    }
}
