using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atividade03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToLongDateString();

            //imagem rua
            pictureBox1.Image = Image.FromFile("c:\\imagens\\Semaforo.bmp");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            //imagem avenida
            pictureBox2.Image = Image.FromFile("c:\\imagens\\Semaforo.bmp");
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox3.Image = Image.FromFile("C:\\imagens\\Vermelho.bmp");
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.Tag = "vermelho";

            pictureBox8.Image = Image.FromFile("C:\\imagens\\Verde.bmp");
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.Tag = "verde";
        }

        //timer data e hora
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.policiamilitar.sp.gov.br/");
        }

        //imagem rua
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        //imagem avenida
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        //timer vermelho (2 segundos)
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (pictureBox3.Tag.ToString() == "vermelho")
            {
                pictureBox3.Visible = false;
                pictureBox4.Visible = true;
                pictureBox4.Image = Image.FromFile("c:\\img\\Amarelo.bmp");
                pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox4.Tag = "amarelo";
            }
        }

        //timer amarelo (1 segundos)
        private void timer3_Tick(object sender, EventArgs e)
        {
            if (pictureBox4.Tag.ToString() == "amarelo")
            {
                pictureBox4.Visible = false;
                pictureBox5.Visible = true;
                pictureBox5.Image = Image.FromFile("c:\\img\\Verde.bmp");
                pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox5.Tag = "verde";
            }
        }

        

        //timer verde (3 segundos)
        private void timer4_Tick(object sender, EventArgs e)
        {
            
        }

        //vermelho rua
        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        //amarelo rua
        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        //verde rua
        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        //vermelho avenida
        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        //amarelo avenida
        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        //verde aveida
        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }
    }
}
