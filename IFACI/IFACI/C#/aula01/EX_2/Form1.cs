﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        //Botão Executar
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult bc;
            MessageBoxButtons bot = MessageBoxButtons.OKCancel;
            MessageBoxIcon icon = MessageBoxIcon.Asterisk;
            MessageBoxDefaultButton bd = MessageBoxDefaultButton.Button1;
            bc = MessageBox.Show("Message\nBox","Infomação",bot,icon,bd);

            switch (bc) {
                case DialogResult.OK:
                    textBox1.Text = "OK";
                    break;
                    case DialogResult.Cancel:
                    textBox1.Text = "Cancelar";
                    break;
            }
        }

        //Botão Sair
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
