
using System.Data;
using System.Data.SqlClient;

namespace Funcionario_Projeto
{
    public partial class frmFuncionario : Form
    {
        public frmFuncionario()
        {
            InitializeComponent();
        }


        private void frmFuncionario_Load(object sender, EventArgs e)
        {
            testarconexao();
            CarregarDataGridContrato();
        }

        private void btosair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btolimpar_Click(object sender, EventArgs e)
        {
            txtbairro.Text = "";
            txtcep.Text = "";
            txtcidade.Text = "";
            txtcomplemento.Text = "";
            txtcpf.Text = "";
            txtdata.Text = "";
            txtemail.Text = "";
            txtid.Text = "";
            txtnascimento.Text = "";
            txtlogradouro.Text = "";
            txtnome.Text = "";
            txtnumero.Text = "0";
            txtobservacao.Text = "";
            txttelefone1.Text = "";
            txttelefone2.Text = "";
            txtuf.Text = "";
            cbocargo.SelectedIndex = -1;
            cbosetor.SelectedIndex = -1;
            cbostatus.SelectedIndex = -1;

        }

        public static string conexaosql = "" +
        "Data Source=localhost;" +
            "Initial Catalog=t14_projeto_slook;" +
            "User ID=sa;" +
            "Password=123456";

        private void testarconexao()
        {
            SqlConnection conn = new SqlConnection(conexaosql);
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

        private void btocadastrar_Click(object sender, EventArgs e)
        {
            string sql = "set dateformat dmy insert into funcionario" +
                "(nome_funcionario, setor_funcionario, cargo_funcionario, nasc_funcionario, cpf_funcionario, logradouro_funcionario, numero_funcionario, comp_funcionario, cep_funcionario, bairro_funcionario, cidade_funcionario, uf_funcionario, telefone1_funcionario, telefone2_funcionario, email_funcionario, obs_funcionario)" +
                "values" +
                "('"+txtnome.Text+ "', '"+cbosetor.Text+ "', '"+cbocargo.Text+ "', '"+txtnascimento.Text+ "', '"+txtcpf.Text+ "', '"+txtlogradouro.Text+ "', '"+txtnumero.Text+ "', '"+txtcomplemento.Text+ "', '"+txtcep.Text+ "', '"+txtbairro.Text+ "', '"+txtcidade.Text+ "', '"+txtuf.Text+ "', '"+txttelefone1.Text+ "', '"+txttelefone2.Text+ "', '"+txtemail.Text+ "', '"+txtobservacao.Text+"')";
                //'"++"', 


            SqlConnection conn = new SqlConnection(conexaosql);
            SqlCommand cmd = new SqlCommand(sql,conn);
            cmd.CommandType = CommandType.Text;
            conn.Open();


            try
            {
                int i = cmd.ExecuteNonQuery();
                if(i > 0)
                {
                    MessageBox.Show("Funcionario cadastrado");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro de cadastramento   " + ex.ToString() );
            }
            finally { conn.Close(); }
        }

        private void btoalterar_Click(object sender, EventArgs e)
        {
            string sql = "update funcionario set " +
                "nome_funcionario = '" + txtnome.Text + "', setor_funcionario= '" + cbosetor.Text + "', cargo_funcionario= '" + cbocargo.Text + "', nasc_funcionario= '" + txtnascimento.Text + "', cpf_funcionario= '" + txtcpf.Text + "', logradouro_funcionario= '" + txtlogradouro.Text + "', numero_funcionario= '" + txtnumero.Value.ToString() + "', comp_funcionario= '" + txtcomplemento.Text + "', cep_funcionario = '" + txtcep.Text + "', bairro_funcionario= '" + txtbairro.Text + "', cidade_funcionario= '" + txtcidade.Text + "', uf_funcionario = '" + txtuf.Text + "', telefone1_funcionario= '" + txttelefone1.Text + "', telefone2_funcionario = '" + txttelefone2.Text + "', email_funcionario = '" + txtemail.Text + "', obs_funcionario= '" + txtobservacao.Text + "'" +
                "where id_funcionario = " + txtid.Text;

            
            SqlConnection conn = new SqlConnection(conexaosql);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            conn.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Alterado com sucesso ");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro alteraçao  " + ex.ToString());
            }
            finally { conn.Close(); }
        }

