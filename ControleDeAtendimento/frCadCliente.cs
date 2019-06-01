using Biblioteca.DAO;
using Biblioteca.Enumeradores;
using Biblioteca.VO;
using System;

namespace ControleDeAtendimento
{
    public partial class frCadCliente : frCadPadrao
    {
        public frCadCliente()
        {
            InitializeComponent();
            objetoDAO = new ClienteDAO();
            CidadeDAO temp = new CidadeDAO();
            cbxCidade.DataSource = temp.Listar();
            cbxCidade.DisplayMember = "Nome";
            cbxCidade.ValueMember = "Id";
            cbxCidade.SelectedIndex = -1;
        }

        protected override PadraoVO PreencheObj()
        {
            try
            {
                ClienteVO cliente = new ClienteVO();
                cliente.Id = Convert.ToInt32(txtId.Text);
                cliente.Nome = txtDescricao.Text;
                cliente.Telefone = mtxtTelefone.Text;
                cliente.DataNascimento = Convert.ToDateTime(mtxtDataNasc.Text);
                cliente.CPF = mtxtCPF.Text;
                cliente.Endereco = txtEndereco.Text;
                cliente.CodCidade = Convert.ToInt32(cbxCidade.SelectedValue);
                return cliente;
            }
            catch (Exception ex)
            {
                TrataErro(ex);
                return null;
            }
        }

        protected override void PreencheTela(PadraoVO o)
        {
            if (o == null) return;

            try
            {
                ClienteVO cliente = o as ClienteVO;
                txtId.Text = cliente.Id.ToString();
                txtDescricao.Text = cliente.Nome;
                mtxtDataNasc.Text = cliente.DataNascimento.ToString("dd/MM/yyyy");
                mtxtCPF.Text = cliente.CPF;
                txtEndereco.Text = cliente.Endereco;
                mtxtTelefone.Text = cliente.Telefone;
                cbxCidade.SelectedValue = cliente.CodCidade;
            }
            catch (Exception ex)
            {
                TrataErro(ex);
            }
        }

        protected override void AlteraModoTela(ModoTelaEnum modo)
        {
            base.AlteraModoTela(modo);

            txtDescricao.Enabled = mtxtDataNasc.Enabled = mtxtCPF.Enabled = mtxtTelefone.Enabled =
                cbxCidade.Enabled = txtEndereco.Enabled = (modo != ModoTelaEnum.Navegacao);
        }

        protected override void btnPesquisar_Click(object sender, EventArgs e)
        {
            frPesquisaCliente tela = new frPesquisaCliente(objetoDAO as ClienteDAO);
            tela.ShowDialog();
            PreencheTela(tela.cliente);
        }
    }
}
