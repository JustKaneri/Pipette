using System.Drawing;
using System.Windows.Forms;

namespace Пипетка
{
    public partial class FormImage : Form
    {
        public FormImage()
        {
            InitializeComponent(); 
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            SolidBrush solidBrush = new SolidBrush(Color.Red);
            g.FillEllipse(solidBrush, new RectangleF(this.Width / 2 - 4 , this.Height / 2 - 4, 5, 5));
        }
    }
}
