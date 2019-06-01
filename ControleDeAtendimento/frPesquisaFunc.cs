using Biblioteca.DAO;
using Biblioteca.Enumeradores;
using Biblioteca.VO;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ControleDeAtendimento
{
    public partial class frPesquisaFunc : Form
    {
        public FuncionarioVO funcionario = null;
        private FuncionarioDAO objetoDAO;
        
        public frPesquisaFunc(FuncionarioDAO funcDAO)
        {
            InitializeComponent();
            objetoDAO = funcDAO;
            cbxTodasEspec.Checked = true;

            EspecialidadeDAO temp = new EspecialidadeDAO();
            cbxEspecialidade.DataSource = temp.Listar();
            cbxEspecialidade.DisplayMember = "Nome";
            cbxEspecialidade.ValueMember = "Id";
            cbxEspecialidade.SelectedIndex = -1;
        }

        private void cbxTodasEspec_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxTodasEspec.Checked)
                cbxEspecialidade.Enabled = false;
            else
                cbxEspecialidade.Enabled = true;
            cbxEspecialidade.SelectedIndex = -1;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                funcionario = new FuncionarioVO();
                if (mtxtId.Text.Trim().Length > 0)
                    funcionario.Id = Convert.ToInt32(mtxtId.Text.Trim());
                if (txtNome.Text.Trim().Length > 0)
                    funcionario.Nome = txtNome.Text.Trim();
                if (!cbxTodasEspec.Checked)
                    funcionario.CodEspecialidade = Convert.ToInt32(cbxEspecialidade.SelectedValue);
                dataGridView1.DataSource = objetoDAO.Pesquisa(funcionario);
                funcionario = null;
            }
            catch (FormatException)
            {
                Metodos.Mensagem("Campo numérico inválido!", TipoMsgEnum.Erro);
            }
            catch (SqlException)
            {
                Metodos.Mensagem("Ocorreu um erro no banco de dados.", TipoMsgEnum.Erro);
            }
            catch (Exception erro)
            {
                Metodos.Mensagem(erro.Message, TipoMsgEnum.Erro);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSelecionar.PerformClick();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentRow!=null)
            {
                funcionario = new FuncionarioVO();
                funcionario.Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);
                funcionario.Nome = dataGridView1.CurrentRow.Cells["nome"].Value.ToString();
                funcionario.Telefone = dataGridView1.CurrentRow.Cells["telefone"].Value.ToString();
                funcionario.DataNascimento = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["dataNasc"].Value);
                funcionario.Salario = Convert.ToDouble(dataGridView1.CurrentRow.Cells["salario"].Value);
                funcionario.CodEspecialidade = Convert.ToInt32(dataGridView1.CurrentRow.Cells["codEspec"].Value);
                funcionario.Foto = dataGridView1.CurrentRow.Cells["foto"].Value.ToString();
                Close();
            }
        }
    }
}
