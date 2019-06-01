using Biblioteca.DAO;
using Biblioteca.Enumeradores;
using Biblioteca.VO;
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

namespace ControleDeAtendimento
{
    public partial class frPesquisaAten : Form
    {
        public AtendimentoVO atendimento = null;
        AtendimentoDAO objetoDAO = new AtendimentoDAO();

        public frPesquisaAten()
        {
            InitializeComponent();

            FuncionarioDAO temp = new FuncionarioDAO();
            cbxFuncionario.DataSource = temp.Listar(null);
            cbxFuncionario.DisplayMember = "Nome";
            cbxFuncionario.ValueMember = "Id";
            cbxFuncionario.SelectedIndex = -1;
        }

        private void cbxTodosClientes_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxTodosClientes.Checked)
                mtxtCPF.Enabled = false;
            else
                mtxtCPF.Enabled = true;
        }

        private void cbxTodosFuncs_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxTodosFuncs.Checked)
                cbxFuncionario.Enabled = false;
            else
                cbxFuncionario.Enabled = true;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                atendimento = new AtendimentoVO();

                objetoDAO.AddParametros(dtpDataInicial.Value.ToShortDateString(), dtpDataFinal.Value.ToShortDateString());

                if (mtxtCPF.Enabled)
                {
                    ClienteVO cli = new ClienteDAO().PesquisaPorCPF(mtxtCPF.Text);
                    atendimento.CodCliente = cli.Id;
                    atendimento.Cliente = cli.Nome;
                }
                if (!cbxTodosFuncs.Checked)
                {
                    atendimento.CodFuncionario = Convert.ToInt32(cbxFuncionario.SelectedValue);
                    atendimento.Func = cbxFuncionario.SelectedText;
                }
                dataGridView1.DataSource = objetoDAO.Pesquisa(atendimento);
                atendimento = null;
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
                atendimento = new AtendimentoVO();
                atendimento.Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);
                atendimento.CodCliente = Convert.ToInt32(dataGridView1.CurrentRow.Cells["codCliente"].Value);
                atendimento.CodFuncionario = Convert.ToInt32(dataGridView1.CurrentRow.Cells["codFunc"].Value);
                atendimento.Data = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["data"].Value);
                atendimento.PrecoTotal = Convert.ToDouble(dataGridView1.CurrentRow.Cells["valorTotal"].Value);
                atendimento.Cliente = dataGridView1.CurrentRow.Cells["cliente"].Value.ToString();
                atendimento.Func = dataGridView1.CurrentRow.Cells["func"].Value.ToString();
                Close();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                if (!Metodos.Mensagem("Tem certeza que quer excluir esse registro?", TipoMsgEnum.Exclusao))
                    return;
                try
                {
                    objetoDAO.Excluir((int)dataGridView1.CurrentRow.Cells["id"].Value);
                    dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
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
        }
    }
}
