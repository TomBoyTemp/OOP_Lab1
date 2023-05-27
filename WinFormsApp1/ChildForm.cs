using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    
    public partial class ChildForm : Form
    {
        private Bitmap MyImage;
        public ChildForm()
        {
            InitializeComponent();
            if (pictureBox1.Image == null)
            {
                pictureBox1.Image = Properties.Resources.Таблица_1;
                pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            }    
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog open_dialog = new OpenFileDialog(); //создание диалогового окна для выбора файла
            open_dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*"; //формат загружаемого файла
            if (open_dialog.ShowDialog() == DialogResult.OK) //если в окне была нажата кнопка "ОК"
            {
                try
                {
                    MyImage = new Bitmap(open_dialog.FileName);
                    this.pictureBox1.Size = MyImage.Size;
                    pictureBox1.Image = MyImage;
                    pictureBox1.Invalidate();
                }
                catch
                {
                    DialogResult rezult = MessageBox.Show("Невозможно открыть выбранный файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.Image = Properties.Resources.w_brand;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.Image = Properties.Resources.iis;
        }

        private void pictureBox1_SizeChanged(object sender, EventArgs e)
        {
            this.AutoSize = true;
        }
    }
}
    