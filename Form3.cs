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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            int i = 0;

            string selectconsulta = @"SELECT idPedido AS 'NUM PEDIDO',
                                             combo1 AS 'COMBO 1',
                                             combo2 AS 'COMBO 2',
                                             combo3 AS 'COMBO 3',
                                             combo4 AS 'COMBO 4',
                                             combo5 AS 'COMBO 5',
                                             valorTotal AS 'VALOR TOTAL',
                                             dataPedido AS 'DATA/HORA'
                                             FROM pedido ORDER BY dataPedido ASC;";

            dgv_VendasRealizadas.DataSource = BancoDados.Consulta(selectconsulta);
            dgv_VendasRealizadas.Columns[0].Width = 105;
            dgv_VendasRealizadas.Columns[1].Width = 87;
            dgv_VendasRealizadas.Columns[2].Width = 87;
            dgv_VendasRealizadas.Columns[3].Width = 87;
            dgv_VendasRealizadas.Columns[4].Width = 87;
            dgv_VendasRealizadas.Columns[5].Width = 87;
            dgv_VendasRealizadas.Columns[6].Width = 75;
            dgv_VendasRealizadas.Columns[7].Width = 150;


            dgv_VendasRealizadas.Sort(dgv_VendasRealizadas.Columns[i], ListSortDirection.Descending);
        }

    }
}
