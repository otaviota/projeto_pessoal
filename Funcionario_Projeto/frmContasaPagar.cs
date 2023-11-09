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
    public partial class frmContasaPagar : Form
    {
        public frmContasaPagar()
        {
            InitializeComponent();
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

                MessageBox.Show("Erro de cadastramento   " + ex.ToString());
            }

        }

        private void cboidfkfuncionario_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void frmContasaPagar_Load(object sender, EventArgs e)
        {
            testarconexao();
            CarregarFkFuncionario();
        }

        void CarregarFkFuncionario()
        {
            string sql = "select id_funcionario, nome_funcionario from funcionario";


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
                cboidfkfuncionario.DisplayMember = "id_funcionario";
                cboidfkfuncionario.DataSource = tabela;

                cbonomefkfuncionario.DisplayMember = "nome_funcionario";
                cbonomefkfuncionario.DataSource = tabela;

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro FK " + ex.ToString());
            }
            finally { conn.Close(); }
        }

        private void btosair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btolimpar_Click(object sender, EventArgs e)
        {
            txtdata.Text = "";
            txtid.Text = "";
            txtobs.Text = "";
            txtqtdeparcelas.Text = "0";
            txtvalorconta.Text = "";
           
        }

        private void btocadastrar_Click(object sender, EventArgs e)
        {
            string sql = "set dateformat dmy insert into contasapagar" +
                "(id_funcionario_contasapagar,qtde_parcelas_contasapagar,valor_contasapagar,obs_contasapagar)" +
                "values" +
                "('"+cboidfkfuncionario.Text+"','" + txtqtdeparcelas.Value.ToString() + "', '"+txtvalorconta.Text+"', '"+txtobs.Text+"' )";


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

                MessageBox.Show("Erro cadastrar " + ex.ToString());
            }
            finally {conn.Close();}
        }




        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btoalterar_Click(object sender, EventArgs e)
        {
            string sql = "update contasapagar set " +
                "id_funcionario_contasapagar = '" + cboidfkfuncionario.Text + "', qtde_parcelas_contasapagar = '" + txtqtdeparcelas.Value.ToString() + "', valor_contasapagar = '" + txtvalorconta.Text + "', obs_contasapagar = '" + txtobs.Text + "'" +
                " where id_contasapagar = " + txtid.Text;


            SqlConnection conn = new SqlConnection(frmFuncionario.conexaosql);
            SqlCommand cmd = new SqlCommand(sql,conn);
            cmd.CommandType = CommandType.Text;
            conn.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();

                if (i > 0)
                {
                    MessageBox.Show("Alterado com sucesso");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro alterar" + ex.ToString());
            }
            finally { conn.Close(); }

        }

        private void btoexcluir_Click(object sender, EventArgs e)
        {
            string sql = "delete contasapagar where id_contasapagar = " + txtid.Text;

            SqlConnection conn = new SqlConnection(frmFuncionario.conexaosql);
            SqlCommand cmd = new SqlCommand(sql,conn);
            conn.Open();


            try
            {
                int i = cmd.ExecuteNonQuery();

                if (i > 0)
                {
                    MessageBox.Show("Excluido com sucesso");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro excluir " + ex.ToString());
            }
            finally { conn.Close(); }
        }

        private void btopesquisa_Click(object sender, EventArgs e)
        {
            string sql = "select * from contasapagar where id_contasapagar = " + txtid.Text;

            SqlConnection conn = new SqlConnection(frmFuncionario.conexaosql);
            SqlCommand cmd = new SqlCommand(sql,conn);
            SqlDataReader reader;
            conn.Open();


            try
            {
                reader = cmd.ExecuteReader();

                if (reader.Read()) 
                {
                    txtid.Text = reader[0].ToString();
                    cboidfkfuncionario.Text = reader[1].ToString();
                    txtdata.Text = reader[2].ToString();
                    txtqtdeparcelas.Text = reader[3].ToString();
                    txtvalorconta.Text = reader[4].ToString();  
                    txtobs.Text = reader[5].ToString();
                    cbostatus.Text = reader[6].ToString();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro pesquisa " + ex.ToString());
            }
        }
    }
}
