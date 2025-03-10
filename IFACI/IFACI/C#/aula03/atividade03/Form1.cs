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

            pictureBox4.Image = Image.FromFile("C:\\imagens\\Amarelo.bmp");
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;


            pictureBox8.Image = Image.FromFile("C:\\imagens\\Verde.bmp");
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;

            timer2.Enabled = false;
            timer4.Enabled = false;
            timer6.Enabled = false;
            timer7.Enabled = false;
        }

        //timer data e hora
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToShortDateString();
            label4.Text = DateTime.Now.ToLongTimeString();
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

        //timer rua vermelho (2 segundos)
        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
            pictureBox5.Visible = true;
            pictureBox5.Image = Image.FromFile("c:\\imagens\\Verde.bmp");
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            timer4.Enabled = true;
            timer2.Enabled = false;
        }

        //timer rua amarelo (1 segundos)
        private void timer3_Tick(object sender, EventArgs e)
        {
            pictureBox4.Visible = false;
            pictureBox3.Visible = true;
            pictureBox3.Image = Image.FromFile("c:\\imagens\\Vermelho.bmp");
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            timer2.Enabled = true;
            timer3.Enabled = false;

        }

        //timer rua verde (3 segundos)
        private void timer4_Tick(object sender, EventArgs e)
        {
            pictureBox5.Visible = false;
            pictureBox4.Visible = true;
            pictureBox4.Image = Image.FromFile("c:\\imagens\\Amarelo.bmp");
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            timer3.Enabled = true;
            timer4.Enabled = false;
        }

        //timer avenida verde (3 segundos)
        private void timer5_Tick(object sender, EventArgs e)
        {
            pictureBox8.Visible = false;
            pictureBox7.Visible = true;
            pictureBox7.Image = Image.FromFile("c:\\imagens\\Amarelo.bmp");
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            timer6.Enabled = true;
            timer5.Enabled = false;
        }

        //timer avenida amarelo (1 segundos)
        private void timer6_Tick(object sender, EventArgs e)
        {
            pictureBox7.Visible = false;
            pictureBox6.Visible = true;
            pictureBox6.Image = Image.FromFile("c:\\imagens\\Vermelho.bmp");
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            timer7.Enabled = true;
            timer6.Enabled = false;
        }

        //timer avenida vermelho (2 segundos)
        private void timer7_Tick(object sender, EventArgs e)
        {
            pictureBox6.Visible = false;
            pictureBox8.Visible = true;
            pictureBox8.Image = Image.FromFile("c:\\imagens\\Verde.bmp");
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            timer5.Enabled = true;
            timer7.Enabled = false;
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

        private void label4_Click(object sender, EventArgs e)
        {

        }


    }
}
