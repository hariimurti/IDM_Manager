using Microsoft.Win32;
using System;
using System.IO;
using System.IO.Compression;

namespace IDM_Manager
{
    class Manage
    {
        static RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\DownloadManager", true);
        static string userProfileName = Environment.UserName;
        static string datetime = DateTime.Now.ToString("yyyyMMddHHmmss");
        static string _backup = Path.GetTempPath() + "idm_backup_" + datetime;
        static string _restore = Path.GetTempPath() + "idm_restore_" + datetime;
        static string _DwnlData = _restore + "\\DwnlData\\" + userProfileName;
        static string _UserName = "username.dat";
        static string _bUserName = _backup + "\\" + _UserName;
        static string _rUserName = _restore + "\\" + _UserName;
        static string _Reg = "setting.reg";
        static string _bReg = _backup + "\\" + _Reg;
        static string _rReg = _restore + "\\" + _Reg;
        static string _dReg = _restore + "\\delete.reg";

        public static void Backup(string _fileBackup, string idmData, string DwnlData)
        {
            string Grabber = idmData + "\\Grabber";
            string Scheduler = idmData + "\\Scheduler";
            string _fileTemp = "setting.bak";

            //cleaning *.bak
            deleteFile(_fileTemp);

            //create folder temp
            Folder.Create(_backup);

            //create file text with username on it
            File.WriteAllText(_bUserName, userProfileName);

            //start copying setting & data
            Folder.Copy(DwnlData, _backup + "\\DwnlData", true);
            Folder.Copy(Grabber, _backup + "\\Grabber", true);
            Folder.Copy(Scheduler, _backup + "\\Scheduler", true);
            File.Copy(idmData + "\\cnlurllist.dat", _backup + "\\cnlurllist.dat");
            File.Copy(idmData + "\\defextmap.dat", _backup + "\\defextmap.dat");
            File.Copy(idmData + "\\foldresHistory.txt", _backup + "\\foldresHistory.txt");
            File.Copy(idmData + "\\sts_list.dat", _backup + "\\sts_list.dat");
            File.Copy(idmData + "\\urlexclist.dat", _backup + "\\urlexclist.dat");
            File.Copy(idmData + "\\UrlHistory.txt", _backup + "\\UrlHistory.txt");

            //create backup a registry to _bak0 (setting)
            Run.RegBackup(_bReg);
            
            //create zip from bak1 folder
            ZipFile.CreateFromDirectory(_backup, _fileTemp, CompressionLevel.Optimal, false);

            //check if setting exist will be deleted
            deleteFile(_fileBackup);
            File.Move(_fileTemp, _fileBackup);

            //delete folder bak1
            Folder.Delete(_backup);
        }

        public static void Restore(string _fileBackup, string idmData, string DwnlData)
        {
            //create folder restore
            Folder.Create(_restore);

            //extract zip to folder restore
            ZipFile.ExtractToDirectory(_fileBackup, _restore);

            //getting info
            string username = GetInfo.Username(_rUserName);
            string _target = _restore + "\\DwnlData\\" + username;

            //rename folder if username is not same
            if (userProfileName != username)
            {
                Directory.Move(_target, _DwnlData);
            }

            //restoring registry
            File.WriteAllLines(_dReg, new string[] { "Windows Registry Editor Version 5.00", null, @"[-HKEY_CURRENT_USER\SOFTWARE\DownloadManager]", null, null });
            Run.RegRestore(_dReg);
            Run.RegRestore(_rReg);
            registryKey.SetValue("AppDataIDMFolder", idmData);
            registryKey.SetValue("TempPath", DwnlData.Replace("\\DwnlData", "")); //remove "DwnlData" at the end of path

            //moving folder restore to where belongs
            Folder.Delete(idmData);
            deleteFile(_rReg);
            deleteFile(_rUserName);
            Directory.Move(_restore, idmData);

            //deleting folder restore
            Folder.Delete(_restore);
        }

        public static void deleteFile(string _target)
        {
            if (File.Exists(_target))
            {
                File.Delete(_target);
            }
        }
    }
}
