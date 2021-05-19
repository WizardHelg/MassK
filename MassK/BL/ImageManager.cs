using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Drawing.Imaging;
using MassK.Data;

namespace MassK.BL
{
    static class ImageManager
    {
        public static string[] ImageExtentions = new string[] { ".bmp", ".png", ".tiff", ".img", ".gif", ".jpe", ".jfif", ".jpg", ".jpeg" };

        public static string ImportUserPicture(string sourcePath, string savePath)
        {            
            string newName = $"{99999}_UserPictures_{Path.GetFileNameWithoutExtension(sourcePath)}";
            string save_path = Path.Combine(savePath, $"{newName}.png");
           return ImportPicture(sourcePath, save_path);
        }
        internal static string ImportLogo(string sourcePath, string savePath)
        {
            string newName = $"{0}_UserPictures_{Path.GetFileNameWithoutExtension(sourcePath)}";
            string save_path = Path.Combine(savePath, $"{newName}.png");
            return ImportPicture(sourcePath, save_path);
        }


        public static string ImportPicture(string sourcePath, string save_path)
        {           
            Bitmap s_bitmap = new Bitmap(sourcePath);

            float k = Math.Min(320 / (float)s_bitmap.Width, 240 / (float)s_bitmap.Height);

            SizeF t_size = new SizeF
            {
                Width = s_bitmap.Width * k,
                Height = s_bitmap.Height * k
            };

            RectangleF t_rec = new RectangleF()
            {
                Location = new PointF
                {
                    X = (320 - t_size.Width) / 2,
                    Y = (240 - t_size.Height) / 2
                },
                Size = t_size
            };

            Bitmap t_bitmap = new Bitmap(320, 240, PixelFormat.Format32bppArgb);
            using (Graphics g = Graphics.FromImage(t_bitmap))
            {
                g.Clear(Color.Transparent);
                g.CompositingQuality = CompositingQuality.HighQuality;
                g.SmoothingMode = SmoothingMode.HighQuality;
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.PixelOffsetMode = PixelOffsetMode.HighQuality;
                g.DrawImage(s_bitmap, t_rec);
            }

            try
            {
                t_bitmap.Save(save_path, ImageFormat.Png);
            }
            catch { save_path = ""; };
            return save_path;
        }

        public static int GetFreeId(List<ImageItem> list)
        {
            int id = list.OrderByDescending(i => i.Id).FirstOrDefault()?.Id ?? 0;
            return id < 10_000 ? 10_000 : id + 1;
        }

        public static List<ImageItem> LoadPictures()
        {
            List<ImageItem> images = SettingManager.Load<ImageItem>();
            if (images is null)  images = new List<ImageItem>();

            foreach (ImageItem item in images)
            {              
                if (!string.IsNullOrEmpty(item.Path))
                {
                    if (File.Exists(item.Path))
                    {
                        FileInfo fi = new FileInfo(item.Path);
                        item.Picture = new Bitmap(item.Path);
                        string[] filename = Path.GetFileNameWithoutExtension(fi.Name).Split('_');
                        int.TryParse(filename[0], out int id);
                        item.Id = id;
                        item.Group = (filename.Length >= 2) ? filename[1] : "";
                        item.Name = (filename.Length >= 3) ? filename[2] : "";
                    }
                }
            }
            return images;
        }

        public static List<ImageItem> GetImages()
        {
            List<ImageItem> images = SettingManager.Load<ImageItem>();
            if (images is null)
            {                
                images =  PictureDictionary.GetAllImages();
                SettingManager.Save(images);
            }
            images = LoadPictures(); 
            return images;
        }
    }
}
