using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace CadastroLocalof
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void LoadId()
        {
            using (SqlConnection connection = DaoConnection.GetConexao())
            {
                SqlCommand cmd = new SqlCommand("SELECT IDENT_CURRENT('mvtBibLocal') + 1", connection);
                int proximoID = Convert.ToInt32(cmd.ExecuteScalar());


                txtCodLocal.Text = proximoID.ToString();
            }
        }
        private void CarregarUsuariosGrid()
        {
            dadosGrid.Rows.Clear();
            using (SqlConnection connection = DaoConnection.GetConexao())
            {
                LocalDAO dao = new LocalDAO(connection);
                List<LocalModel> locais = dao.GetLocais();
                foreach (LocalModel local in locais)
                {
                    DataGridViewRow row = dadosGrid.Rows[dadosGrid.Rows.Add()];
                    row.Cells[colCodLocal.Index].Value = local.codLocal;
                    row.Cells[colDescLocal.Index].Value = local.descricao;

                }
            }
        }      
        private void Form1_Load(object sender, EventArgs e)
        {
            CarregarUsuariosGrid();
            LoadId();
            btn_Excluir.Enabled = false;
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            // Valida se o campo for NULL do banco, VAZIO = "" OU " "
            if (string.IsNullOrEmpty(txtDescLocal.Text) || string.IsNullOrWhiteSpace(txtDescLocal.Text))
            {
                MessageBox.Show("Informe o campo [Descrição]", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            try
            {
                using (SqlConnection connection = DaoConnection.GetConexao())
                {
                    LocalDAO dao = new LocalDAO(connection);

                    string sql2 = "SELECT COUNT(codLocal) FROM mvtBibLocal WHERE codLocal = @local";
                    SqlCommand cmdSelect = new SqlCommand(sql2, connection);
                    cmdSelect.Parameters.AddWithValue("@local", txtCodLocal.Text);
                    int count = Convert.ToInt32(cmdSelect.ExecuteScalar());

                    if (count > 0)
                    {
                        dao.Alterar(new LocalModel()
                        {
                            codLocal = txtCodLocal.Text,
                            descricao = txtDescLocal.Text,
                        });
                    }
                    else
                    {
                        dao.Salvar(new LocalModel()
                        {
                            descricao= txtDescLocal.Text,
                        });
                    }


                    MessageBox.Show("Local salvo com sucesso!");
                    // se salvar deu certo carrega os usuários
                    CarregarUsuariosGrid();
                    LoadId();
                    btn_Excluir.Enabled = false;
                    txtDescLocal.Text = "";
                }
            }
            catch (Exception ex)
            {
                // se salvar deu errado mostra mensagem
                MessageBox.Show($"Houve um problema ao salvar o local!\n{ex.Message}");
            }
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            // Valida se o campo for NULL do banco, VAZIO = "" OU " "
            if (string.IsNullOrEmpty(txtDescLocal.Text) || string.IsNullOrWhiteSpace(txtDescLocal.Text))
            {
                MessageBox.Show("Local não foi selecionado!", "Atenção");
                return;
            }
            DialogResult confirmacao = MessageBox.Show("Deseja Excluir o local?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            try
            {
                if (confirmacao == DialogResult.Yes)
                {
                    using (SqlConnection connection = DaoConnection.GetConexao())
                    {
                        LocalDAO dao = new LocalDAO(connection);
                        dao.Excluir(new LocalModel()
                        {
                            codLocal = txtCodLocal.Text
                        });
                    }
                    MessageBox.Show("Local excluido com sucesso!");
                    CarregarUsuariosGrid();
                    LoadId();
                    btn_Excluir.Enabled = false;
                    txtDescLocal.Text = "";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Houve um problema ao excluir o local!\n{ex.Message}");
            }
        }

        private void dadosGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                txtCodLocal.Text = dadosGrid.Rows[e.RowIndex].Cells[colCodLocal.Index].Value + "";
                txtDescLocal.Text = dadosGrid.Rows[e.RowIndex].Cells[colDescLocal.Index].Value + "";
                if (string.IsNullOrEmpty(this.txtDescLocal.Text))
                {
                    btn_Excluir.Enabled = false;

                }
                else
                {
                    btn_Excluir.Enabled = true;
                }
            }
        }

        private void txtDescLocal_TextChanged(object sender, EventArgs e)
        {
            if (txtDescLocal.Text == "")
            {
                asteriscoAlert.Visible = true;  // Mostra a label se o TextBox estiver vazio
            }
            else
            {
                asteriscoAlert.Visible = false; // Oculta a label se o TextBox estiver preenchido
            }
        }

        private void asteriscoAlert_MouseHover(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            string mensagem = "Este Campo é obrigatório!";
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(label, mensagem);
        }
    }
}


