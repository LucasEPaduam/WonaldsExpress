using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WonaldsExpress
{
    public class Pedido
    {

        public string novoPedido;
        public int combo1;
        public int combo2;
        public int combo3;
        public int combo4;
        public int combo5;
        public double valorTotal;
        public string data;
       
        public Pedido(string novoPedido, int combo1, int combo2, int combo3, int combo4, int combo5, double valorTotal, string data)
        {
            this.combo1 = combo1;
            this.combo2 = combo2;
            this.combo3 = combo3;
            this.combo4 = combo4;
            this.combo5 = combo5;
            this.novoPedido = novoPedido;
            this.data = data;
            this.valorTotal = valorTotal;

        }


        public int getCombo1()
        {
            return combo1;
        }

        public void setCombo1(int combo1)
        {
            this.combo1 = combo1;
        }

        public int getCombo2()
        {
            return combo2;
        }

        public void setCombo2(int combo2)
        {
            this.combo2 = combo2;
        }

        public int getCombo3()
        {
            return combo3;
        }

        public void setCombo3(int combo3)
        {
            this.combo3 = combo3;
        }

        public int getCombo4()
        {
            return combo4;
        }

        public void setCombo4(int combo4)
        {
            this.combo4 = combo4;
        }

        public int getCombo5()
        {
            return combo5;
        }

        public void setCombo5(int combo5)
        {
            this.combo5 = combo5;
        }

        public String getNovoPedido()
        {
            return novoPedido;
        }

        public void setNovoPedido(String novoPedido)
        {
            this.novoPedido = novoPedido;
        }

        public String getData()
        {
            return data;
        }

        public void setData(String data)
        {
            this.data = data;
        }

        public double getValorTotal()
        {
            return valorTotal;
        }

        public void setvalorTotal(double valorTotal)
        {
            this.valorTotal = valorTotal;
        }



    }
}

