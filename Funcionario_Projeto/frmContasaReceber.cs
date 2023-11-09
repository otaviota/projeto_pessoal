using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Funcionario_Projeto
{
    public partial class frmContasaReceber : Form
    {
        public frmContasaReceber()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

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

        private void btosair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btolimpar_Click(object sender, EventArgs e)
        {
            txtdata.Text = "";
            txtid.Text = "";
            txtqtdeparcelas.Text = "0";
            txtvalorconta.Text = "";
            txttipodeconta.Text = "";
        }

        private void btocadastrar_Click(object sender, EventArgs e)
        {
            string sql = "set dateformat dmy insert into contasareceber " +
                "(qtde_parcelas_contasareceber,valor_contasareceber,tipos_contasareceber,obs_contasareceber)" +
                "values" +
                "('" + txtqtdeparcelas.Text + "', '"+txtvalorconta.Text+ "', '"+txttipodeconta.Text+"', '"+txtobs.Text+"')";

            SqlConnection conn = new SqlConnection(frmFuncionario.conexaosql);
            SqlCommand cmd = new SqlCommand(sql,conn);
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

                MessageBox.Show("Erro cadastro  " + ex.ToString());
            }
            finally { conn.Close(); }
            
        }

        private void btoalterar_Click(object sender, EventArgs e)
        {
            string sql = "update contasareceber set " +
            "qtde_parcelas_contasareceber = '" + txtqtdeparcelas.Text + "', valor_contasareceber = '" + txtvalorconta.Text + "', tipos_contasareceber = '" + txttipodeconta.Text + "', obs_contasareceber = '" + txtobs.Text + "'" +
            "where id_contasareceber = " + txtid.Text;


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

                MessageBox.Show("Erro alteraçao " + ex.ToString());
            }
            finally { conn.Close(); }

        }

        private void frmContasaReceber_Load(object sender, EventArgs e)
        {
            testarconexao();
        }

        private void btoexcluir_Click(object sender, EventArgs e)
        {
            string sql = "delete contasareceber where id_contasareceber = " + txtid.Text;


            SqlConnection conn = new SqlConnection (frmFuncionario.conexaosql);
            SqlCommand cmd = new SqlCommand (sql,conn);
            cmd.CommandType = CommandType.Text;
            conn.Open ();


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
            string sql = "select * from contasareceber where id_contasareceber = " + txtid.Text;

            SqlConnection conn = new SqlConnection(frmFuncionario.conexaosql);
            SqlCommand cmd = new SqlCommand(sql,conn);
            cmd.CommandType = CommandType.Text ;
            SqlDataReader reader;
            conn.Open ();


            try
            {
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtid.Text = reader[0].ToString();
                    txtdata.Text = reader[1].ToString();
                    txtqtdeparcelas.Text = reader[2].ToString();
                    txtvalorconta.Text = reader[3].ToString();
                    txttipodeconta.Text = reader[4].ToString();
                    txtobs.Text = reader[5].ToString();
                    cbostatus.Text = reader[6].ToString();
                }
                else
                {
                    MessageBox.Show("Id de contas a receber nao existe");

                }


            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro pesquisa " + ex.ToString());
            }
            finally { conn.Close(); }
        }
    }
}
