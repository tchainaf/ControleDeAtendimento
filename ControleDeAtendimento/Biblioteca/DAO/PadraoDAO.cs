using Biblioteca.VO;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Biblioteca.DAO
{
    abstract public class PadraoDAO
    {
        #region Métodos e Propriedades Abstratas       
        protected abstract string ProcedureName();
        protected abstract SqlParameter[] CriaParametros(PadraoVO o);
        protected abstract PadraoVO MontaVO(DataRow dr);
        #endregion        

        /// <summary>
        /// Método  para inserir um registro no BD
        /// </summary>        
        public virtual void InsereOuAltera(PadraoVO o)
        {
            string sql = "sp_IncluiOuAltera" + ProcedureName();
            Metodos.ExecutaSQL(sql, CriaParametros(o));
        }

        /// <summary>
        /// Método para excluir 
        /// </summary>        
        public virtual void Excluir(int Id)
        {
            string sql = "sp_Excluir" + ProcedureName();
            SqlParameter[] parametros = new SqlParameter[1];
            parametros[0] = new SqlParameter("@id", Id);
            Metodos.ExecutaSQL(sql, parametros);
        }

        /// <summary>
        /// Método para consultar 1 registro
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public PadraoVO Consulta(int id)
        {
            using (SqlConnection cx = ConexaoBD.GetConexao())
            {
                string sql = "sp_Consulta" + ProcedureName();
                SqlParameter[] parametros = { new SqlParameter("id", id) };
                return ExecutaSqlLocal(sql, parametros);

            }
        }

        public virtual DataTable Pesquisa(PadraoVO o)
        {
            string sql = "sp_Pesquisa" + ProcedureName();
            return Metodos.ExecutaSelect(sql, CriaParametros(o));
        }

        /// <summary>
        /// Obtem o Proximo id disponível 
        /// </summary>
        /// <returns></returns>
        public virtual string ProximoId()
        {
            string sql = $"sp_ProximoId" + ProcedureName();
            DataTable table = Metodos.ExecutaSelect(sql, null);
            return table.Rows[0][0].ToString();
        }

        /// <summary>
        /// Primeiro registro
        /// </summary>
        /// <returns></returns>
        public virtual PadraoVO Primeiro()
        {
            string sql = $"sp_NavegaPrimeiro" + ProcedureName();
            return ExecutaSqlLocal(sql, null);
        }

        /// <summary>
        /// Ultimo registro
        /// </summary>
        /// <returns></returns>
        public virtual PadraoVO Ultimo()
        {
            string sql = $"sp_NavegaUltimo" + ProcedureName();
            DataTable tabela = Metodos.ExecutaSelect(sql, null);
            return ExecutaSqlLocal(sql, null);
        }

        /// <summary>
        /// Próximo registro
        /// </summary>
        /// <param name="atual"></param>
        /// <returns></returns>
        public virtual PadraoVO Proximo(int atual)
        {
            string sql = $"sp_NavegaProximo" + ProcedureName();
            SqlParameter[] p = { new SqlParameter("idAtual", atual) };
            return ExecutaSqlLocal(sql, p);
        }

        /// <summary>
        /// Registro anterior
        /// </summary>
        /// <param name="atual"></param>
        /// <returns></returns>
        public virtual PadraoVO Anterior(int atual)
        {
            string sql = $"sp_NavegaAnterior" + ProcedureName();
            SqlParameter[] p = { new SqlParameter("idAtual", atual) };
            return ExecutaSqlLocal(sql, p);
        }
        
        protected DataTable ListarTabela()
        {
            using (SqlConnection cx = ConexaoBD.GetConexao())
            {
                string sql = "sp_Listar" + ProcedureName();
                return Metodos.ExecutaSelect(sql, null);
            }
        }

        /// <summary>
        /// Executa uma instrução SQL
        /// </summary>
        /// <param name="sql">instrução</param>
        /// <param name="parametros">parametros</param>
        /// <returns>Objeto PadraoVO</returns>
        protected PadraoVO ExecutaSqlLocal(string sql, SqlParameter[] parametros)
        {
            DataTable tabela = Metodos.ExecutaSelect(sql, parametros);

            if (tabela.Rows.Count == 0)
                return null;
            else
                return MontaVO(tabela.Rows[0]);
        }
    }
}