using Biblioteca.DAO;
using Biblioteca.Enumeradores;
using Biblioteca.VO;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ControleDeAtendimento
{
    public partial class frPesquisaServico : Form
    {
        public ServicoVO servico = null;
        private ServicoDAO objetoDAO;

        public frPesquisaServico(ServicoDAO servicoDAO)
        {
            InitializeComponent();
            objetoDAO = servicoDAO;
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
                servico = new ServicoVO();
                if (mtxtId.Text.Trim().Length > 0)
                    servico.Id = Convert.ToInt32(mtxtId.Text.Trim());
                if (!cbxTodasEspec.Checked)
                    servico.CodEspecialidade = Convert.ToInt32(cbxEspecialidade.SelectedValue);
                dataGridView1.DataSource = objetoDAO.Pesquisa(servico);
                servico = null;
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
            if (dataGridView1.CurrentRow != null)
            {
                servico = new ServicoVO();
                servico.Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);
                servico.Nome = dataGridView1.CurrentRow.Cells["nome"].Value.ToString();
                servico.Preco = Convert.ToDouble(dataGridView1.CurrentRow.Cells["preco"].Value);
                servico.CodEspecialidade = Convert.ToInt32(dataGridView1.CurrentRow.Cells["codEspec"].Value);
                Close();
            }
        }
    }
}
