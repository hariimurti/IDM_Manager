using Microsoft.Win32;
using System;
using System.IO;

namespace IDM_Manager
{
    class GetInfo
    {
        static RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\DownloadManager", true);
        static string userProfileName = Environment.UserName;

        public static string[] System()
        {
            string ExePath, idmData, DwnlData;
            if (registryKey != null)
            {
                ExePath = registryKey.GetValue("ExePath").ToString();
                idmData = registryKey.GetValue("AppDataIDMFolder").ToString();
                DwnlData = Path.Combine(registryKey.GetValue("TempPath").ToString(), "DwnlData");
            }
            else
            {
                string userProfile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                string x32 = "C:\\Program Files\\Internet Download Manager\\IDMan.exe";
                string x64 = "C:\\Program Files (x86)\\Internet Download Manager\\IDMan.exe";
                if (File.Exists(x32))
                {
                    ExePath = x32;
                }
                else if (File.Exists(x64))
                {
                    ExePath = x64;
                }
                else
                {
                    ExePath = null;
                }
                idmData = Path.Combine(userProfile, "AppData\\Roaming\\IDM");
                DwnlData = Path.Combine(idmData, "DwnlData");
            }

            return new string[] { ExePath, idmData, DwnlData };
        }

        public static string[] IDM(string ExePath, string idmData, string DwnlData)
        {
            string idm = "Not Installed";
            string version = "Unknown";
            string setting = "Not Found ( NO )";
            string data = "Not Found ( NO )";
            bool backup = false;

            if ((ExePath != null) && File.Exists(ExePath))
            {
                // check installed idm
                if (registryKey != null)
                {
                    //check idm version in registry
                    string value = registryKey.GetValue("idmvers").ToString();
                    if (value != null)
                    {
                        version = value;
                    }
                }
                idm = "Installed ( " + version + " )";
            }

            //check registry & idm data
            if ((registryKey != null) && (Directory.Exists(idmData)))
            {
                setting = "Found ( OK )";
                backup = true;
            }

            //check download data (temp) location
            if (Directory.Exists(DwnlData))
            {
                if (DwnlData.Contains(userProfileName))
                {
                    data = "Default Location ( OK )";
                }
                else
                {
                    data = "Custom Location ( OK )";
                }
            }
            else
            {
                backup = false;
            }

            // return backup will be enable or disable
            if (backup)
            {
                return new string[] { idm, setting, data, "1" };
            }
            else
            {
                return new string[] { idm, setting, data, "0" };
            }
        }

        public static string[] Backup(string _fileBackup)
        {
            string SettingCreationTime, SettingSize;
            if (File.Exists(_fileBackup))
            {
                SettingCreationTime = File.GetLastWriteTime(_fileBackup).ToString("dd/MM/yyyy @ HH:mm");
                SettingSize = GetSize.FromFile(_fileBackup);
                return new string[] { SettingCreationTime, SettingSize, "1" };
            }
            else
            {
                return new string[] { "-", "-", "0" };
            }
        }

        public static string Username(string _file)
        {
            string[] user = File.ReadAllLines(_file);
            return user[0];
        }
    }
}
