using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Пипетка
{
    public partial class FormProperties : Form
    {
        public FormProperties()
        {
            InitializeComponent();
            FilePropertiesPath = Environment.CurrentDirectory + "\\config.config";
        }

        [Serializable]
        public struct KeysForStart
        {
            public Keys contol;
        }

        public readonly string FilePropertiesPath;

        private KeysForStart ForStart;

        private void FormProperties_Load(object sender, EventArgs e)
        {
            string nameFile = Application.ExecutablePath;

            using (var reg = Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run"))
            {
                CbxAutoLoad.Checked = reg.GetValue("ColorPip") != null;
            }

            for (int i = 1; i <= 12; i++)
            {
                CbxKeys.Items.Add("F" + i);
            }

            if (File.Exists(FilePropertiesPath))
            {
                BinaryFormatter bf = new BinaryFormatter();

                using (FileStream fs = File.OpenRead(FilePropertiesPath))
                {
                    ForStart = (KeysForStart)bf.Deserialize(fs);
                    CbxKeys.SelectedIndex = int.Parse(ForStart.contol.ToString().Remove(0,1))-1;
                }
            }
            else
            {
                ForStart.contol = Keys.F8;
                CbxKeys.SelectedIndex = 7;
            }
        }

        private void FormProperties_FormClosing(object sender, FormClosingEventArgs e)
        {
            BinaryFormatter bf = new BinaryFormatter();

            if (File.Exists(FilePropertiesPath))
                File.Delete(FilePropertiesPath);

            using (FileStream fs = File.Create(FilePropertiesPath))
            {
                bf.Serialize(fs, ForStart);
            }
        }

        private void CbxKeys_SelectedIndexChanged(object sender, EventArgs e)
        {
            ForStart.contol = (Keys)(new KeysConverter()).ConvertFromString(CbxKeys.Text);
        }

        private void CbxAutoLoad_CheckedChanged(object sender, EventArgs e)
        {
            if (CbxAutoLoad.Checked)
            {
                string nameFile = Application.ExecutablePath;

                using (var reg = Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run"))
                {
                    if (reg.GetValue("ColorPip") == null)
                        reg.SetValue("ColorPip", "\"" + nameFile + "\" ");
                }
            }
            else
            {
                using (var reg = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true))
                {
                    if (reg.GetValue("ColorPip") != null)
                        reg.DeleteValue("ColorPip");
                    
                }
            }
        }
    }
}
