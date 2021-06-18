using MassK.BL;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MassK.Settings
{
    static class ProjectManager
    {
        private static readonly string _folder = SettingManager.Projects;
        public static List<Project> Projects { get => LoadProjectsFromFolder(_folder); }

        private static List<Project> _projects;

        private static List<Project> LoadProjectsFromFolder(string folder)
        {
            List<Project> projects = new List<Project>();
            foreach (string file in Directory.GetFiles(folder, "*.xml"))
            {
                try
                {
                    Project project = new Project(file);
                    projects.Add(project);
                }
                catch (Exception ex)
                {
#if DEBUG
                    Debug.WriteLine(ex.Message);
#endif
                }
            }
            return projects;
        }

        internal static void SaveProject(List<Product> products, List<KeyboardItem> keyboard)
        {
            try
            {
                string fileName = GetNameNewProject();
                Project project = new Project(fileName)
                {
                    KeyboardItems = keyboard,
                    Products = products
                };
                project.Save();
            }
            catch (ApplicationException ex)
            {
                #if DEBUG
                Debug.WriteLine(ex.Message);
                #endif
            }

            string GetNameNewProject()
            {
                string folder = SettingManager.Projects;
                if (!Directory.Exists(folder))
                    Directory.CreateDirectory(folder);

                string projectName = $"SL_Scale_Keyboard_Project_" +
                                     $"{DateTime.Now.ToShortDateString()}.xml";
                // string fileName = Path.Combine(folder, projectName);
                SaveFileDialog sfd = new SaveFileDialog()
                {
                    InitialDirectory = folder,
                    // Filter = "XML|\"*.xml\"",
                    //DefaultExt = ".xml"                    
                    FileName = projectName
                };
                if (sfd.ShowDialog() != DialogResult.OK) throw new ApplicationException("Отмена выбора файла.");
                //fileName = sfd.FileName;
                //return fileName;
                return sfd.FileName;
            }
        }

    }
}

