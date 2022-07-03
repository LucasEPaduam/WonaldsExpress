using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WonaldsExpress
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();

        }



        public Form2(string numeropedido, int combo1, int combo2, int combo3, int combo4, int combo5, double valorTotal)
        {
            InitializeComponent();
            lblPedidoNumero.Text = numeropedido;
            lblC1P.Text = Convert.ToString(combo1);
            lblC2P.Text = Convert.ToString(combo2);
            lblC3P.Text = Convert.ToString(combo3);
            lblC4P.Text = Convert.ToString(combo4);
            lblC5P.Text = Convert.ToString(combo5);
            label3.Text = Convert.ToString(valorTotal);

        }

        private void btnCancelarPedido_Click(object sender, EventArgs e)
        {
            string numeropedido = lblPedidoNumero.Text;
            BancoDados.excluirPedido(numeropedido);
            this.Close();

        }
    }
}
