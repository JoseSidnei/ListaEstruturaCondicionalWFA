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
    public partial class Exercicio02 : Form
    {
        public Exercicio02()
        {
            InitializeComponent();
        }

        int numero = 0;

        private void rbChecar_Click(object sender, EventArgs e)
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

            if (numero < 0)
            {
                MessageBox.Show("Negativo !");

            }
            else
            {
                MessageBox.Show("Não é negativo !");

            }
        }
    }
}
