using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atividade04
{
    public partial class Form1: Form
    {
        private List<Image> imagensNivel;
        private int indiceAtualNivel = 0;

        public Form1()
        {
            InitializeComponent();

            imagensNivel = new List<Image>
            {
                Image.FromFile("c:\\imagens\\Dig_1.bmp"),
                Image.FromFile("c:\\imagens\\Dig_2.bmp"),
                Image.FromFile("c:\\imagens\\Dig_3.bmp"),
                Image.FromFile("c:\\imagens\\Dig_4.bmp"),
                Image.FromFile("c:\\imagens\\Dig_5.bmp"),
                Image.FromFile("c:\\imagens\\Dig_6.bmp"),
                Image.FromFile("c:\\imagens\\Dig_7.bmp"),
                Image.FromFile("c:\\imagens\\Dig_8.bmp"),
                Image.FromFile("c:\\imagens\\Dig_9.bmp"),
            };
        }

        // botao sair
        private void button1_Click(object sender, EventArgs e)
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToShortDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Process.Start("calc");
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Process.Start("notepad");
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("c:\\imagens\\tanqueOff.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.Image = Image.FromFile("c:\\imagens\\mascara.bmp");
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.Image = Image.FromFile("c:\\imagens\\cortezLogo.png");
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        
        //botao ligar
        private void button2_Click(object sender, EventArgs e)
        {
            timer2.Start();
            button2.Enabled = false;
            pictureBox1.Image = Image.FromFile("c:\\imagens\\tanqueOn.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            indiceAtualNivel = (indiceAtualNivel + 1) % imagensNivel.Count;
            pictureBox2.Image = imagensNivel[indiceAtualNivel];

            if (indiceAtualNivel == 8)
            {
                pictureBox3.Visible = true;
                pictureBox3.Image = Image.FromFile("c:\\imagens\\verde.png");
                pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                pictureBox3.Visible = false;
            }

            if (indiceAtualNivel == 0)
            {
                pictureBox4.Visible = true;
                pictureBox4.Image = Image.FromFile("c:\\imagens\\vermelho.png");
                pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                pictureBox4.Visible = false;
            }
        }

        //botao emergencia
        private void button3_Click(object sender, EventArgs e)
        {
            timer2.Stop();           
            button2.Enabled = true;  
        }

        //botao desligar
        private void button4_Click(object sender, EventArgs e)
        {
            timer2.Stop(); 

            indiceAtualNivel = 0;

            pictureBox1.Image = Image.FromFile("c:\\imagens\\tanqueOff.jpg");
            pictureBox2.Image = Image.FromFile("c:\\imagens\\Dig_0.bmp");

            button2.Enabled = true; 
        }
    }
}
