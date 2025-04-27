using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Link
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Botão Bloco de Notas
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Process.Start("notepad");
        }

        //Botão Calculadora
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Process.Start("calc");
        }

        //Botão Navegador
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Process.Start("www.google.com.br");
        }
    }
}
