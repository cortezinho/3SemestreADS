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
        private List<Image> imagensTanque;
        private List<Image> imagensNivel;
        private int indiceAtualTanque = 0;
        private int indiceAtualNivel = 0;

        public Form1()
        {
            InitializeComponent();

            imagensTanque = new List<Image>
            {
                Image.FromFile("c:\\imagens\\tanque_umQuinto.png"),
                Image.FromFile("c:\\imagens\\tanque_doisQuintos.png"),
                Image.FromFile("c:\\imagens\\tanque_tresQuintos.png"),
                Image.FromFile("c:\\imagens\\tanque_quatroQuintos.png"),
                Image.FromFile("c:\\imagens\\tanque_cheio.png")
            };

            imagensNivel = new List<Image>
            {
                Image.FromFile("c:\\imagens\\Dig_1.bmp"),
                Image.FromFile("c:\\imagens\\Dig_2.bmp"),
                Image.FromFile("c:\\imagens\\Dig_3.bmp"),
                Image.FromFile("c:\\imagens\\Dig_4.bmp"),
                Image.FromFile("c:\\imagens\\Dig_5.bmp")
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
            pictureBox1.Image = Image.FromFile("c:\\imagens\\tanque_vazio.png");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.Image = Image.FromFile("c:\\imagens\\Dig_0.bmp");
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        
        //botao ligar
        private void button2_Click(object sender, EventArgs e)
        {
            timer2.Start();
            button2.Enabled = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            indiceAtualTanque = (indiceAtualTanque + 1) % imagensTanque.Count;
            pictureBox1.Image = imagensTanque[indiceAtualTanque];

            indiceAtualNivel = (indiceAtualNivel + 1) % imagensNivel.Count;
            pictureBox2.Image = imagensNivel[indiceAtualNivel];
        }

        //botao emergencia
        private void button3_Click(object sender, EventArgs e)
        {
            timer2.Stop();           
            button2.Enabled = true;  
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer2.Stop(); 

            
            indiceAtualTanque = 0;
            indiceAtualNivel = 0;

            
            pictureBox1.Image = imagensTanque[indiceAtualTanque];
            pictureBox2.Image = imagensNivel[indiceAtualNivel];

            button2.Enabled = true; 
        }
    }
}
