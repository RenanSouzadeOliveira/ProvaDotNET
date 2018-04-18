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
    public partial class Consultar : Form
    {
        public Consultar()
        {
            InitializeComponent();
        }

        private void Consultar_Load(object sender, EventArgs e)
        {
            // Iniciando Conexao 
            string conexao = "Persist Security Info=False;User ID=sa;Initial Catalog=CadastroCelular;Data Source=LAB-08-05;password=info211";

            SqlConnection conexaoBanco = new SqlConnection(conexao);

            conexaoBanco.Open();

            string comandoSQl = "select c.idCliente as IdCliente, c.nomeCliente as nomeCliente, c.cpfCliente as cpfclientetbCliente, v.cpfCliente as cpfClientetbCelular, v.idCelular as idCelular, v.marca as marcaCelular, v.modelo as modeloCelular from Cliente c left join Celular v on c.cpfCliente = v.cpfCliente";

            // adaptando os dados de SQL para c#

            SqlDataAdapter adaptador = new SqlDataAdapter(comandoSQl, conexaoBanco);
            DataSet datasetClienteCelular = new DataSet();
            adaptador.Fill(datasetClienteCelular);

            dtClienteCelular.DataSource = datasetClienteCelular;

             dtClienteCelular.DataMember = datasetClienteCelular.Tables[0].TableName;


            conexaoBanco.Close();
        }

        private void btnCadClie_Click(object sender, EventArgs e)
        {
            CadastrarCliente telaCadastroCli = new CadastrarCliente();
            telaCadastroCli.Show();
        }

        private void btnCadCelu_Click(object sender, EventArgs e)
        {
            CadastrarCelular telaCadastroCelular = new CadastrarCelular();
            telaCadastroCelular.Show();
        }
    }
}
