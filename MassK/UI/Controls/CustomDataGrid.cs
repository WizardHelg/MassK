using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MassK.UI.Controls
{
    class CustomDataGrid : DataGridView
    {
       public CustomDataGrid()
        {
            DoubleBuffered = true;
            AllowUserToDeleteRows = false;
           // AllowUserToResizeRows = false;
            
           // DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
           // imgCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
           // Columns.Add(imgCol);
            //Graphics graphics = new System.Drawing.();
           // Graphics g = new Graphics() ;//new Rectangle(0, 0, 199, 199);
           // imgCol.Image = new Bitmap(200,200,g ); //Graphics( Brush()  );
        }
    }
}
