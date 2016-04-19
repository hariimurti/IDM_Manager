using System.Diagnostics;
using System;

namespace IDM_Manager
{
    class Run
    {
        public static void RegBackup(string _file)
        {
            ProcessStartInfo reg = new ProcessStartInfo();
            reg.FileName = "reg";
            reg.Arguments = "export HKEY_CURRENT_USER\\Software\\DownloadManager " + _file + " /y";
            reg.WindowStyle = ProcessWindowStyle.Hidden;
            Process exec = Process.Start(reg);
            exec.WaitForExit();
        }

        public static void RegRestore(string _file)
        {
            ProcessStartInfo reg = new ProcessStartInfo();
            reg.FileName = "reg";
            reg.Arguments = "import " + _file;
            reg.WindowStyle = ProcessWindowStyle.Hidden;
            Process exec = Process.Start(reg);
            exec.WaitForExit();
        }

        public static void ShutdownIDM()
        {
            string system32 = Environment.GetFolderPath(Environment.SpecialFolder.SystemX86);
            ProcessStartInfo exe = new ProcessStartInfo();
            exe.FileName = system32 + "\\taskkill.exe";
            exe.Arguments = "/f /im IDMan.exe";
            exe.WindowStyle = ProcessWindowStyle.Hidden;
            Process exec = Process.Start(exe);
            exec.WaitForExit();
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
