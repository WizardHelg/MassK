using MassK.Data;
using MassK.Exceptions;
using MassK.Settings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace MassK.BL
{
    class ProjectMandger
    {
        public static readonly Properties.Settings settings = Properties.Settings.Default;

        public static List<ImageItem> Images
        {
            get
            {
                if (_Images is null)
                {
                    //_Images = ImageManager.GetImages();
                }
                return _Images;
            }
            set
            {
                _Images = value;
            }
        }
        static List<ImageItem> _Images;

       public static List<KeyboardItem> KeyboardItems
        {
            get
            {
                if (_KeyboardItems is null) _KeyboardItems = new List<KeyboardItem>();
                return _KeyboardItems;
            }
            set => _KeyboardItems = value;
        }
        static List<KeyboardItem> _KeyboardItems;

        public static List<Product> Products
        {
            get
            {
                if (_Products is null) _Products = new List<Product>();
                return _Products;
            }
            set => _Products = value;
        }
        static List<Product> _Products;
    }
}

