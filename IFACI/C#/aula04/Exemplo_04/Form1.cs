﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exemplo_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile("c:\\imagens\\Mascara.bmp");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.Image = Image.FromFile("c:\\imagens\\Tanque_de_Mistura_Off2.jpg");
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        //Botão 0
        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("c:\\imagens\\Dig_0.bmp");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        //Botão 1
        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("c:\\imagens\\Dig_1.bmp");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        //Botão 2
        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("c:\\imagens\\Dig_2.bmp");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        //Botão 3
        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("c:\\imagens\\Dig_3.bmp");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        //Botão 4
        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("c:\\imagens\\Dig_4.bmp");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        //Botão 5
        private void button10_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("c:\\imagens\\Dig_5.bmp");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        //Botão 6
        private void button9_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("c:\\imagens\\Dig_6.bmp");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        //Botão 7
        private void button8_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("c:\\imagens\\Dig_7.bmp");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        //Botão 8
        private void button7_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("c:\\imagens\\Dig_8.bmp");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        //Botão 9
        private void button6_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("c:\\imagens\\Dig_9.bmp");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        //Botão LIGA
        private void button11_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile("c:\\imagens\\Tanque_de_Mistura_On2.jpg");
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        //Botão DESLIGA
        private void button12_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile("c:\\imagens\\Tanque_de_Mistura_Off2.jpg");
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