        private void btopesquisa_Click(object sender, EventArgs e)
        {
            string sql = "select * from funcionario where id_funcionario = " + txtid.Text;

            SqlConnection conn = new SqlConnection(conexaosql);
            SqlCommand cmd = new SqlCommand(sql,conn);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            conn.Open();

            try
            {
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtid.Text = reader[0].ToString();
                    txtnome.Text=reader[1].ToString();
                    cbosetor.Text=reader[2].ToString();
                    cbocargo.Text=reader[3].ToString();
                    txtnascimento.Text=reader[4].ToString();
                    txtdata.Text=reader[5].ToString();
                    txtcpf.Text=reader[6].ToString();
                    txtlogradouro.Text=reader[7].ToString();
                    txtnumero.Value = decimal.Parse(reader[8].ToString());
                    txtcomplemento.Text=reader[9].ToString();
                    txtcep.Text=reader[10].ToString();
                    txtbairro.Text=reader[11].ToString();
                    txtcidade.Text=reader[12].ToString();
                    txtuf.Text=reader[13].ToString();
                    txttelefone1.Text=reader[14].ToString();
                    txttelefone2.Text=reader[15].ToString();
                    txtemail.Text=reader[16].ToString();
                    txtobservacao.Text=reader[17].ToString();
                    cbostatus.Text=reader[18].ToString();
                    

                }
                else
                {
                    MessageBox.Show("Codigo de funcionario inexistente");
                    
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro pesquisa  " + ex.ToString());
            }
            finally { conn.Close(); }
        }

        private void btoexcluir_Click(object sender, EventArgs e)
        {
            string sql = "delete funcionario where id_funcionario = " + txtid.Text;

            SqlConnection conn = new SqlConnection(conexaosql);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            conn.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();

                if (i > 0)
                {
                    MessageBox.Show("Excluido com sucesso");
                }
                else
                {
                    MessageBox.Show("ID de funcionario não existe");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro excluir  " + ex.ToString());
            }
            finally { conn.Close(); }





        }

        private void CarregarDataGridContrato()
        {
            if (txtid.Text == "")
            {
                return;
            }

            string sql = "select id_contrato as 'ID'," +
                "id_vendedor_contrato as 'ID vendedor'," +
                "id_funcionario_contrato as 'ID funcionario'," +
                "data_contrato as 'Data'," +
                "datafinal_contrato as 'Data Final'," +
                "vcontrato_contrato as 'Valor de contrato'," +
                "totaldeparcelas_contrato as 'Total de Parcelas'," +
                "tipo_contrato as 'Tipo de Contrato'," +
                "obs_contrato as 'Observação', " +
                "status_contrato as 'Status'" +
                "from contrato where id_funcionario_contrato = " + txtid.Text;


            SqlConnection conn = new SqlConnection(conexaosql);
            SqlDataAdapter adapter = new SqlDataAdapter(sql,conn);
            DataSet ds = new DataSet();
            conn.Open();

            try
            {
                adapter.Fill(ds);

                datagridcontrato.DataSource = ds.Tables[0];
                datagridcontrato.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                datagridcontrato.AutoResizeRow(0, DataGridViewAutoSizeRowMode.AllCellsExceptHeader);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro datagrid  " + ex.ToString());
            }
            finally { conn.Close(); }
        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {
            CarregarDataGridContrato();
        }

        private void datagridcontrato_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = datagridcontrato.CurrentRow.Cells["ID"].Value.ToString();
            btopesquisa.PerformClick();
        }
    }
}