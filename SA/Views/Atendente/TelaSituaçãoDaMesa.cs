using SA.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace SA.Views
{
    public partial class Situação_da_Mesa : Form
    {
        public Situação_da_Mesa()
        {
            InitializeComponent();
        }
        public Situação_da_Mesa(string id)
        {
            InitializeComponent();
            nmrMesaTXT.Text = id;
            var IdMesa = int.Parse(id);
            carregarInformacoes(IdMesa);
            buttonFundo.Enabled = false;
            btnVoltar.Click += voltar;

            if (statsPedidoTxt.Text == "Esperando Atendente")
            {
                buttonFazerPedido.Visible = true;
            }
            else
            {
                buttonFazerPedido.Visible = false;
            }
            buttonFazerPedido.Click += fazerPedido;
        }

        //Esse método vai ao o botão voltar ser clicado, levar o usuário para a tela de panorama das mesas.
        private void voltar(object sender, EventArgs e)
        {
            new TelaDePanoramaDasMesas().Show();
            this.Visible = false;
        }

        //Esse método vai ao o botão fazer pedido ser clicado, levar o usuário para a tela de cadastramento de pedidos.
        private void fazerPedido(object sender, EventArgs e)
        {
            new TelaDeCadastramentoDePedidos().Show();
            this.Visible = false;
        }

        //Esse método carrega as informações do banco de dados nos devidos labels.
        private void carregarInformacoes(int mesa)
        {
            int ID = mesa;
            using (var context = new churrascariaContext())
            {
                var obsmesa = (from m in context.Mesas
                              where (m.Id == ID) 
                              select m.Observacao).Single();
               observacaoTxt.Text = obsmesa;
            }

            using (var context = new churrascariaContext())
            {
                var sttsmesa = (from m in context.Mesas
                               where (m.Id == ID)
                               select m.Statusmesa).Single();
                statsMesaTxt.Text = sttsmesa;
            }

            using (var context = new churrascariaContext())
            {
                var sttspedido = (from m in context.Mesas
                               where (m.Id == ID)
                               select m.Statuspedido).Single();
                statsPedidoTxt.Text = sttspedido;
            }
        }
    }
}
