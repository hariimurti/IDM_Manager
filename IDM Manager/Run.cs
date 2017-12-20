using System.Diagnostics;
using System;

namespace IDM_Manager
{
    class Run
    {
        private static void Registry(string arg)
        {
            var p = new Process();
            p.StartInfo.FileName = "reg";
            p.StartInfo.Arguments = arg;
            p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            p.StartInfo.Verb = "runas";
            p.Start();
            p.WaitForExit();
        }

        public static bool RegBackup(string _file)
        {
            try
            {
                Registry("export HKEY_CURRENT_USER\\Software\\DownloadManager " + _file + " /y");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }

        public static bool RegRestore(string _file)
        {
            try
            {
                Registry("import " + _file);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }

        public static void ShutdownIDM()
        {
            string system32 = Environment.GetFolderPath(Environment.SpecialFolder.SystemX86);
            var p = new Process();
            p.StartInfo.FileName = system32 + "\\taskkill.exe";
            p.StartInfo.Arguments = "/f /im IDMan.exe";
            p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            p.StartInfo.Verb = "runas";
            p.Start();
            p.WaitForExit();
        }

        public static void StartIDM(string ExePath)
        {
            ProcessStartInfo exe = new ProcessStartInfo();
            exe.FileName = ExePath;
            exe.WindowStyle = ProcessWindowStyle.Hidden;
            Process.Start(exe);
        }
    }
}
