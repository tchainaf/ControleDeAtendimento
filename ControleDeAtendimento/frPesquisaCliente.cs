using Biblioteca.DAO;
using Biblioteca.Enumeradores;
using Biblioteca.VO;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ControleDeAtendimento
{
    public partial class frPesquisaCliente : Form
    {
        public ClienteVO cliente = null;
        private ClienteDAO objetoDAO;

        public frPesquisaCliente(ClienteDAO clienteDAO)
        {
            InitializeComponent();
            objetoDAO = clienteDAO;

            cbxCidade.DataSource = new CidadeDAO().Listar();
            cbxCidade.DisplayMember = "Nome";
            cbxCidade.ValueMember = "Id";
            cbxCidade.SelectedIndex = -1;
        }

        private void cbxTodasCidades_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxTodasCidades.Checked)
                cbxCidade.Enabled = false;
            else
                cbxCidade.Enabled = true;
            cbxCidade.SelectedIndex = -1;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                cliente = new ClienteVO();
                if (!mtxtCPF.Text.Contains("_"))
                    cliente.CPF = mtxtCPF.Text;
                if (txtNome.Text.Trim().Length > 0)
                    cliente.Nome = txtNome.Text.Trim();
                if (!cbxTodasCidades.Checked)
                    cliente.CodCidade = Convert.ToInt32(cbxCidade.SelectedValue);
                dataGridView1.DataSource = objetoDAO.Pesquisa(cliente);
                cliente = null;
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
                cliente = new ClienteVO();
                cliente.Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);
                cliente.CPF = dataGridView1.CurrentRow.Cells["cpf"].Value.ToString();
                cliente.Nome = dataGridView1.CurrentRow.Cells["nome"].Value.ToString();
                cliente.Telefone = dataGridView1.CurrentRow.Cells["telefone"].Value.ToString();
                cliente.DataNascimento = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["dataNasc"].Value);
                cliente.CodCidade = Convert.ToInt32(dataGridView1.CurrentRow.Cells["codCidade"].Value);
                cliente.Endereco = dataGridView1.CurrentRow.Cells["endereco"].Value.ToString();
                Close();
            }
        }
    }
}
