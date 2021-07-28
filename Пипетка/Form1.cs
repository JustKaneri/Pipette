using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Пипетка
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        GlobalKeyboardHook gkh = new GlobalKeyboardHook();
        FormImage ImgForm = new FormImage();
        private Bitmap ScreenDisplay { get; set; }
        private FormProperties.KeysForStart conf;

        private void Form1_Load(object sender, EventArgs e)
        {

            if (File.Exists("config.config"))
            {
                BinaryFormatter bf = new BinaryFormatter();

                using (FileStream fs = File.OpenRead("config.config"))
                {
                    conf = (FormProperties.KeysForStart)bf.Deserialize(fs);
                    gkh.HookedKeys.Add(conf.contol);
                }
            }
            else
            {
                gkh.HookedKeys.Add(Keys.F8);
                conf.contol = Keys.F8;

            }

            gkh.KeyUp += new KeyEventHandler(gkh_KeyUp);

            HideForm();
        }

        void gkh_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == conf.contol)
            {
                if (this.WindowState == FormWindowState.Minimized)
                {
                    MadeImage();
                    ShowForm();
                }
            }
           
        }

        private void MadeImage()
        {
            ScreenDisplay = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, PixelFormat.Format32bppArgb);
            Graphics g = Graphics.FromImage(ScreenDisplay);
            g.CopyFromScreen(0, 0, 0, 0, ScreenDisplay.Size);

            this.BackgroundImage = ScreenDisplay;
        }

        private void MadeMiniImage()
        {
            Bitmap bmp = new Bitmap(20, 20);
            Graphics g = Graphics.FromImage(bmp);
            g.CopyFromScreen(Cursor.Position.X - 10, Cursor.Position.Y - 10, 0, 0, ScreenDisplay.Size);

            ImgForm.pictureBox1.Image = bmp;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Escape)
              HideForm();
            
               
        }

        private void HideForm()
        {
            this.WindowState = FormWindowState.Minimized;
            this.Hide();
            this.ShowInTaskbar = false;
            ImgForm.Hide();
        }

        private void ShowForm()
        {
            this.Show();
            this.WindowState = FormWindowState.Maximized;
            this.ShowInTaskbar = true;
            ImgForm.Show();
            this.Focus();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            FormInformation information = new FormInformation();
            information.SelectPixel = (ImgForm.pictureBox1.Image as Bitmap).GetPixel(10, 10);
            information.ShowDialog();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            MadeMiniImage();
            ImgForm.Location = new Point(Cursor.Position.X + 30, Cursor.Position.Y + 30);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnInfo_Click(object sender, EventArgs e)
        {
            FormAboutProgram aboutProgram = new FormAboutProgram();
            aboutProgram.ShowDialog();
        }

        private void BtnPropeties_Click(object sender, EventArgs e)
        {
            FormProperties properties = new FormProperties();
            properties.ShowDialog();

            BinaryFormatter bf = new BinaryFormatter();

            using (FileStream fs = File.OpenRead(properties.FilePropertiesPath))
            {
                conf = (FormProperties.KeysForStart)bf.Deserialize(fs);
                gkh.HookedKeys.Clear();
                gkh.HookedKeys.Add(conf.contol);
                
            }
        }

    }
}
