using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormHelloWorld
{
    public partial class FormHelloWorld : Form
    {
        public FormHelloWorld()
        {
            InitializeComponent();
        }

        private void btnSaudacao_Click(object sender, EventArgs e)
        {
            char letra = '';
            //Declaração + Entrada de Dados
            //cadeia + nomeVariável = leia()
            string nome = tbxSaudacao.Text;
            //inteiro
            int numero01 = Convert.ToInt32(tbxSaudacao.Text); 
            //real
            float numero = 0;
            //Processamento
            //Saída de Dados
            //escreva("") Msg no corpo + Título
            MessageBox.Show($"Olá mundo, seu nome é {nome}", "Saudação");
            lblSaudacao.Text = numero.ToString();
        }
    }
}
