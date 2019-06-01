using Biblioteca.DAO;
using Biblioteca.Enumeradores;
using Biblioteca.VO;
using System;

namespace ControleDeAtendimento
{
    public partial class frCadServico : frCadPadrao
    {
        public frCadServico()
        {
            InitializeComponent();
            objetoDAO = new ServicoDAO();
            EspecialidadeDAO temp = new EspecialidadeDAO();
            cbxEspecialidade.DataSource = temp.Listar();
            cbxEspecialidade.DisplayMember = "Nome";
            cbxEspecialidade.ValueMember = "Id";
            cbxEspecialidade.SelectedIndex = -1;
        }

        protected override PadraoVO PreencheObj()
        {
            try
            {
                ServicoVO servico = new ServicoVO();
                servico.Id = Convert.ToInt32(txtId.Text);
                servico.Nome = txtDescricao.Text;
                servico.Preco = Convert.ToDouble(mtxtPreco.Text);
                servico.CodEspecialidade = Convert.ToInt32(cbxEspecialidade.SelectedValue);
                return servico;
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
                ServicoVO servico = o as ServicoVO;
                txtId.Text = servico.Id.ToString();
                txtDescricao.Text = servico.Nome;
                mtxtPreco.Text = servico.Preco.ToString("0.00");
                cbxEspecialidade.SelectedValue = servico.CodEspecialidade;
            }
            catch (Exception ex)
            {
                TrataErro(ex);
            }
        }

        protected override void AlteraModoTela(ModoTelaEnum modo)
        {
            base.AlteraModoTela(modo);

            txtDescricao.Enabled = mtxtPreco.Enabled = cbxEspecialidade.Enabled = (modo != ModoTelaEnum.Navegacao);
        }

        protected override void btnPesquisar_Click(object sender, EventArgs e)
        {
            frPesquisaServico tela = new frPesquisaServico(objetoDAO as ServicoDAO);
            tela.ShowDialog();
        }

        private void mtxtPreco_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(mtxtPreco.Text)) return;

            char ultimaLetra = mtxtPreco.Text[mtxtPreco.Text.Length - 1];
            if (char.IsLetter(ultimaLetra) && ultimaLetra != ',')
            {
                Metodos.Mensagem("Insira apenas números!", TipoMsgEnum.Alerta);
                mtxtPreco.Text = mtxtPreco.Text.Substring(0, mtxtPreco.Text.Length - 2);
            }
        }
    }
}
