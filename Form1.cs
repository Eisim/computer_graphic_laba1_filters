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
    public partial class Form1 : Form
    {
        Bitmap image;
        public Form1()
        {
            InitializeComponent();
        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files | *.png; *.jpg; *.bmp | All files (*.*)| *.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                image = new Bitmap(dialog.FileName);
                pictureBox1.Image = image;
                pictureBox1.Refresh();
            }
        }

        private void инверсияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new InvertFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            backgroundWorker1.CancelAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Bitmap newImage = ((Filters)e.Argument).processImage(image, backgroundWorker1);
            if (backgroundWorker1.CancellationPending != true)
                image = newImage;
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                pictureBox1.Image = image;
                pictureBox1.Refresh();
            }
            progressBar1.Value = 0;
        }

        private void размытиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new BlurFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void размытиеПоГауссуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new GaussianFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void grayScaleFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new GrayScaleFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void сепияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new SepiaFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void повышениеЯркостиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new BrightnessFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

 

        private void повышениеРезкостиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new SharpeningFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void коррекцияСОпорнымЦветомToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2(pictureBox1.Image); //где Form2 - название вашей формы
            Color source_color=Color.FromArgb(0,0,0), result_color = Color.FromArgb(255, 255, 255);
            if (frm2.ShowDialog() == DialogResult.OK)
            {
                source_color = frm2.getSourceColor();
                result_color = frm2.getResultColor();
            };
            //label1.Text = 
            //    $"source color:({source_color.R}, {source_color.G}, {source_color.B})\n" +
            //    $"result color:({result_color.R}, {result_color.G}, {result_color.B})";
            Filters filter =new CorrectionWithAReferenceColor(source_color, result_color);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        //сделать  |  проверить
        //сделать  |  проверить
        //сделать  V  проверить
        private void линейноеРастяжениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new LinearStretching();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void эффектСтеклаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new GlassFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }


        private void вертикальныеВолныToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new WaveFilterVertical();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void горизонтальныеВолныToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new WaveFilterHorizontal();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void матричныеToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void oxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new SobelFilterOX();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void осьOyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new SobelFilterOY();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Displays a SaveFileDialog so the user can save the Image
            // assigned to Button2.
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
            saveFileDialog1.Title = "Save an Image File";
            saveFileDialog1.ShowDialog();

            // If the file name is not an empty string open it for saving.
            if (saveFileDialog1.FileName != "")
            {
                // Saves the Image via a FileStream created by the OpenFile method.
                System.IO.FileStream fs =
                    (System.IO.FileStream)saveFileDialog1.OpenFile();
                // Saves the Image in the appropriate ImageFormat based upon the
                // File type selected in the dialog box.
                // NOTE that the FilterIndex property is one-based.
                switch (saveFileDialog1.FilterIndex)
                {
                    case 1:
                        this.pictureBox1.Image.Save(fs,
                          System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;

                    case 2:
                        this.pictureBox1.Image.Save(fs,
                          System.Drawing.Imaging.ImageFormat.Bmp);
                        break;

                    case 3:
                        this.pictureBox1.Image.Save(fs,
                          System.Drawing.Imaging.ImageFormat.Gif);
                        break;
                }

                fs.Close();
            }
        }

        private void осьOxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new SharraFilterOX();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void осьOyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Filters filter = new SharraFilterOY();
            backgroundWorker1.RunWorkerAsync(filter);
        }


        private void обеОбсToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new SharraFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ОО(object sender, EventArgs e)
        {

        }

        private void обеОсиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new SobelFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void размытиеВДвиженииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new MotionBlurFilter(11);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void dilationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Morphology_kernel frm = new Morphology_kernel();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                var kernel = frm.getMatrix();
                Filters filter = new DilationFilter(kernel);
                backgroundWorker1.RunWorkerAsync(filter);
            }
        }

        private void erosionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Morphology_kernel frm = new Morphology_kernel();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                var kernel = frm.getMatrix();
                Filters filter = new ErosionFilter(kernel);
                backgroundWorker1.RunWorkerAsync(filter);
            }
        }

        private void closingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Morphology_kernel frm = new Morphology_kernel();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                var kernel = frm.getMatrix();
                Filters filter = new ClosingFilter(kernel);
                backgroundWorker1.RunWorkerAsync(filter);
            }
        }

        private void openingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Morphology_kernel frm = new Morphology_kernel();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                var kernel = frm.getMatrix();
                Filters filter = new OpeningFilter(kernel);
                backgroundWorker1.RunWorkerAsync(filter);
            }
        }

        private void gradToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Morphology_kernel frm = new Morphology_kernel();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                var kernel = frm.getMatrix();
                Filters filter = new GradFilter(kernel);
                backgroundWorker1.RunWorkerAsync(filter);
            }
        }
    }
}
