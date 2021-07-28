using System;
using System.Drawing;
using System.Windows.Forms;

namespace Пипетка
{
    public partial class FormInformation : Form
    {
        public FormInformation()
        {
            InitializeComponent();
        }

        public Color SelectPixel { get; set; }

        private void FormInformation_Load(object sender, EventArgs e)
        {
            PnlColorShow.BackColor = SelectPixel;
            TbxName.Text = string.Format("#{0:X2}{1:X2}{2:X2}", SelectPixel.R, SelectPixel.G, SelectPixel.B);
            TbxRgb.Text = SelectPixel.R + "," + SelectPixel.G + "," + SelectPixel.B;
        }
    }
}
