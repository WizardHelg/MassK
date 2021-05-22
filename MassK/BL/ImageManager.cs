using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Drawing.Imaging;
using MassK.Data;
using MassK.Settings;
using System.Text;

namespace MassK.BL
{
    static class ImageManager
    {
        static readonly string[] _image_extentions = new string[] { ".bmp", ".png", ".tiff", ".img", ".gif", ".jpg", ".jpeg" };

        public static string ImageFilter()
        {
            StringBuilder builder = new StringBuilder();
            foreach (string extention in _image_extentions)
                builder.Append($"*{extention};");

            builder.Remove(builder.Length - 1, 1);
            return $"Файлы изображений|{builder}";
        }

        public static (string Path, string Name) ImportPicture(string sourcePath, string save_directory, int ID, bool isLogo = false)
        {
            string save_path;
            string name;
            if (isLogo)
            {
                name = "Logo";
                save_path = Path.Combine(save_directory, $"0_User_Logo{Path.GetExtension(sourcePath)}");
            }
            else
            {
                name = Path.GetFileNameWithoutExtension(sourcePath);
                save_path = Path.Combine(save_directory, $"{ID}_User_{Path.GetFileName(sourcePath)}");
            }


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
            return (save_path, name);
        }

        public static int GetFreeId(List<ImageItem> list)
        {
            int id = list.OrderByDescending(i => i.ID).FirstOrDefault()?.ID ?? 0;
            return id < 10_000 ? 10_000 : id + 1;
        }

        public static List<ImageItem> LoadPictures(string path)
        {
            List<ImageItem> buffer = new List<ImageItem>();

            foreach(var file in Directory.GetFiles(path))
                if (_image_extentions.Contains(Path.GetExtension(file)))
                {
                    string[] data = Path.GetFileNameWithoutExtension(file).Split(new[] { '_' }, 3);

                    if (data.Count() != 3)
                        continue;

                    if (int.TryParse(data[0], out int id))
                    {
                        ImageItem image = new ImageItem()
                        {
                            ID = id,
                            Group = data[1],
                            Name = data[2],
                            Path = file
                        };

                        using(FileStream fs = new FileStream(file, FileMode.Open))
                            image.Picture = Image.FromStream(fs);

                        buffer.Add(image);
                    }
                }

            return buffer;
        }
    }
}
