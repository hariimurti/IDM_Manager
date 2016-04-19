using System;
using System.IO;
using System.Windows.Forms;

namespace IDM_Manager
{
    public partial class Main : Form
    {
        string _fileBackup = "backup.idm";
        string ExePath, idmData, DwnlData;

        public Main()
        {
            InitializeComponent();
            //update info groupbox
            updateInfo();
        }

        private void updateInfo()
        {
            //get detail system
            string[] SystemInfo = GetInfo.System();
            ExePath = SystemInfo[0];
            idmData = SystemInfo[1];
            DwnlData = SystemInfo[2];

            // gbox idm
            string[] IdmInfo = GetInfo.IDM(ExePath, idmData, DwnlData);
            labelIdm.Text = ": " + IdmInfo[0];
            labelSetting.Text = ": " + IdmInfo[1];
            labelData.Text = ": " + IdmInfo[2];
            if (IdmInfo[3] == "1")
            {
                btnBackup.Enabled = true;
            }
            else
            {
                btnBackup.Enabled = false;
            }

            // gbox backup
            string[] FileInfo = GetInfo.Backup(_fileBackup);
            labelDate.Text = ": " + FileInfo[0];
            labelSize.Text = ": " + FileInfo[1];
            if (FileInfo[2] == "1")
            {
                btnRestore.Enabled = true;
            }
            else
            {
                btnRestore.Enabled = false;
            }
        }

        private void disableAllButton()
        {
            btnBackup.Enabled = false;
            btnRestore.Enabled = false;
        }

        public bool dialogAsk(string pertanyaan)
        {
            DialogResult dialogResult = MessageBox.Show(pertanyaan, this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            if (dialogAsk("File backup yg lama akan diganti dgn yg baru. Apakah anda yakin?"))
            {
                disableAllButton();
                Manage.Backup(_fileBackup, idmData, DwnlData);
                updateInfo();
                MessageBox.Show("Backup Operation Completed!!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            if (dialogAsk("Semua setting dan data IDM saat ini akan diganti dgn backup-an. Apakah anda yakin?"))
            {
                disableAllButton();
                Run.ShutdownIDM();
                Manage.Restore(_fileBackup, idmData, DwnlData);
                updateInfo();
                if (File.Exists(ExePath))
                {
                    if (dialogAsk("Restore Operation Completed!! Jalankan IDM kembali?"))
                    {
                        Run.StartIDM(ExePath);
                    }
                }
                else
                {
                    MessageBox.Show("Restore Operation Completed!!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
