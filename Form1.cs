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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string num;
        string numeropedido;
        string data = DateTime.Now.ToString(System.Globalization.CultureInfo.CreateSpecificCulture("fr-FR"));

        int combo1, combo2, combo3, combo4, combo5;
        
        double valorTotal;
        readonly double combo1Preco = 33.90;
        readonly double combo2Preco = 31.90;
        readonly double combo3Preco = 30.90;
        readonly double combo4Preco = 35.90;
        readonly double combo5Preco = 20.90;

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtDireita.Clear();
            textBox1.Clear();
            lblNomeCombo.Text = "";
            pbImagem.Image = Properties.Resources.logotipo2;
        }

        private void TRUE(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            Random numeros = new Random();
            int numerosrandom;
            string novopedido;
            DataTable dt = new DataTable();
            string consultaSQL;

           
                do
                {
                    
                    numerosrandom = numeros.Next(1000, 3000);
                    novopedido = numerosrandom.ToString();
                    novopedido = "P" + novopedido;
                    consultaSQL = "SELECT idCombo FROM cardapio WHERE idCombo='" + novopedido + "'";
                    dt = BancoDados.Consulta(consultaSQL);
                    textBox1.Text = novopedido;

                } while (dt.Rows.Count > 0);

            numeropedido = novopedido;


            }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {

            valorTotal = (combo1 * combo1Preco) + (combo2 * combo2Preco) + (combo3 * combo3Preco) + (combo4 * combo4Preco) + (combo5 * combo5Preco);
            Pedido novoPedido = new Pedido(numeropedido, combo1, combo2, combo3, combo4, combo5, valorTotal, data);
            BancoDados.insertPedido(novoPedido);

            string pedido = "SELECT idPedido FROM pedido WHERE idpedido = '" + numeropedido + "'";
            DataTable dt = BancoDados.Consulta(pedido);

            if(dt.Rows.Count != 0)
            {

                var resultado = new Form2(numeropedido, combo1, combo2, combo3, combo4, combo5, valorTotal);
                resultado.ShowDialog();
                textBox1.Clear();
                combo1 = 0;
                combo2 = 0; 
                combo3 = 0;
                combo4 = 0;
                combo5 = 0;

            }
           


        }

        private void button10_Click(object sender, EventArgs e)        {
                       
            Form3 janela = new Form3();
            janela.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int i = 0;
            string cardapio = "SELECT idCombo AS 'COD', nomeCombo AS 'NOME DO COMBO', valorCombo AS 'VALOR' FROM cardapio;";

            dataGridView1.DataSource = BancoDados.Consulta(cardapio);
            dataGridView1.Columns[0].Width = 70;
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].Width = 78;

            dataGridView1.Sort(dataGridView1.Columns[i], ListSortDirection.Ascending);
        }

       

        private void btNumero(object sender, EventArgs e)

        {

            Button bt = (Button)sender;
            txtDireita.Text = txtDireita.Text + bt.Text;

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {

            if(textBox1.Text == "")
            {
                MessageBox.Show("Clicar em Iniciar Pedido para começar");
                txtDireita.Clear();
                lblNomeCombo.ResetText();
                pbImagem.Image = Properties.Resources.logotipo2;
            }


            {
                if (num == "1")
                {
                    combo1 += 1;
                    txtDireita.Clear();
                    lblNomeCombo.ResetText();
                    pbImagem.Image = Properties.Resources.combo1;
                    MessageBox.Show("COMBO 1 ADICIONADO AO SEU PEDIDO");
                }
                else if (num == "2")
                {
                    combo2 += 1;
                    txtDireita.Clear();
                    lblNomeCombo.ResetText();
                    pbImagem.Image = Properties.Resources.combo2;
                    MessageBox.Show("COMBO 2 ADICIONADO AO SEU PEDIDO");
                }
                else if (num == "3")
                {
                    combo3 += 1;
                    txtDireita.Clear();
                    lblNomeCombo.ResetText();
                    pbImagem.Image = Properties.Resources.combo3T;
                    MessageBox.Show("COMBO 3 ADICIONADO AO SEU PEDIDO");
                }

                else if (num == "4")
                {
                    combo4 += 1;
                    txtDireita.Clear();
                    lblNomeCombo.ResetText();
                    pbImagem.Image = Properties.Resources.combo4T;
                    MessageBox.Show("COMBO 4 ADICIONADO AO SEU PEDIDO");
                }
                else if (num == "5")
                {
                    combo5 += 1;
                    txtDireita.Clear();
                    lblNomeCombo.ResetText();
                    pbImagem.Image = Properties.Resources.combo5T;
                    MessageBox.Show("COMBO 1 ADICIONADO AO SEU PEDIDO");
                }
                             

             
            }
        }


        private void txtDireita_TextChanged(object sender, EventArgs e)
        {
            num = txtDireita.Text;

            if (num == "1")
            {
               pbImagem.Image = Properties.Resources.combo1;
                lblNomeCombo.Text = "Combo Fake Picanha - R$ 33,90";

            }

            else if (num == "2")
            {
                pbImagem.Image = Properties.Resources.combo2;
                lblNomeCombo.Text = "Combo Big Wac - R$ 31,90";
            }

            else if (num == "3")
            {
                pbImagem.Image = Properties.Resources.combo3T;
                lblNomeCombo.Text = "Combo Cheese Wac - R$ 30,90";

            }

            else if (num == "4")
            {
                pbImagem.Image = Properties.Resources.combo4T;
                lblNomeCombo.Text = "Combo Big Big Wac - R$ 35,90";

            }

            else if (num == "5")
            {
                pbImagem.Image = Properties.Resources.combo5T;
                lblNomeCombo.Text = "Combo Wac Felicidade - R$ 20,90";

            }

            else if (num != "1" && num != "2" && num != "3" && num != "4" && num != "5" && num != "")
            {
                pbImagem.Image = Properties.Resources.logotipo2;
                MessageBox.Show("Produto inexistente no Menu ");
                
                txtDireita.Clear();
              
            }

        }
    }
}
