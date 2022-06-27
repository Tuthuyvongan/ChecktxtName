using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ChecktxtName
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        public int i;
        public int temp;

        public void LoadFile()
        {
            //Create instance of Open file dialog
            OpenFileDialog file_open = new OpenFileDialog();

            //Setup open file dialog before displaying it
            file_open.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            //Chon dang file mac dinh hien thi dau tien trong combo box neu mo nhieu loai file
            file_open.FilterIndex = 2;
            file_open.Title = "Open novel file";

            //Display the dialog and grab the file name
            if (DialogResult.OK == file_open.ShowDialog())
            {
                if (string.IsNullOrEmpty(file_open.FileName))
                    return;
                //Read file with StreamReader || StreamReader will try to read file in encode UTF-8
                string fileData = file_open.FileName;
                StreamReader sr = new StreamReader(fileData);
                txtNovel.Text = sr.ReadToEnd();
                sr.Close();
            }
        }
        public void LoadName()
        {
            //Create instance of Open file dialog
            OpenFileDialog file_open = new OpenFileDialog();

            //Setup open file dialog before displaying it
            file_open.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            //Chon dang file mac dinh hien thi dau tien trong combo box neu mo nhieu loai file
            file_open.FilterIndex = 2;
            file_open.Title = "Open name file";

            //Display the dialog and grab the file name
            if (DialogResult.OK == file_open.ShowDialog())
            {
                if (string.IsNullOrEmpty(file_open.FileName))
                    return;
                //Read file with StreamReader || StreamReader will try to read file in encode UTF-8
                string fileData = file_open.FileName;
                StreamReader sr = new StreamReader(fileData);
                txtName.Text = sr.ReadToEnd();
                sr.Close();
            }
        }
        public void searchName()
        {
            txtSaveName.Text = null;
            string[] lines = txtName.Text.Split('\n');
            temp = lines.Count();
            if (txtName.Text != "")
                bgwLoadFile.RunWorkerAsync();
            for (i = 0; i < lines.Count(); i++)
            {
                if (lines[i].Length > 0)
                {
                    int indexToText;
                    //Find name in novel txt
                    if (lines[i].IndexOf('=') >= 0)
                    {
                        indexToText = txtNovel.Find(lines[i].Substring(0, lines[i].IndexOf('=')).Trim());
                    }
                    else
                    {
                        indexToText = txtNovel.Find(lines[i].Trim());

                    }
                    //Add name after find out
                    if (indexToText >= 0)
                    {
                        txtSaveName.Text = txtSaveName.Text + lines[i] + "\n";
                    }
                }
            }
        }
        public void saveName()
        {
            string str = txtSaveName.Text;
            using (SaveFileDialog dlgSave = new SaveFileDialog())
                try
                {
                    // SaveFileDialog title
                    dlgSave.Title = "Save File";
                    // Available file extensions
                    dlgSave.Filter = "Text Files (*.txt)|*.txt";
                    if (dlgSave.ShowDialog() == DialogResult.OK && dlgSave.FileName.Length > 0)
                    {
                        UTF8Encoding utf8 = new UTF8Encoding();
                        StreamWriter sw = new StreamWriter(dlgSave.FileName, false, utf8);
                        sw.Write(str);
                        sw.Close();
                        MessageBox.Show("Successful save name");
                    }
                }
                catch (Exception errorMsg)
                {
                    MessageBox.Show(errorMsg.Message);
                }
        }
        private void btLoadFile_Click(object sender, System.EventArgs e)
        {
            LoadFile();
        }

        private void btLoadName_Click(object sender, EventArgs e)
        {
            LoadName();
        }

        private void btFind_Click(object sender, EventArgs e)
        {
            searchName();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            saveName();
        }

        private void bgwLoadFile_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            int a;
            MessageWaitForm msf = new MessageWaitForm();
            Thread backgroundThreadFetchData = new Thread(
                        new ThreadStart(() =>
                        {
                            while( i < temp)
                            {
                                Thread.Sleep(50);
                                a = (i + 1) * 100 / temp;
                                msf.UpdateProgress(a, "Searching name, please wait ... ");
                            }
                            msf.BeginInvoke(new Action(() => msf.Close()));
                        }));
            backgroundThreadFetchData.Start();
            msf.ShowDialog();
        }

        private void bgwLoadFile_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            Application.DoEvents();
        }

        private void bgwLoadFile_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Finish search file");
        }
    }
}
