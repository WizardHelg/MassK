using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassK.UI
{
    static class StyleUI
    {
        public static Color BackColor { get; set; } = Color.White;
        public static Color FontColor1 { get; set; } = Color.White;
        public static Color FontColor2 { get; set; } = Color.Black;
        //public static Color FrameColor { get; set; } = Color.FromArgb(55, 107, 158); // Color.DeepSkyBlue;
        public static Color FrameBlueColor { get; set; } = Color.FromArgb(55, 109, 163); // Color.DeepSkyBlue;
        public static Color GrayColor { get; set; } = Color.FromArgb(179, 179, 179); // Color.DeepSkyBlue;
        public static Color BlackColor { get; set; } = Color.FromArgb(0,0,0); // Color.DeepSkyBlue;
        public static Color RedColor { get; set; } = Color.FromArgb(230,75,68); // Color.DeepSkyBlue;


        public static Color ButtonBackColor { get; set; } = Color.White;
        public static Color ButtonFontColor { get; set; } = Color.DarkBlue;

        public static Font FontControls12 { get; set; } = new Font("Verdana", 12, FontStyle.Regular);

    }
}
