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
    public partial class TelaDePanoramaDasMesas : Form
    {
        public TelaDePanoramaDasMesas()
        {
            InitializeComponent();
            buttonFundo.Enabled = false;
        }

        //Esse método vai ao o botão gerenciamento de mesas ser clicado, levar o usuário para a tela de gerenciamento de mesas.
        private void buttonGerenciamentoDasMesas_Click(object sender, EventArgs e)
        {
            new TelaDeGerenciamentoDeMesas().Show();
            this.Visible = false;
        }

        //Esse método vai ao o botão início ser clicado, levar o usuário para a tela de início do atendente.
        private void buttonInicio_Click(object sender, EventArgs e)
        {
            new TelaDeInicioAtendente().Show();
            this.Visible = false;
        }

        //Esse método vai ao o botão mesa 1 ser clicado, levar o usuário para a tela de situação de mesas, com informações correspondentes ao número da mesa.
        private void buttonMesa1_Click(object sender, EventArgs e)
        {
            string mesa = "1";
            Situação_da_Mesa Inf = new Situação_da_Mesa(mesa);
            Inf.Show();
            this.Visible = false;
        }

        //Esse método vai ao o botão mesa 2 ser clicado, levar o usuário para a tela de situação de mesas, com informações correspondentes ao número da mesa.
        private void buttonMesa2_Click(object sender, EventArgs e)
        {
            string mesa = "2";
            Situação_da_Mesa Inf = new Situação_da_Mesa(mesa);
            Inf.Show();
            this.Visible = false;
        }

        //Esse método vai ao o botão mesa 3 ser clicado, levar o usuário para a tela de situação de mesas, com informações correspondentes ao número da mesa.
        private void buttonMesa3_Click(object sender, EventArgs e)
        {
            string mesa = "3";
            Situação_da_Mesa Inf = new Situação_da_Mesa(mesa);
            Inf.Show();
            this.Visible = false;
        }

        //Esse método vai ao o botão mesa 4 ser clicado, levar o usuário para a tela de situação de mesas, com informações correspondentes ao número da mesa.
        private void buttonMesa4_Click(object sender, EventArgs e)
        {
            string mesa = "4";
            Situação_da_Mesa Inf = new Situação_da_Mesa(mesa);
            Inf.Show();
            this.Visible = false;
        }

        //Esse método vai ao o botão mesa 5 ser clicado, levar o usuário para a tela de situação de mesas, com informações correspondentes ao número da mesa.
        private void buttonMesa5_Click(object sender, EventArgs e)
        {
            string mesa = "5";
            Situação_da_Mesa Inf = new Situação_da_Mesa(mesa);
            Inf.Show();
            this.Visible = false;
        }

        //Esse método vai ao o botão mesa 6 ser clicado, levar o usuário para a tela de situação de mesas, com informações correspondentes ao número da mesa.
        private void buttonMesa6_Click(object sender, EventArgs e)
        {
            string mesa = "6";
            Situação_da_Mesa Inf = new Situação_da_Mesa(mesa);
            Inf.Show();
            this.Visible = false;
        }

        //Esse método vai ao o botão mesa 7 ser clicado, levar o usuário para a tela de situação de mesas, com informações correspondentes ao número da mesa.
        private void buttonMesa7_Click(object sender, EventArgs e)
        {
            string mesa = "7";
            Situação_da_Mesa Inf = new Situação_da_Mesa(mesa);
            Inf.Show();
            this.Visible = false;
        }

        //Esse método vai ao o botão mesa 8 ser clicado, levar o usuário para a tela de situação de mesas, com informações correspondentes ao número da mesa.
        private void buttonMesa8_Click(object sender, EventArgs e)
        {
            string mesa = "8";
            Situação_da_Mesa Inf = new Situação_da_Mesa(mesa);
            Inf.Show();
            this.Visible = false;
        }

        //Esse método vai ao o botão mesa 9 ser clicado, levar o usuário para a tela de situação de mesas, com informações correspondentes ao número da mesa.
        private void buttonMesa9_Click(object sender, EventArgs e)
        {
            string mesa = "9";
            Situação_da_Mesa Inf = new Situação_da_Mesa(mesa);
            Inf.Show();
            this.Visible = false;
        }

        //Esse método vai ao o botão mesa 10 ser clicado, levar o usuário para a tela de situação de mesas, com informações correspondentes ao número da mesa.
        private void buttonMesa10_Click(object sender, EventArgs e)
        {
            string mesa = "10";
            Situação_da_Mesa Inf = new Situação_da_Mesa(mesa);
            Inf.Show();
            this.Visible = false;
        }

        //Esse método vai ao o botão mesa 11 ser clicado, levar o usuário para a tela de situação de mesas, com informações correspondentes ao número da mesa.
        private void buttonMesa11_Click(object sender, EventArgs e)
        {
            string mesa = "11";
            Situação_da_Mesa Inf = new Situação_da_Mesa(mesa);
            Inf.Show();
            this.Visible = false;
        }

        //Esse método vai ao o botão mesa 12 ser clicado, levar o usuário para a tela de situação de mesas, com informações correspondentes ao número da mesa.
        private void buttonMesa12_Click(object sender, EventArgs e)
        {
            string mesa = "12";
            Situação_da_Mesa Inf = new Situação_da_Mesa(mesa);
            Inf.Show();
            this.Visible = false;
        }
    }
}