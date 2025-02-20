using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile("c:\\imagens\\verde.bmp");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Botão LIGA
        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("c:\\imagens\\Vermelho.bmp");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        // Botão DESLIGA
        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("c:\\imagens\\Verde.bmp");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
