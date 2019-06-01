using Biblioteca.DAO;
using Biblioteca.Enumeradores;
using Biblioteca.VO;
using System;
using System.IO;

namespace ControleDeAtendimento
{
    public partial class frCadFuncionario : frCadPadrao
    {
        string caminhoExe = Directory.GetCurrentDirectory() + "\\Fotos\\";

        public frCadFuncionario()
        {
            InitializeComponent();
            objetoDAO = new FuncionarioDAO();

            Directory.CreateDirectory(caminhoExe);

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
                if (string.IsNullOrEmpty(pictureBoxFunc.ImageLocation))
                    throw new Exception("Uma foto deve ser inserida!");

                FuncionarioVO funcionario = new FuncionarioVO();
                funcionario.Id = Convert.ToInt32(txtId.Text);
                funcionario.Nome = txtDescricao.Text;
                funcionario.Telefone = mtxtTelefone.Text;
                funcionario.DataNascimento = Convert.ToDateTime(mtxtDataNasc.Text);
                funcionario.Salario = Convert.ToDouble(mtxtSalario.Text);
                funcionario.CodEspecialidade = Convert.ToInt32(cbxEspecialidade.SelectedValue);
                funcionario.Foto = funcionario.Id.ToString() + ".jpg";

                if (pictureBoxFunc.ImageLocation != caminhoExe + funcionario.Foto)
                    File.Copy(pictureBoxFunc.ImageLocation, caminhoExe + funcionario.Foto, true);

                return funcionario;
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
            pictureBoxFunc.Image = null;
            pictureBoxFunc.ImageLocation = null;

            try
            {
                FuncionarioVO funcionario = o as FuncionarioVO;
                txtId.Text = funcionario.Id.ToString();
                txtDescricao.Text = funcionario.Nome;
                mtxtDataNasc.Text = funcionario.DataNascimento.ToString("dd/MM/yyyy");
                mtxtSalario.Text = funcionario.Salario.ToString("0.00");
                mtxtTelefone.Text = funcionario.Telefone;
                cbxEspecialidade.SelectedValue = funcionario.CodEspecialidade;
                pictureBoxFunc.Load(caminhoExe + funcionario.Foto);
            }
            catch (Exception ex)
            {
                TrataErro(ex);
            }
        }

        protected override void AlteraModoTela(ModoTelaEnum modo)
        {
            base.AlteraModoTela(modo);

            txtDescricao.Enabled = mtxtDataNasc.Enabled = mtxtSalario.Enabled = mtxtTelefone.Enabled = 
                cbxEspecialidade.Enabled = btnFoto.Enabled = (modo != ModoTelaEnum.Navegacao);
            
        }

        protected override void btnPesquisar_Click(object sender, EventArgs e)
        {
            frPesquisaFunc tela = new frPesquisaFunc(objetoDAO as FuncionarioDAO);
            tela.ShowDialog();
            PreencheTela(tela.funcionario);
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBoxFunc.Load(openFileDialog1.FileName);
        }

        private void mtxtSalario_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(mtxtSalario.Text)) return;

            char ultimaLetra = mtxtSalario.Text[mtxtSalario.Text.Length - 1];
            if (char.IsLetter(ultimaLetra) && ultimaLetra != ',')
            {
                Metodos.Mensagem("Insira apenas números!", TipoMsgEnum.Alerta);
                mtxtSalario.Text = mtxtSalario.Text.Substring(0, mtxtSalario.Text.Length - 1);
            }
        }
    }
}
