using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace laba_1
{
    public partial class Form2 : Form
    {
        Color source_color, result_color, cur_color;
        public Form2(Image pic)
        {
            InitializeComponent();
            pictureBox1.Image = pic;
            pictureBox1.Refresh();
        }
        public Color getSourceColor() { return source_color; }
        public Color getResultColor() { return result_color; }
        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = cur_color;
            source_color = cur_color;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = cur_color;
            result_color = cur_color;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            using (var bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height))
            {
                pictureBox1.DrawToBitmap(bmp, pictureBox1.ClientRectangle);
                Color color = bmp.GetPixel(e.X, e.Y);
                int red = color.R;
                int green = color.G;
                int blue = color.B;
                pictureBox2.BackColor = Color.FromArgb(red, green, blue);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                result_color = colorDialog1.Color;
                button2.BackColor = result_color;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                source_color = colorDialog1.Color;
                button1.BackColor = source_color;
            }
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            using (var bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height))
            {
                pictureBox1.DrawToBitmap(bmp, pictureBox1.ClientRectangle);
                Color color = bmp.GetPixel(e.X, e.Y);
                int red = color.R;
                int green = color.G;
                int blue = color.B;
                cur_color = Color.FromArgb(red, green, blue);
                pictureBox3.BackColor = cur_color;
            }
        }

    }
}
