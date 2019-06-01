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
    public partial class frPrincipal : Form
    {
        AtendimentoVO atendimento = new AtendimentoVO();

        public frPrincipal()
        {
            InitializeComponent();

            cbxFuncionario.DataSource = new FuncionarioDAO().Listar(null);
            cbxFuncionario.DisplayMember = "Nome";
            cbxFuncionario.ValueMember = "Id";
            cbxFuncionario.SelectedIndex = -1;
        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            frCadFuncionario tela = new frCadFuncionario();
            tela.ShowDialog();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frCadCliente tela = new frCadCliente();
            tela.ShowDialog();
        }

        private void btnServicos_Click(object sender, EventArgs e)
        {
            frCadServico tela = new frCadServico();
            tela.ShowDialog();
        }

        private void btnSobre_Click(object sender, EventArgs e)
        {
            frSobre tela = new frSobre();
            tela.ShowDialog();
        }

        private void btnConsultAten_Click(object sender, EventArgs e)
        {
            frPesquisaAten tela = new frPesquisaAten();
            tela.ShowDialog();
            if (tela.atendimento == null) return;
            btnNovoAten.Visible = true;

            atendimento = tela.atendimento;
            mtxtCPF.Text = (new ClienteDAO().Consulta(atendimento.CodCliente) as ClienteVO).CPF;
            cbxFuncionario.SelectedText = atendimento.Func;
            dataGridView1.DataSource = new ServDetalheDAO().Listar(atendimento.Id);
        }

        private void btnSimulacao_Click(object sender, EventArgs e)
        {
            frSimulaAumento tela = new frSimulaAumento();
            tela.Show();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            try
            {
                int codServ = Convert.ToInt32(cbxServico.SelectedValue);
                if (codServ < 1)
                    throw new Exception("Selecione o serviço para adicionar!");

                ServDetalheVO detalheVO = atendimento.servDetalhes.Find(obj => obj.CodServico == codServ);
                if (detalheVO != null)
                {
                    atendimento.servDetalhes.Remove(detalheVO);
                    detalheVO.Qtde++;
                    detalheVO.PrecoTotal = detalheVO.PrecoUnit * detalheVO.Qtde;
                    atendimento.servDetalhes.Add(detalheVO);
                    dataGridView1.DataSource = atendimento.servDetalhes;
                    dataGridView1.Refresh();
                    return;
                }

                ServicoVO aux = new ServicoDAO().Consulta(codServ) as ServicoVO;
                detalheVO = new ServDetalheVO();
                detalheVO.CodServico = aux.Id;
                detalheVO.Nome = aux.Nome;
                detalheVO.PrecoUnit = aux.Preco;
                detalheVO.Qtde = 1;
                detalheVO.PrecoTotal = detalheVO.PrecoUnit * detalheVO.Qtde;
                atendimento.servDetalhes.Add(detalheVO);
                dataGridView1.DataSource = atendimento.servDetalhes;
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

        private void btnInserirAten_Click(object sender, EventArgs e)
        {
            try
            {
                AtendimentoDAO dao = new AtendimentoDAO();
                atendimento.CodCliente = new ClienteDAO().PesquisaPorCPF(mtxtCPF.Text).Id;
                atendimento.CodFuncionario = Convert.ToInt32(cbxFuncionario.SelectedValue);
                atendimento.Data = DateTime.Now;
                dao.InsereOuAltera(atendimento);
                btnNovoAten.PerformClick();
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

        private void cbxFuncionario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxFuncionario.ValueMember != "Id") return;
            cbxServico.SelectedIndex = -1;
            cbxServico.Enabled = false;

            int codFunc = Convert.ToInt32(cbxFuncionario.SelectedValue);
            if (codFunc < 1) return;
            ServicoVO serv = new ServicoVO();
            serv.CodEspecialidade = (new FuncionarioDAO().Consulta(codFunc) as FuncionarioVO).CodEspecialidade;
            cbxServico.DataSource = new ServicoDAO().Listar(serv);
            cbxServico.DisplayMember = "Nome";
            cbxServico.ValueMember = "Id";
            cbxServico.SelectedIndex = -1;
            cbxServico.Enabled = true;
        }

        private void btnNovoAten_Click(object sender, EventArgs e)
        {
            atendimento = null;
            mtxtCPF.Text = "";
            cbxFuncionario.SelectedIndex = -1;
            dataGridView1.DataSource = null;
            btnNovoAten.Visible = false;
        }

        private void btnNovoAten_VisibleChanged(object sender, EventArgs e)
        {
            if (btnNovoAten.Visible)
            {
                btnAddItem.Visible = false;
                btnInserirAten.Visible = false;
                btnExcluirAten.Visible = true;
            }
            else
            {
                btnAddItem.Visible = true;
                btnInserirAten.Visible = true;
                btnExcluirAten.Visible = false;
            }
        }

        private void btnExcluirAten_Click(object sender, EventArgs e)
        {
            if (!Metodos.Mensagem("Tem certeza que quer excluir esse registro?", TipoMsgEnum.Exclusao))
                return;
            try
            {
                new AtendimentoDAO().Excluir(atendimento.Id);
                btnNovoAten.PerformClick();
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
    }
}