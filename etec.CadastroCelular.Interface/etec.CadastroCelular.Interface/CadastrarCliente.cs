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
    public partial class CadastrarCliente : Form
    {
        public CadastrarCliente()
        {
            InitializeComponent();
        }

        private void btnCadCli_Click(object sender, EventArgs e)
        {
            // VALIDAÇÃO

            if (txbNome.Text == "" || txbCpf.Text == "" || txbRg.Text == "" || txbCelular.Text == "" || txbTelefone.Text == "" || txbEndereco.Text == "")
            {
                MessageBox.Show("Todos os campos devem ser preenchidos", "Empresa de Celulares");
            }
            else
            {
                // Salvar informações no banco

                // iniciando a conexao
                string conexao = "Persist Security Info=False;User ID=sa;Initial Catalog=CadastroCelular;Data Source=LAB-08-05;password=info211";

                SqlConnection conexaoBanco = new SqlConnection(conexao);

                conexaoBanco.Open();

                string comandoSQl = "INSERT INTO Cliente VALUES ('" + txbNome.Text + "','" + txbCpf.Text + "','" + txbRg.Text + "','" + txbCelular.Text + "','" + txbTelefone.Text + "','" + txbEndereco.Text + "')";
                //('" + txtNome.Text + "', '" + txtCargo.Text + "', '" + txtSalario.Text + "', '" + txtRg.Text + "', '" + txtCPF.Text + "', '" + txtTelefone.Text + "', '" + txtData.Text + "')";

                SqlCommand execucaoSQl = new SqlCommand(comandoSQl, conexaoBanco);
                execucaoSQl.ExecuteNonQuery();

                conexaoBanco.Close();

                // fechando a conexao

                MessageBox.Show("Cadastro realizado", "Empresa de Celulares");
                LimparCampos();
            }
        }
        private void LimparCampos()
        {
            txbNome.Text = "";
            txbCpf.Text = "";
            txbRg.Text = "";
            txbCelular.Text = "";
            txbTelefone.Text = "";
            txbEndereco.Text = "";

        }

    }
}
