using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaEstruturaCondicionalWFA
{
    public partial class Exercicio03 : Form
    {
        public Exercicio03()
        {
            InitializeComponent();
        }

        double numero01 = 0, numero02 = 0;
        int opcaoDesejada = 0;
        private void btnProcessar_Click(object sender, EventArgs e)
        {
            ArmazenarNumero();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("1\t\tSomas");
            sb.AppendLine("2\t\tSubtrair");
            sb.AppendLine("3\t\tMultiplicar");
            sb.AppendLine("4\t\tDividir");
            txtMenu.Text = sb.ToString();

        }

        private void btnChecar_Click(object sender, EventArgs e)
        {
            ArmazenarNumero();
            OpcaoDesejada();
            if (opcaoDesejada == 1)
            {
                SomarDosNumeros();
            }
            else if (opcaoDesejada == 2)
            {
                SubtracaoDosNumeros();
            }
            else if (opcaoDesejada == 3)
            {
                MultiplicacaoDosNumeros();
            }
            else if (opcaoDesejada == 4)
            {
                DivisaoDosNumeros();
            }
            else
            {
                MessageBox.Show("Por favor escolha uma das opções acima !");
                txtOpcaoDesejada.Focus();
                return;
            }

            
        }

        private void ArmazenarNumero()
        {
           
            try
            {
                numero01 = Convert.ToDouble(txtNumero01.Text);
                if(numero01 == 0)
                {
                    MessageBox.Show("Número 1 deve ser maior que 0 !");
                    txtNumero01.Focus();
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Número 1 deve conter apenas números reias !");
                txtNumero01.Focus();
                return;
            }

            try
            {                
                numero02 = Convert.ToDouble(txtNumero02.Text);
                if (numero02 == 0)
                {
                    MessageBox.Show("Número 2 deve ser maior que 0 !");
                    txtNumero02.Focus();
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Número 2 deve conter apenas números inteiros !");
                txtNumero02.Focus();
                return;
            }           
        }

        private void OpcaoDesejada()
        {
            try
            {
                opcaoDesejada = Convert.ToInt32(txtOpcaoDesejada.Text);
                if (opcaoDesejada < 1 && opcaoDesejada < 4)
                {
                    MessageBox.Show("Opção desejada deve corresponder as opções do menu !");
                    txtOpcaoDesejada.Focus();
                    return;
                }

            }
            catch
            {
                MessageBox.Show("Opção desejada deve conter apenas números inteiros !");
                txtOpcaoDesejada.Focus();
                return;
            }
        }

        public void SomarDosNumeros()
        {
            double soma = numero01 + numero02;
            MessageBox.Show("A soma dos números é: " + soma);
        }

        public void SubtracaoDosNumeros()
        {
            double subtracao = numero01 - numero02;
            MessageBox.Show("A subtração dos números é: " + subtracao);
        }

        public void MultiplicacaoDosNumeros()
        {
            double multiplicação = numero01 * numero02;
            MessageBox.Show(String.Format("A multiplicação dos números é: {0} ", multiplicação));
        }

        public void DivisaoDosNumeros()
        {
            double divisao = numero01 / numero02;
            MessageBox.Show("A divisão dos números é: " + divisao);
        }
    }
}
