using Biblioteca.Enumeradores;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Biblioteca.DAO
{
    public static class Metodos
    {
        public static void ExecutaSQL(string sql, SqlParameter[] parametros)
        {
            using (SqlConnection conn = ConexaoBD.GetConexao())
            {
                SqlCommand comando = new SqlCommand(sql, conn);
                comando.Parameters.AddRange(parametros);
                comando.CommandType = CommandType.StoredProcedure;
                comando.ExecuteNonQuery();
            }
        }

        public static DataTable ExecutaSelect(string sql, SqlParameter[] parametros)
        {
            using (SqlConnection conn = ConexaoBD.GetConexao())
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(sql, conn))
                {
                    if (parametros != null)
                        adapter.SelectCommand.Parameters.AddRange(parametros);
                    adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    DataTable tabela = new DataTable();
                    adapter.Fill(tabela);

                    return tabela;
                }
            }
        }

        public static DataTable ExecutaFunction(string sql, SqlParameter[] parametros)
        {
            using (SqlConnection conn = ConexaoBD.GetConexao())
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(sql, conn))
                {
                    if (parametros != null)
                        adapter.SelectCommand.Parameters.AddRange(parametros);
                    adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    DataTable tabela = new DataTable();
                    adapter.Fill(tabela);
                    return tabela;
                }
            }
        }

        /// <summary>
        /// Exibe uma mensagem
        /// </summary>
        /// <param name="mensagem">Texto da mensagem</param>
        /// <param name="tipoDaMensagem">tipo da mensagem</param>
        /// <returns>Quando for mensagem de confirmação, returna true se o
        /// usuário clicar em sim e retorna False caso clique em não</returns>
        public static bool Mensagem(string mensagem, TipoMsgEnum tipoDaMensagem)
        {
            if (tipoDaMensagem == TipoMsgEnum.Alerta)
            {
                MessageBox.Show(mensagem, "Atenção", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return true;
            }
            else if (tipoDaMensagem == TipoMsgEnum.Erro)
            {
                MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return true;
            }
            else if (tipoDaMensagem == TipoMsgEnum.Informacao)
            {
                MessageBox.Show(mensagem, "Informação", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                return true;
            }
            else
            {
                if (MessageBox.Show(mensagem, "Atenção", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
                    return true;
                else
                    return false;
            }
        }
    }
}