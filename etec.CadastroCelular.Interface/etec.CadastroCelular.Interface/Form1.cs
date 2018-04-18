using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace etec.CadastroCelular.Interface
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

    

        private void lblCadastrarCli_Click(object sender, EventArgs e)
        {
            CadastrarCliente cad = new CadastrarCliente();

            cad.MdiParent = this;

            cad.Show();
        }

        private void lblCadastrarCel_Click(object sender, EventArgs e)
        {
            CadastrarCelular cadc = new CadastrarCelular();

            cadc.MdiParent = this;

            cadc.Show();
        }

        private void lblConsultar_Click(object sender, EventArgs e)
        {
            Consultar consu = new Consultar();

            consu.MdiParent = this;

            consu.Show();
        }

        private void lblSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja encerrar a aplicação ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
