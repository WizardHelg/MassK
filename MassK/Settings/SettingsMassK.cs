using MassK.Exceptions;
using System.IO;


namespace MassK.Settings
{
    class SettingsMassK
    {
        readonly Properties.Settings settings = Properties.Settings.Default;

        public enum SettingTypeEnum
        {
            PathLengPacksXML,
            TestExcel
               
        }

        public bool GetSetting(SettingTypeEnum settingType, out string path)
        {
            var (_result, _path) = _GetSetting(settingType);
            path = _path;
            return _result;
        }

        private (bool, string) _GetSetting(SettingTypeEnum prop_name)
        {

            string path = (string)settings[prop_name.ToString()];
            bool path_exist = false;
            switch (prop_name)
            {               
                case SettingTypeEnum.PathLengPacksXML:
                    path_exist = Directory.Exists(path);
                    break;
                case SettingTypeEnum.TestExcel:
                    path_exist = File.Exists(path);
                    break;               
            }

            if (path != "" && path_exist)
                return (true, path);
            else throw new BException("Check Settings!");
            //if (RequestSettings() == DialogResult.OK)
            //{
            //    return (true, (string)settings[prop_name.ToString()]);
            //}
            //else return (false, "");
        }

        //private DialogResult RequestSettings()
        //{
        //    DialogResult result;
        //    SettingsForm settingsForm = new Forms.SettingsForm();
        //    result = settingsForm.ShowDialog();
        //    settingsForm.Close();
        //    return result;
        //}
    }
}
