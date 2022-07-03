using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace WonaldsExpress

{
    internal class BancoDados
    {

        private MySqlDataAdapter data_adapter;
        private MySqlConnection conexao;

        public static MySqlConnection conexaoBanco()
        {

            string connString = @"server=127.0.0.1;uid=root; database=Wonalds;ConnectionTimeout=2";
            MySqlConnection conexao = new MySqlConnection(connString);
            conexao.Open();
            return conexao;
        }


        public static DataTable Consulta(string consultaSQL)
        {

            MySqlDataAdapter data_adapter = null;
            DataTable data_table = new DataTable();

            try
            {
                using (var cmd = conexaoBanco().CreateCommand())
                {
                    cmd.CommandText = consultaSQL;
                    data_adapter = new MySqlDataAdapter(cmd.CommandText, conexaoBanco());
                    data_adapter.Fill(data_table);
                    return data_table;
                }

            }
            catch (MySqlException erro)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(erro.GetType().ToString());
                sb.AppendLine(erro.Message);
                sb.Append(erro.SqlState);
                sb.AppendLine("\n");
                sb.AppendLine(erro.StackTrace);
                MessageBox.Show(sb.ToString());
                throw erro;

            }
            catch (Exception erro)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(erro.GetType().ToString());
                sb.AppendLine(erro.Message);
                sb.AppendLine("\n");
                sb.AppendLine(erro.StackTrace);
                MessageBox.Show(sb.ToString());
                throw erro;
            }
        }



        public static void insertPedido(Pedido novopedido)
        {

            try
            {
                using (var connect = conexaoBanco())
                using (var cmd = connect.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO pedido (idPedido, combo1, combo2, combo3, " +
                                     "combo4, combo5, valorTotal, dataPedido)" +
                                     "VALUES( @novoPedido, @combo1, @combo2, @combo3, @combo4, @combo5, @valorTotal, @data)";
                    cmd.Parameters.AddWithValue("@novoPedido", novopedido.novoPedido);
                    cmd.Parameters.AddWithValue("@combo1", novopedido.combo1);
                    cmd.Parameters.AddWithValue("@combo2", novopedido.combo2);
                    cmd.Parameters.AddWithValue("@combo3", novopedido.combo3);
                    cmd.Parameters.AddWithValue("@combo4", novopedido.combo4);
                    cmd.Parameters.AddWithValue("@combo5", novopedido.combo5);
                    cmd.Parameters.AddWithValue("@valorTotal", novopedido.valorTotal);
                    cmd.Parameters.AddWithValue("@data", novopedido.data);
                    
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Pedido cadastrado com sucesso!");

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao cadastrar pedido \n" + ex.Message);

            }



        }

        public static void excluirPedido(string novopedido)
        {

            try
            {
                using (var connect = conexaoBanco())
                using (var cmd = connect.CreateCommand())
                {


                    cmd.CommandText = "DELETE FROM pedido WHERE idPedido = @idPedido";                    
                    cmd.Parameters.Add("@idPedido", MySqlDbType.VarChar, 50).Value = novopedido;

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Pedido cancelado com sucesso!");

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao cancelar pedido \n" + ex.Message);

            }



        }    



    }
}