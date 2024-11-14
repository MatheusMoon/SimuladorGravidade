using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SimuladorGravitacional
{
    public partial class NewSimForm : Form
    {
        public NewSimForm()
        {
            InitializeComponent();
        }

        private void btnBackMainMenu_Click(object sender, EventArgs e)
        {
            //mostra novamente o Form1 (tela inicial)
            Form1 telaInicial = new Form1();
            telaInicial.Show();

            //fecha a tela atual (NewSimForm)
            this.Close();
        }

        private void tBoxqtdPlanet_KeyPress(object sender, KeyPressEventArgs e)
        {
            //verifica se a tecla pressionada não é um número e não é a tecla de backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                //cancela a entrada da tecla
                e.Handled = true;
            }
        }

        private void tBoxqtdInteractions_KeyPress(object sender, KeyPressEventArgs e)
        {
            //verifica se a tecla pressionada não é um número e não é a tecla de backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                //cancela a entrada da tecla
                e.Handled = true;
            }
        }

        private bool ValidarIntervalo(TextBox textBox, int min, int max)
        {
            //verifica se o campo não ta vazio
            if (string.IsNullOrEmpty(textBox.Text))
            {
                MessageBox.Show($"Por favor, insira um número entre {min} e {max}.");
                textBox.Focus();
                textBox.Clear();
                return false;
            }

            //tenta converter o texto para um numero inteiro
            if (int.TryParse(textBox.Text, out int numero))
            {
                //verifica se o número está fora do intervalo permitido
                if (numero < min || numero > max)
                {
                    MessageBox.Show($"O número deve estar entre {min} e {max}.");
                    textBox.Focus();
                    textBox.Clear(); //limpa o campo para nova entrada
                    return false;
                }
                return true;
            }
            else
            {
                return true;
            }
        }

        private void btnStartSim_Click(object sender, EventArgs e)
        {
            if(
                ValidarIntervalo(tBoxqtdPlanet, 1, 1000) &&
                ValidarIntervalo(tBoxqtdInteractions, 1, 5000))
            {
                SimForm Simular = new SimForm();
                Simular.Show();
                this.Close();
            }
        }
    }
}
