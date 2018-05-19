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
    public partial class Exercicio01 : Form
    {
        /* 1. Solicite para o usuário um número e informe se este número é positivo ou não.
              Obs: ​Lembrando que zero não é considerado um número positivo. */
        public Exercicio01()
        {
            InitializeComponent();
        }

        int numero = 0;
      
        private void btChecar_Click(object sender, EventArgs e)
        {
            try
            {
                numero = Convert.ToInt32(txtNumero.Text);
            }
            catch
            {
                MessageBox.Show("Número deve conter somente números inteiros !");
                txtNumero.Focus();
                return;
            }

            if (numero > 0)
            {
                MessageBox.Show("Positivo !");

            }
            else
            {
                MessageBox.Show("Não é positivo !");

            }
          
        }
 
    }
}
