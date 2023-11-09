using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Funcionario_Projeto
{
    public partial class frmProduto : Form
    {
        public frmProduto()
        {
            InitializeComponent();
        }


        void carregarFKvendedor()
        {
            string sql = "select id_vendedor, nome_vendedor from vendedor";

            SqlConnection conn = new SqlConnection(frmFuncionario.conexaosql);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            DataTable tabela = new DataTable();
            conn.Open();

            try
            {
                reader = cmd.ExecuteReader();

                tabela.Load(reader);
                cboidvendedor.DisplayMember = "id_vendedor";
                cboidvendedor.DataSource = tabela;

                cbonomevendedor.DisplayMember = "nome_vendedor";
                cbonomevendedor.DataSource = tabela;


            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro FK  " + ex.ToString());
            }
            finally { conn.Close(); }
        }

        private void testarconexao()
        {
            SqlConnection conn = new SqlConnection(frmFuncionario.conexaosql);

            try
            {
                conn.Open();
                conn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro de conexão");
            }
        }

        private void btosair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmProduto_Load(object sender, EventArgs e)
        {
            testarconexao();
            carregarFKvendedor();
        }

        private void btolimpar_Click(object sender, EventArgs e)
        {
            txtdata.Text = "";
            txtid.Text = "";
            txtnome.Text = "";
            txtobservacao.Text = "";
            txtvalordevenda.Text = "";
            cboidvendedor.Text = "";
            cbonomevendedor.Text = "";
            cboqtdedevenda.Text = "";
            cbostatus.Text = "";

        }

        private void btocadastrar_Click(object sender, EventArgs e)
        {
            string sql = "set dateformat dmy insert into produto " +
                "(id_vendedor_produto, nome_produto, qtde_produto, vvenda_produto, obs_produto)" +
                "values" +
                "('" + cboidvendedor.Text + "', '" + txtnome.Text + "', '" + cboqtdedevenda.Text + "', '" + txtvalordevenda.Text + "', '" + txtobservacao.Text + "')";

            SqlConnection conn = new SqlConnection(frmFuncionario.conexaosql);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            conn.Open();


            try
            {
                int i = cmd.ExecuteNonQuery();

                if (i > 0)
                {
                    MessageBox.Show("Cadastrado com sucesso");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro Cadastrar  " + ex.ToString());
            }
            finally { conn.Close(); }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
