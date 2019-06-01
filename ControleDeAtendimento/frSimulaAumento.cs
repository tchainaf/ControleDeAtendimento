using Biblioteca.DAO;
using Biblioteca.Enumeradores;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ControleDeAtendimento
{
    public partial class frSimulaAumento : Form
    {
        public frSimulaAumento()
        {
            InitializeComponent();

            EspecialidadeDAO temp = new EspecialidadeDAO();
            cbxEspecialidade.DataSource = temp.Listar();
            cbxEspecialidade.DisplayMember = "Nome";
            cbxEspecialidade.ValueMember = "Id";
            cbxEspecialidade.SelectedIndex = -1;
        }

        private void btnSimular_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(cbxEspecialidade.SelectedValue) < 1)
                    throw new Exception("Selecione uma especialidade!");
                int espec = Convert.ToInt32(cbxEspecialidade.SelectedValue);
                double aumento = Convert.ToDouble(txtPorcentagem.Text)/100 + 1;

                ServicoDAO servico = new ServicoDAO();
                DataTable table = servico.Simulacao(espec, aumento);
                dataGridView1.DataSource = table;
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

        private void txtPorcentagem_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPorcentagem.Text)) return;

            char ultimaLetra = txtPorcentagem.Text[txtPorcentagem.Text.Length - 1];
            if (char.IsLetter(ultimaLetra) && ultimaLetra != ',' && ultimaLetra != '-')
            {
                Metodos.Mensagem("Insira apenas números!", TipoMsgEnum.Alerta);
                txtPorcentagem.Text = txtPorcentagem.Text.Substring(0, txtPorcentagem.Text.Length - 2);
            }
        }
    }
}
