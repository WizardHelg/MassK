using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassK.Settings
{
    class ProjectManager
    {
        private readonly string _folder = SettingManager.Projects;
        public List<Project> Projects { get; private set; }
        public ProjectManager()
        {
            Projects = LoadProjectsFromFolder(_folder);
        }

        private List<Project> LoadProjectsFromFolder(string folder)
        {
            List<Project> projects = new List<Project>();
            foreach (string file in Directory.GetFiles(folder, "*.xml"))
            {
                try
                {
                    Project project = new Project(file);
                    if (project != null)
                    {

                    }
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
    }
}
