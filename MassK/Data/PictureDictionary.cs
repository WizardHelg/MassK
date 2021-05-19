using MassK.BL;
using MassK.Exceptions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassK.Data
{
    public class PictureDictionary
    {

        public PictureDictionary()
        {
            // SettingManager.Save(_images);
        }

        static public List<ImageItem> GetAllImages()
        {
            List<ImageItem> images = new List<ImageItem>();
            images.AddRange(GetDefaultImages());
            images.AddRange(GetUserImages());
            try
            {
                images.Add(Logo());
            }
            catch(Exception) { }
            return images;
        }


        private static ImageItem Logo()
        {
            string[] files = Directory.GetFiles(SettingManager.LogoPath);
            foreach (string file in files)
            {
                try
                {
                    FileInfo fi = new FileInfo(file);
                    string extention = fi.Extension.ToLower();
                    if (ImageManager.ImageExtentions.Contains(extention, StringComparer.InvariantCultureIgnoreCase))
                    {
                        string fileName = Path.GetFileNameWithoutExtension(fi.Name);
                        // string[] NameItems = fileName.Split('_');
                        // string name = (NameItems.Length >= 3) ? NameItems[2] : "";

                        return new ImageItem()
                        {
                            Path = file,
                            Id = 0,
                            Group = "Логотип",
                            Name = fileName
                        };
                    }
                }
                catch (Exception) { }
            }
            throw new BException("Не удалось найти изображение");
        }

        private static List<ImageItem> GetUserImages()
        {
            List<ImageItem> images = LoadFromFolder(SettingManager.UserPictures);
            images.ForEach(x => x.IsUserFile = false);
            return images;
        }

        static public List<ImageItem> GetDefaultImages()
        {
            return LoadFromFolder(SettingManager.DefaultImagesPath);
        }

        private static List<ImageItem> LoadFromFolder(string folder)
        {
            List<ImageItem> images = new List<ImageItem>();
            string[] files = Directory.GetFiles(folder);
            foreach (string file in files)
            {
                try
                {
                    ImageItem imageItem = GetImageItem(file);
                    images.Add(imageItem);
                }
                catch (Exception) { }               
            }
            return images;
        }

        private static ImageItem GetImageItem(string file)
        {
            FileInfo fi = new FileInfo(file);
            string extention = fi.Extension.ToLower();
            if (ImageManager.ImageExtentions.Contains(extention, StringComparer.InvariantCultureIgnoreCase))
            {
                string fileName = Path.GetFileNameWithoutExtension(fi.Name);
                string[] NameItems = fileName.Split('_');
                string id = NameItems[0];
                int.TryParse(id, out int numId);
                string group = (NameItems.Length >= 2) ? NameItems[1] : "";
                string name = (NameItems.Length >= 3) ? NameItems[2] : "";
                return new ImageItem()
                {
                    Path = file,
                    Id = numId,
                    Group = group,
                    Name = name
                };
            }
            throw new BException("Расширение не соответствует изображениям");
        }
    }
}
