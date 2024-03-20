using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba_1
{

    public partial class Morphology_kernel : Form
    {
        decimal old_value;
        bool[,] matrix;
        KernelButton[,] buttons;
        public Morphology_kernel()
        {
            int N = 3;
            buttons = new KernelButton[N, N];
            matrix = new bool[N, N];
            for (int j = 0; j < N; j++)
            {
                for (int i = 0; i < N; i++)
                {
                    matrix[i, j] = true;
                }
            }

            InitializeComponent();
            pictureBox1.Visible = false;
            old_value = numericUpDown1.Value;
            createButtons(N);

        }

        void KernelButtonClickFunction(object sender, EventArgs e)
        {
            if (sender is KernelButton)
            {
                KernelButton cur_button = (KernelButton)sender;
                int X = cur_button.X_index;
                int Y = cur_button.Y_index;
                matrix[X, Y] = !matrix[X, Y];
                if (matrix[X, Y])
                {
                    cur_button.Text = "1";
                    cur_button.BackColor = Color.White;
                }
                else
                {
                    cur_button.Text = "0";
                    cur_button.BackColor = Color.Gray;
                }
                cur_button.Refresh();
            }
        }
        public bool[,] getMatrix() { return matrix; }


        //слишком большой метод
        private void createButtons(int size)
        {
            matrix = new bool[size, size];
            for (int j = 0; j < size; j++)
            {
                for (int i = 0; i < size; i++)
                {
                    matrix[i, j] = true;
                }
            }

            foreach (var button in buttons)
            {
                if (!(button is null))
                    this.Controls.Remove(button);
            }
            buttons = new KernelButton[size, size];

            var window_size = pictureBox1.Size;
            var window_location = pictureBox1.Location;
            int[] button_size = new int[] { window_size.Width / size, window_size.Height / size };


            for (int j = 0; j < size; j++)
            {
                for (int i = 0; i < size; i++)
                {
                    buttons[i, j] = new KernelButton(i, j);
                    int cur_x, cur_y;
                    cur_x = window_location.X + i * button_size[0];
                    cur_y = window_location.Y + j * button_size[1];
                    buttons[i, j].Location = new Point(cur_x, cur_y);
                }
            }

            foreach (var button in buttons)
            {
                button.Size = new Size(button_size[0], button_size[1]);
                button.Text = "1";
                button.Click += new EventHandler(this.KernelButtonClickFunction);
                this.Controls.Add(button);
            }

        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            decimal new_value = numericUpDown1.Value;
            if (old_value < new_value && old_value < 15)
            {
                old_value += 2;
            }
            else if (old_value > new_value && old_value > 1)
            {
                old_value -= 2;
            }
            numericUpDown1.Value = old_value;
            numericUpDown1.Refresh();
            if (new_value > 1 && new_value < 15)
                createButtons((int)old_value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }

    public class KernelButton : Button
    {
        public int X_index, Y_index;

        public KernelButton(int x, int y) : base()
        {
            X_index = x;
            Y_index = y;
        }
    }
}