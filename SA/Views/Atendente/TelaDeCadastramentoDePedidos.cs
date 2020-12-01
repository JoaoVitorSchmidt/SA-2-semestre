using SA.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SA.Views
{
    public partial class TelaDeCadastramentoDePedidos : Form
    {
        public TelaDeCadastramentoDePedidos()
        {
            InitializeComponent();
            buttonLinha1.Enabled = false;
            buttonFecharPedido.Click += bebidasSelecionadas;
            buttonEspClassico.Click += EspetoClassico;
            buttonEspEspecial.Click += EspetoEspecial;
        }

        private void EspetoEspecial(object sender, EventArgs e)
        {
            Pedidos p = new Pedidos();
            p.Valor = 50;
            p.Itenspedido = "Espeto Corrido Especial";

            Mesas mes = new Mesas();
            mes.Statuspedido = "Já feito";

            using (var context = new churrascariaContext())
            {
            context.Pedidos.Add(p);
            context.Mesas.Add(mes);
            context.SaveChanges();
            }
        }

        private void EspetoClassico(object sender, EventArgs e)
        {
            Pedidos ped = new Pedidos();
            ped.Valor = 35;
            ped.Itenspedido = "Espeto Corrido Clássico";

            Mesas mes = new Mesas();
            mes.Statuspedido = "Já feito";

            using (var context = new churrascariaContext())
            {
            context.Pedidos.Add(ped);
            context.Mesas.Add(mes);
            context.SaveChanges();
            }
        }
        private void bebidasSelecionadas(object sender, EventArgs e)
        {

            foreach (var item in checkedListBoxBebidas.CheckedItems)
            {
                Pedidos bebidas = new Pedidos();
                bebidas.Itenspedido = bebidas.Itenspedido + checkedListBoxBebidas.CheckedItems.ToString() + ", ";

                if (checkedListBoxBebidas.CheckedItems.ToString() == "Água Mineral s/gás | R$ 4,00")
                {
                    bebidas.Valor = bebidas.Valor + 4;
                }

                using (var context = new churrascariaContext())
                {
                    context.Pedidos.Add(bebidas);
                    context.SaveChanges();
                }
            }
        }
    }
}
