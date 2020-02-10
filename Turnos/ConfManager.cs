using System;
using System.Configuration;

namespace Turnos
{
    class ConfManager
    {
        public ConfManager() { }

        public void ReadAllSettings()
        {
            //try
            //{
            //    var appSettings = ConfigurationManager.AppSettings;

            //    if (appSettings.Count == 0)
            //    {
            //        Console.WriteLine("AppSettings is empty.");
            //    }
            //    else
            //    {
            //        foreach (var key in appSettings.AllKeys)
            //        {
            //            Console.WriteLine("Key: {0} Value: {1}", key, appSettings[key]);
            //        }
            //    }
            //}
            //catch (ConfigurationErrorsException)
            //{
            //    Console.WriteLine("Error reading app settings");
            //}
        }

        public string ReadSetting(string key)
        {
            //try
            //{
            //    var appSettings = ConfigurationManager.AppSettings;
            //    string result = appSettings[key] ?? "Not Found";
            //    return result;
            //}
            //catch (ConfigurationErrorsException)
            //{
            //    Console.WriteLine("Error reading app settings");
            //    return null;
            //}

            try
            {
                string result = Properties.Settings.Default[key].ToString() ?? "Not Found";
                return result;
            }
            catch (Exception)
            {
                Console.WriteLine("Error reading app settings");
                throw;
            }
        }

        public void AddUpdateAppSettings(string key, string value)
        {
            //try
            //{
            //    var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            //    var settings = configFile.AppSettings.Settings;
            //    if (settings[key] == null)
            //    {
            //        settings.Add(key, value);
            //    }
            //    else
            //    {
            //        settings[key].Value = value;
            //    }
            //    configFile.Save(ConfigurationSaveMode.Modified);
            //    ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
            //}
            //catch (ConfigurationErrorsException)
            //{
            //    Console.WriteLine("Error writing app settings");
            //}

            try
            {
                var settings = Properties.Settings.Default;
                if (settings[key] == null)
                {
                    settings[key] = value;
                }
                else
                {
                    settings[key] = value;
                }
                settings.Save();
                settings.Reload();
            }
            catch (Exception)
            {
                Console.WriteLine("Error writing app settings");
                throw;
            }
        }

        public void RemoveSetting(string key)
        {
            //try
            //{
            //    var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            //    var settings = configFile.AppSettings.Settings;
            //    if (settings[key] != null)
            //    {
            //        settings.Remove(key);
            //    }
            //    configFile.Save(ConfigurationSaveMode.Modified);
            //    ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
            //}
            //catch (ConfigurationErrorsException)
            //{
            //    Console.WriteLine("Error removing app setting");
            //}

            try
            {
                var settings = Properties.Settings.Default;
                if (settings[key] != null)
                {
                    settings[key] = null;
                }
                settings.Save();
                settings.Reload();
            }
            catch (Exception)
            {
                Console.WriteLine("Error removing app setting");
                throw;
            }
        }
    }
}
