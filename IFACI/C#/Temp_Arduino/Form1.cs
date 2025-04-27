using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Drawing.Text;

namespace Temp_Arduino
{
    public partial class Termometro : Form
    {
        public Termometro()
        {
            InitializeComponent(); // INICIALIZA COMPONENTES DO FORMULARIO (FORM)
        }

        private void lerTemperatura(object sender, EventArgs e)
        {
            byte[] dados = new byte[2]; // BUFFER PARA DADOS (NÃO UTILIZADOS)
            string valor; //VARIÁVEL PARA ARMAZENAMENTO DE LEITURA

            valor = serialPort1.ReadExisting(); //LÊ TODOS OS DADOS QUE SERÃO DISPONIBILIZADOS PELA PORTA SERIAL

            if (valor != "") // SE RECEBEU DADOS
            {
                Console.WriteLine(valor);
                thermControl1.UpdateControl(Convert.ToInt32(valor));//ATUALIZA CONTROLE DE TEMPERATURA

                // LIMPA BUFFER DA PORTA SERIAL
                serialPort1.DiscardInBuffer();
                serialPort1.DiscardOutBuffer();
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            this.Invoke(new EventHandler(lerTemperatura)); // CHAMA A FUNÇÃO LER TEMPERATURA NA THREAD DA UI
        }

        private void thermControl1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //BOTÃO INICIAR
        private void btIniciar_Click(object sender, EventArgs e)
        {
            if(txPorta.Text != "") //VERIFICA SE FOI INFORMADA UMA PORTA
            {
                serialPort1.PortName = txPorta.Text; //CONFIGURA A PORTA SERIAL
            }
            if (!serialPort1.IsOpen) { 
                serialPort1.Open(); //ABRE A CONEXÃO SERIAL
            }
        }

        //BOÃO FINALIZAR
        private void btFinalizar_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                serialPort1.Close(); // FECHA A COMUNICAÇÃO SERIAL

                Application.Exit(); //ENCERRA A APLICAÇÃO
            }
        }
    }
}
