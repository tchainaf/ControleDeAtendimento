using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Transactions;
using Biblioteca.VO;

namespace Biblioteca.DAO
{
    public class AtendimentoDAO : PadraoDAO
    {
        private bool pesquisa = false;
        private SqlParameter[] dataParametros = null;

        protected override SqlParameter[] CriaParametros(PadraoVO o)
        {
            AtendimentoVO obj = o as AtendimentoVO;
            List<SqlParameter> param = new List<SqlParameter>();
            if(!pesquisa)
                param.Add(new SqlParameter("id", obj.Id));
            if (obj.CodCliente > 0)
                param.Add(new SqlParameter("cod_cliente", obj.CodCliente));
            if (obj.CodFuncionario > 0)
                param.Add(new SqlParameter("cod_func", obj.CodFuncionario));
            if (obj.Data != new DateTime())
                param.Add(new SqlParameter("dt_atendimento", obj.Data));
            return param.ToArray();
        }

        protected override PadraoVO MontaVO(DataRow dr)
        {
            AtendimentoVO obj = new AtendimentoVO();
            obj.Id = Convert.ToInt32(dr["id"].ToString());
            obj.CodCliente = Convert.ToInt32(dr["cod_cliente"].ToString());
            obj.CodFuncionario = Convert.ToInt32(dr["cod_func"].ToString());
            obj.Data = Convert.ToDateTime(dr["dt_atendimento"].ToString());
            obj.PrecoTotal = Convert.ToDouble(dr["valor_total"].ToString());
            return obj;
        }

        protected override string ProcedureName()
        {
            return "Aten";
        }

        public override DataTable Pesquisa(PadraoVO o)
        {
            pesquisa = true;
            List<SqlParameter> list = new List<SqlParameter>();
            list.AddRange(dataParametros);
            list.AddRange(CriaParametros(o));
            pesquisa = false;
            string sql = "sp_Pesquisa" + ProcedureName();
            return Metodos.ExecutaSelect(sql, list.ToArray());
        }

        public void AddParametros(string dataInicial, string dataFinal)
        {
            List<SqlParameter> param = new List<SqlParameter>();
            if (!string.IsNullOrEmpty(dataInicial))
                param.Add(new SqlParameter("dtInicial", Convert.ToDateTime(dataInicial)));
            if (!string.IsNullOrEmpty(dataFinal))
                param.Add(new SqlParameter("dtFinal", Convert.ToDateTime(dataFinal)));
            dataParametros = param.ToArray();
        }

        public override void InsereOuAltera(PadraoVO o)
        {
            string sql = "sp_IncluiOuAltera" + ProcedureName();
            ServDetalheDAO detalheDAO = new ServDetalheDAO();

            using (var transacao = new TransactionScope())
            {
                Metodos.ExecutaSQL(sql, CriaParametros(o));
                int idAten = Convert.ToInt32(ProximoId()) - 1;

                foreach (ServDetalheVO detalheVO in (o as AtendimentoVO).servDetalhes)
                {
                    detalheVO.CodAten = idAten;
                    detalheDAO.InsereOuAltera(detalheVO);
                }
                o.Id = idAten;
                Metodos.ExecutaSQL(sql, CriaParametros(o));
                transacao.Complete();
            }
        }
    }
}
