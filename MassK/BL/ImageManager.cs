using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Drawing.Imaging;

namespace MassK.BL
{
    static class ImageManager
    {
        public static string[] ImageExtentions = new string[] { ".bmp", ".png", ".tiff", ".img", ".gif", ".", ".", ".", ".", ".", ".jpg", ".jpeg" };

        public static string ImportPicture(string sourcePath)
        {
            
            string save_path = Path.Combine(SettingManager.ImagePath, $"{Path.GetFileNameWithoutExtension(sourcePath)}.png");
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
            using(Graphics g = Graphics.FromImage(t_bitmap))
            {
                g.Clear(Color.Transparent);
                g.CompositingQuality = CompositingQuality.HighQuality;
                g.SmoothingMode = SmoothingMode.HighQuality;
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.PixelOffsetMode = PixelOffsetMode.HighQuality;
                g.DrawImage(s_bitmap, t_rec);
            }

            t_bitmap.Save(save_path, ImageFormat.Png);

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

            if (images is null) images = new List<ImageItem>();
            string[] files = Directory.GetFiles(SettingManager.ImagePath);
            foreach (string file in files)
            {
                FileInfo fi = new FileInfo(file);
                string extention = fi.Extension.ToLower();
                if (extention != ".png") continue;

                Image picture = new Bitmap(file);

                ImageItem item = images.Find(x => x.Path == file) ?? default;
                if (item is null)
                {
                    item = new ImageItem()
                    {
                        Id = ImageManager.GetFreeId(images),
                        Name = Path.GetFileNameWithoutExtension(file),
                        Path = file,
                        Picture = picture
                    };
                    images.Add(item);
                }
                else
                {
                    item.Picture = picture;
                }
            }
            return images;
        }
    }
}
