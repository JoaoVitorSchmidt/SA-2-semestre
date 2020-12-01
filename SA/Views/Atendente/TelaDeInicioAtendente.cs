using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SA.Views
{
    public partial class TelaDeInicioAtendente : Form
    {
        public TelaDeInicioAtendente()
        {
            InitializeComponent();
        }

        //Esse método vai fazer com que ao o botão cadastro pedido seja clicado, o mesmo leve o usuário até a tela de cadastramento de pedidos.
        private void BtnCadPed_Click(object sender, EventArgs e)
        {
            new TelaDeCadastramentoDePedidos().Show();
            this.Visible = false;
        }

        //Esse método vai fazer com que ao o botão gerenciamento de mesas seja clicado, o mesmo leve o usuário até a tela de gerenciamento de mesas.
        private void BtnGerenMesas_Click(object sender, EventArgs e)
        {
            new TelaDePanoramaDasMesas().Show();
            this.Visible = false;
        }

        //Esse método vai fazer com que ao o botão sign out seja clicado, o mesmo leve o usuário até a tela de login.
        private void BtnSair_Click(object sender, EventArgs e)
        {
            new TelaDeLogin().Show();
            this.Visible = false;
        }
    }
}
