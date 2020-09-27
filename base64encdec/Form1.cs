using System;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace base64encdec
{
    public partial class Form1 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        ClassUtility myUtil = new ClassUtility();
        public delegate void SetTextCallback(string text);
        public bool Cancelled = false;
        public string fn;

        public Form1()
        {
            InitializeComponent();
            this.SetStyle(
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint |
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.DoubleBuffer, true);
            // set btn icon
            btnViewImageFile.Image = Properties.Resources.image.ToBitmap();
            // app icon
            this.Icon = Properties.Resources.app;
        }

        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // title
            myUtil.StrTitle = this.Text;
            label1.Text = Application.ProductName + " " + Application.ProductVersion + " " + Environment.NewLine +
                "Email: francois.gonenc@bluewin.ch";
            // center
            this.Location = new Point(((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2),
                (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
            //
            btnViewImageFile.TextImageRelation = TextImageRelation.ImageAboveText;
            btnViewImageFile.ImageAlign = ContentAlignment.MiddleCenter;


            this.Text = "Base64Encoder/Decoder";

            pictureBox1.Visible = false;
            // set font
            richTextBox1.Font = new Font(FontFamily.GenericMonospace, 8.25F, FontStyle.Bold);
            float currentSize = richTextBox1.Font.Size;

            AddContextMenu();
            richTextBox1.Focus();
        }

        ContextMenu mnuContextMenu = new ContextMenu();
        MenuItem mnuItemEncodeSelected = new MenuItem();
        MenuItem mnuItemQuit = new MenuItem();

        public void AddContextMenu()
        {

            mnuItemEncodeSelected.Text = "&Encode selected text";
            mnuItemEncodeSelected.Click += mnuItemEncodeSelected_Click;
            mnuContextMenu.MenuItems.Add(mnuItemEncodeSelected);

            mnuItemQuit.Text = "&Quit";
            mnuItemQuit.Click += mnuItemQuit_Click;
            mnuContextMenu.MenuItems.Add(mnuItemQuit);
            // assign context menu to control
            richTextBox1.ContextMenu = mnuContextMenu;
        }

        public void mnuItemEncodeSelected_Click(object sender, EventArgs e)
        {
            // context menu is processing selected text only
            if (mnuContextMenu.SourceControl == richTextBox1 && richTextBox1.SelectedText.Length > 0)
            {
                Encoder(richTextBox1.SelectedText);
            }
            else if (mnuContextMenu.SourceControl == richTextBox1 && string.IsNullOrEmpty(richTextBox1.SelectedText))
            {
                MessageBox.Show("Selection cannot be empty !");
            }
        }

        public void mnuItemQuit_Click(object sender, EventArgs e)
        {
            if (mnuContextMenu.SourceControl == richTextBox1)
            {
                Application.Exit();
            }
        }

        public Stream ConvertToBase64(Stream stream)
        {
            Byte[] inArray = new Byte[(int)stream.Length];
            Char[] outArray = new Char[(int)(stream.Length * 1.34)];
            stream.Read(inArray, 0, (int)stream.Length);
            Convert.ToBase64CharArray(inArray, 0, inArray.Length, outArray, 0);
            return new MemoryStream(Encoding.UTF8.GetBytes(outArray));
        }

        public string FileToBase64(string fileName)
        {
            using (FileStream reader = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Delete))
            {
                byte[] buffer = new byte[reader.Length];
                reader.Read(buffer, 0, (int)reader.Length);
                return Convert.ToBase64String(buffer);
            }
        }

        public static void Base64ToFile(string fileName, string strText)
        {
            try
            {
                using (System.IO.FileStream reader = System.IO.File.Create(fileName))
                {
                    byte[] buffer = Convert.FromBase64String(strText);
                    reader.Write(buffer, 0, buffer.Length);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Image Base64ToImage(string base64String)
        {
            // Convert Base64 String to byte[]
            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);

            // Convert byte[] to Image
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
        }

        private void btnDecodeToFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            saveFileDialog1.Title = "Save as";
            saveFileDialog1.Filter = "Ico files (*.ico)|*.ico|Text files (*.txt)|*.txt|Tous les fichiers (*.*)|*.*";
            saveFileDialog1.FilterIndex = 3;

            DialogResult result = saveFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                Base64ToFile(saveFileDialog1.FileName, richTextBox1.Text);
            }
            checkActiveCtl();
        }

        private void btnEncodeFromFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog1.Title = "Select File for Base64 Encryption";
            openFileDialog1.Filter = "Ico files (*.ico)|*.ico|Text files (*.txt)|*.txt|Tous les fichiers (*.*)|*.*";
            openFileDialog1.FilterIndex = 3;
            openFileDialog1.Multiselect = false;
            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                fn = openFileDialog1.FileName;

                if (backgroundWorker1.IsBusy != true)
                {
                    backgroundWorker1.RunWorkerAsync();
                }
            }
            if (string.IsNullOrEmpty(richTextBox1.Text))
            {
                this.Text = myUtil.StrTitle;
            }
            checkActiveCtl();
        }

        private void btnViewImageFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            openFileDialog1.Title = "Select File To View";
            openFileDialog1.Filter = "Ico files (*.ico)|*.ico|Text files (*.txt)|*.txt|Tous les fichiers (*.*)|*.*";
            openFileDialog1.FilterIndex = 3;
            openFileDialog1.Multiselect = false;
            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                // pictureBox1.Image = Base64ToImage(richTextBox1.Text);
                Bitmap image1 = (Bitmap)Image.FromFile(@"" + openFileDialog1.FileName + "", true);

                pictureBox1.Visible = true;
                richTextBox1.Visible = false;

                pictureBox1.Image = image1;
            }
        }

        private void ctxClose_Click(object sender, EventArgs e)
        {
            checkActiveCtl();
        }

        private void ctxUndo_Click(object sender, EventArgs e)
        {
            if (richTextBox1.CanUndo == true)
            {
                richTextBox1.Undo();
                richTextBox1.ClearUndo();
            }
            checkActiveCtl();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Written in C# by François GONENC" + Environment.NewLine + Environment.NewLine +
            "Using Visual Studio 2019 professional. Source Code is inside.";
            checkActiveCtl();
        }

        private void btnEncode_Click(object sender, EventArgs e)
        {
            try
            {
                ((Control)sender).Enabled = false;

                Encoder(); // processing whole text only
            }
            finally
            {
                checkActiveCtl();
                ((Control)sender).Enabled = true;
            }
        }

        private void Encoder()
        {
            // processing whole text
            myUtil.Userentry = richTextBox1.Text;

            if (!string.IsNullOrEmpty(myUtil.Userentry))
            {
                // take data from user copy to var
                myUtil.Userentry = richTextBox1.Text;

                try
                {
                    // copy encoded text to dyn buffer
                    var buffer = Base64Encode(myUtil.Userentry);
                    richTextBox1.Text = buffer;

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message + Environment.NewLine + ex.StackTrace);
                }
            }
            else
            {
                MessageBox.Show("Input Value cannot be empty !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Encoder(String p)
        {
            // processing selected text
            if (!string.IsNullOrEmpty(p))
            {
                // take data from user copy to var
                myUtil.Userentry = p;
                // copy encoded text to dyn buffer
                var buffer = Base64Encode(myUtil.Userentry);
                richTextBox1.Text = buffer;
            }
            else
            {
                MessageBox.Show("Input Value cannot be empty !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkActiveCtl()
        {
            if (pictureBox1.Visible)
            {
                pictureBox1.Visible = false;
                richTextBox1.Visible = true;
            }
        }

        private void btnDecode_Click(object sender, EventArgs e)
        {
            myUtil.Userentry = richTextBox1.Text;
            if (!string.IsNullOrEmpty(myUtil.Userentry))
            {
                var buffer = Base64Decode(myUtil.Userentry);
                richTextBox1.Text = buffer.ToString();
            }
            else
            {
                MessageBox.Show("Cannot be empty !");
            }
            checkActiveCtl();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            float fsize = richTextBox1.Font.Size;
            richTextBox1.Text = Properties.Resources.String1;

            checkActiveCtl();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(richTextBox1.Text))
            {
                this.Text = myUtil.StrTitle + " - " + richTextBox1.Text.Length.ToString("N00") + " Chars.";
            }
            else
            {
                this.Text = myUtil.StrTitle;
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            for (int filecnt = 1; (filecnt <= 1); filecnt++)
            {
                if ((worker.CancellationPending == true))
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    // Perform a time consuming operation and report progress.
                    // safe thr
                    Thread th = new Thread(new ThreadStart(this.ThreadProcSafe));
                    th.Start();

                    //System.Threading.Thread.Sleep(500);

                    worker.ReportProgress((filecnt * 100));
                }
            }
        }

        private void ThreadProcSafe()
        {
            SetText(FileToBase64(@"" + fn + "").ToString());
            //NOT! richTextBox1.Text = FileToBase64(@"" + fn + "").ToString();
        }



        private void SetText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            // See. Microsoft's dot net site
            if (richTextBox1.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.richTextBox1.Text = text;
            }
        }


        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.label1.Text = (e.ProgressPercentage.ToString() + "%");
            //this.progressBar1.Value = (e.ProgressPercentage);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if ((e.Cancelled == true))
            {
                this.label1.Text = "Canceled!";
            }

            else if (!(e.Error == null))
            {
                this.label1.Text = ("Error: " + e.Error.Message);
            }

            else
            {
                this.label1.Text = "Done. " + fn + " " + Application.ProductName + " " + Application.ProductVersion + " " +
                    Base64Decode("RW1haWw6IGZyYW5jb2lzLmdvbmVuY0BnbWFpbC5jb20=");
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Cancelled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "Base64 Converter, C# Source code included.";
        }

    }

    public sealed class ClassUtility
    {
        string _userentry; // user data to encode
        string _strTitle;  // form title

        public string StrTitle
        {
            get { return _strTitle; }
            set { _strTitle = value; }
        }

        public string Userentry
        {
            get { return _userentry; }
            set { _userentry = value; }
        }

    }

}
