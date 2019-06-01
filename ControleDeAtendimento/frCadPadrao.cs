using Biblioteca.DAO;
using Biblioteca.Enumeradores;
using Biblioteca.VO;
using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ControleDeAtendimento
{
    public partial class frCadPadrao : Form
    {
        protected PadraoDAO objetoDAO;
        private bool inclusao = false;

        public frCadPadrao()
        {
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime) { }
            InitializeComponent();
        }

        protected virtual PadraoVO PreencheObj()
        {
            return null; // é necessário ter algo .. não é void!  Programar nos descendentes
        }

        protected virtual void PreencheTela(PadraoVO o)
        {
        }

        protected virtual void btnPesquisar_Click(object sender, EventArgs e)
        {
            //preencher nos filhos
        }

        private void frCadPadrao_Load(object sender, EventArgs e)
        {
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime) // modo de desenvolvimento
            {
                btnPrimeiro.PerformClick();
                AlteraModoTela(ModoTelaEnum.Navegacao);
            }
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            inclusao = true;
            AlteraModoTela(ModoTelaEnum.Inclusao);
            txtId.Text = objetoDAO.ProximoId();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            AlteraModoTela(ModoTelaEnum.Alteracao);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (!Metodos.Mensagem("Tem certeza que quer excluir esse registro?", TipoMsgEnum.Exclusao))
                return;

            try
            {
                objetoDAO.Excluir(Convert.ToInt32(txtId.Text));
                LimpaCampos(this);
                btnPrimeiro.PerformClick();
            }
            catch (Exception ex)
            {
                TrataErro(ex);
            }
        }

        protected void TrataErro(Exception erro)
        {
            if (erro is FormatException)
            {
                Metodos.Mensagem("Campo numérico inválido!", TipoMsgEnum.Erro);
            }
            else if (erro is SqlException)
            {
                Metodos.Mensagem("Ocorreu um erro no banco de dados.", TipoMsgEnum.Erro);
            }
            else if (erro is Exception)
            {
                Metodos.Mensagem(erro.Message, TipoMsgEnum.Erro);
            }
        }

        /// <summary>
        /// Altera a tela para se adequar a um determindo modo de operação
        /// que pode ser inclusão, alteração ou consulta
        /// </summary>
        /// <param name="modo">modo para o qual se deseja alterar</param>
        protected virtual void AlteraModoTela(ModoTelaEnum modo)
        {
            btnIncluir.Enabled = (modo == ModoTelaEnum.Navegacao);
            btnAlterar.Enabled = (modo == ModoTelaEnum.Navegacao);
            btnExcluir.Enabled = (modo == ModoTelaEnum.Navegacao) && !string.IsNullOrEmpty(txtId.Text);

            btnPrimeiro.Enabled = (modo == ModoTelaEnum.Navegacao);
            btnAnterior.Enabled = (modo == ModoTelaEnum.Navegacao) && !string.IsNullOrEmpty(txtId.Text);
            btnProximo.Enabled = (modo == ModoTelaEnum.Navegacao) && !string.IsNullOrEmpty(txtId.Text);
            btnUltimo.Enabled = (modo == ModoTelaEnum.Navegacao);

            btnSalvar.Enabled = (modo != ModoTelaEnum.Navegacao);
            btnCancelar.Enabled = (modo != ModoTelaEnum.Navegacao);
            btnPesquisar.Enabled = (modo == ModoTelaEnum.Navegacao);

            if (modo == ModoTelaEnum.Inclusao)
            {
                LimpaCampos(this);
                txtId.Focus();
            }
            //Sempre usar return base quando fizer override
        }

        protected void LimpaCampos(Control objeto)
        {
            if (objeto is TextBox ||
                objeto is MaskedTextBox)
                objeto.Text = "";
            else if (objeto is PictureBox)
            {
                (objeto as PictureBox).Image = null;
                (objeto as PictureBox).ImageLocation = null;
            }
            else if (objeto is ComboBox)
                (objeto as ComboBox).SelectedIndex = -1;
            else
            {
                foreach (Control o in objeto.Controls)
                    LimpaCampos(o);
            }
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                PadraoVO obj = PreencheObj();
                if (obj == null)
                    return;

                objetoDAO.InsereOuAltera(obj);
                inclusao = false;
                AlteraModoTela(ModoTelaEnum.Navegacao);
            }
            catch (Exception erro)
            {
                TrataErro(erro);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpaCampos(this);
            if (inclusao)
                PreencheTela(objetoDAO.Primeiro());
            else
                try
                {
                    PreencheTela(objetoDAO.Consulta(Convert.ToInt32(txtId.Text)));
                }
                catch { }

            inclusao = false;
            AlteraModoTela(ModoTelaEnum.Navegacao);
        }

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            try
            {
                PadraoVO o = objetoDAO.Primeiro();
                PreencheTela(o);
            }
            catch (Exception erro)
            {
                TrataErro(erro);
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtId.Text))
                    return;
                PadraoVO o = objetoDAO.Anterior(Convert.ToInt32(txtId.Text));
                PreencheTela(o);
            }
            catch (Exception erro)
            {
                TrataErro(erro);
            }
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtId.Text))
                    return;
                PadraoVO o = objetoDAO.Proximo(Convert.ToInt32(txtId.Text));
                PreencheTela(o);
            }
            catch (Exception erro)
            {
                TrataErro(erro);
            }
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            try
            {
                PadraoVO o = objetoDAO.Ultimo();
                PreencheTela(o);
            }
            catch (Exception erro)
            {
                TrataErro(erro);
            }
        }
    }
}
