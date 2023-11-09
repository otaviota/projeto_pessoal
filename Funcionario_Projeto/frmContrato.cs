using System.Data;
using System.Data.SqlClient;

namespace Funcionario_Projeto
{
    public partial class frmContrato : Form
    {
        public frmContrato()
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

                MessageBox.Show("Erro de conexao" + ex.ToString());
            }
        }

        private void btosair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmContrato_Load(object sender, EventArgs e)
        {
            testarconexao();
            CarregarFKvendedor();
            carregarFKfuncionario();
        }

        private void btolimpar_Click(object sender, EventArgs e)
        {
            txtdata.Text = "";
            txtdatafinal.Text = "";
            txtid.Text = "";
            txtobs.Text = "";
            txtvalordecontrato.Text = "";
            cboidfuncionario.Text = "";
            cbonomefuncionario.Text = "";
            cboidvendedor.Text = "";
            cbonomevendedor.Text = "";
            cbotipodecontrato.Text = "";
            cbototaldeparcelas.Text = "";

        }


        void CarregarFKvendedor()
        {
            string sql = "select id_vendedor, nome_vendedor from vendedor";

            SqlConnection conn = new SqlConnection(frmFuncionario.conexaosql);
            SqlCommand cmd = new SqlCommand(sql, conn);
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

        void carregarFKfuncionario()
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
                cboidfuncionario.DisplayMember = "id_funcionario";
                cboidfuncionario.DataSource = tabela;

                cbonomefuncionario.DisplayMember = "nome_funcionario";
                cbonomefuncionario.DataSource = tabela;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro FK  " + ex.ToString());
            }
            finally { conn.Close(); }


        }

        private void btocadastrar_Click(object sender, EventArgs e)
        {
                string sql = "set dateformat dmy insert into contrato " +
                "(id_vendedor_contrato, id_funcionario_contrato,datafinal_contrato, vcontrato_contrato, totaldeparcelas_contrato, tipo_contrato, obs_contrato)" +
                "values" +
                "('" + cboidvendedor.Text + "', '" + cboidfuncionario.Text + "', '" + txtdatafinal.Text + "', '" + txtvalordecontrato.Text + "', '" + cbototaldeparcelas.Text + "', '" + cbotipodecontrato.Text + "', '" + txtobs.Text + "')";


             

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

                MessageBox.Show("Erro cadastrar" + ex.ToString());
            }
            finally { conn.Close(); }
        }


        private void lblconexaostatus_Click(object sender, EventArgs e)
        {
       
        }

        private void btoalterar_Click(object sender, EventArgs e)
        {
            string sql = "update contrato set " +
                "id_vendedor_contrato = '" + cboidvendedor.Text + "', id_funcionario_contrato ='" + cboidfuncionario.Text + "', datafinal_contrato = '" + txtdatafinal.Text + "', vcontrato_contrato = '" + txtvalordecontrato.Text + "', totaldeparcelas_contrato = '" + cbototaldeparcelas.Text + "', tipo_contrato = '" + cbotipodecontrato.Text + "', obs_contrato = '" + txtobs.Text + "' " +
                "where id_contrato = " + txtid.Text;

            SqlConnection conn = new SqlConnection(frmFuncionario.conexaosql);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType=CommandType.Text;
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

                MessageBox.Show("Erro alterar  " + ex.ToString());
            }
            finally { conn.Close(); }

        }

        private void btoexcluir_Click(object sender, EventArgs e)
        {
            string sql = "delete contrato where id_contrato = " + txtid.Text;

            SqlConnection conn = new SqlConnection (frmFuncionario.conexaosql);
            SqlCommand cmd = new SqlCommand(sql, conn);
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

                MessageBox.Show("Erro excluir  "  + ex.ToString());
            }
            finally { conn.Close(); }
        }

        private void btopesquisa_Click(object sender, EventArgs e)
        {
             string sql = "select * from contrato where id_contrato = " + txtid.Text;

            SqlConnection conn = new SqlConnection(frmFuncionario.conexaosql);
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader;
            DataTable tabela = new DataTable();
            conn.Open();

            try
            {
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtid.Text = reader[0].ToString();
                    cboidvendedor.Text = reader[1].ToString();
                    cboidfuncionario.Text = reader[2].ToString();
                    txtdata.Text = reader[3].ToString();    
                    txtdatafinal.Text = reader[4].ToString();
                    txtvalordecontrato.Text = reader[5].ToString();
                    cbototaldeparcelas.Text = reader[6].ToString();
                    cbotipodecontrato.Text = reader[7].ToString();
                    txtobs.Text = reader[8].ToString();
                    cbostatus.Text=reader[9].ToString();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro Pesquisar  " + ex.ToString());
            }
            finally { conn.Close(); }
        }
    }
}
