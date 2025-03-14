using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

            timer2.Enabled = false;
            timer3.Enabled = false;
            timer4.Enabled = false;
            timer5.Enabled = false;
            timer6.Enabled = false;
            timer7.Enabled = false;
            timer8.Enabled = false;
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

        //
        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("c:\\imagens\\Amarelo.bmp");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            timer3.Enabled = true;
            timer2.Enabled = false;
        }

        //
        private void timer3_Tick(object sender, EventArgs e)
        {

            pictureBox1.Image = Image.FromFile("c:\\imagens\\Vermelho.bmp");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            timer4.Enabled = true;
            timer3.Enabled = false;

        }

        //
        private void timer4_Tick(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("c:\\imagens\\Verde.bmp");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            timer2.Enabled = true;
            timer4.Enabled = false;
        }



        //
        private void timer5_Tick(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile("c:\\imagens\\Vermelho.bmp");
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            timer6.Enabled = true;
            timer5.Enabled = false;
        }

        //
        private void timer6_Tick(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile("c:\\imagens\\Verde.bmp");
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            timer7.Enabled = true;
            timer6.Enabled = false;
        }

        //
        private void timer7_Tick(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile("c:\\imagens\\Amarelo.bmp");
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            timer5.Enabled = true;
            timer7.Enabled = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        //Botão Liga
        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("c:\\imagens\\Verde.bmp");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox2.Image = Image.FromFile("c:\\imagens\\Vermelho.bmp");
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

            timer2.Enabled = true;
            timer6.Enabled = true;
        }

        //Botão Emergencia
        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("c:\\imagens\\Amarelo.bmp");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox2.Image = Image.FromFile("c:\\imagens\\Amarelo.bmp");
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

            timer2.Enabled = false;
            timer3.Enabled = false;
            timer4.Enabled = false;
            timer5.Enabled = false;
            timer6.Enabled = false;
            timer7.Enabled = false;
            timer8.Enabled = true;

        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("c:\\imagens\\Semaforo.bmp");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox2.Image = Image.FromFile("c:\\imagens\\Semaforo.bmp");
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

            timer8.Enabled = false;
        }

        //Botão Desliga
        private void button3_Click(object sender, EventArgs e)
        {
            //imagem rua
            pictureBox1.Image = Image.FromFile("c:\\imagens\\Semaforo.bmp");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            //imagem avenida
            pictureBox2.Image = Image.FromFile("c:\\imagens\\Semaforo.bmp");
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

            timer2.Enabled = false;
            timer3.Enabled = false;
            timer4.Enabled = false;
            timer5.Enabled = false;
            timer6.Enabled = false;
            timer7.Enabled = false;
            timer8.Enabled = false;
        }

        //Botão Sair
        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult bc;
            MessageBoxButtons bot = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Error;
            MessageBoxDefaultButton bd = MessageBoxDefaultButton.Button1;
            bc = MessageBox.Show("Certeza que\ndeseja sair?", "Infomação", bot, icon, bd);

            switch (bc)
            {
                case DialogResult.Yes:
                    Application.Exit();
                    break;
            }
        }
    }
}
