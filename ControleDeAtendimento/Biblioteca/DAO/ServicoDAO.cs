using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Biblioteca.VO;

namespace Biblioteca.DAO
{
    public class ServicoDAO : PadraoDAO
    {
        protected override SqlParameter[] CriaParametros(PadraoVO o)
        {
            ServicoVO obj = o as ServicoVO;
            List<SqlParameter> param = new List<SqlParameter>();
            if (obj.Id > 0)
                param.Add(new SqlParameter("id", obj.Id));
            if (!string.IsNullOrEmpty(obj.Nome))
                param.Add(new SqlParameter("nome", obj.Nome));
            if (obj.Preco > 0)
                param.Add(new SqlParameter("preco", obj.Preco));
            if (obj.CodEspecialidade > 0)
                param.Add(new SqlParameter("cod_espec", obj.CodEspecialidade));
            return param.ToArray();
        }

        protected override PadraoVO MontaVO(DataRow dr)
        {
            ServicoVO obj = new ServicoVO();
            obj.Id = Convert.ToInt32(dr["id"].ToString());
            obj.Nome = dr["nome"].ToString();
            obj.Preco = Convert.ToDouble(dr["preco"].ToString());
            obj.CodEspecialidade = Convert.ToInt32(dr["cod_espec"].ToString());
            return obj;
        }

        protected override string ProcedureName()
        {
            return "Servico";
        }

        public List<ServicoVO> Listar(ServicoVO serv)
        {
            DataTable table;
            if (serv != null)
                table = Pesquisa(serv);
            else
                table = ListarTabela();
            List<ServicoVO> list = new List<ServicoVO>();
            foreach (DataRow item in table.Rows)
                list.Add(MontaVO(item) as ServicoVO);
            return list;
        }

        public DataTable Simulacao(int codEspec, double aumento)
        {
            List<SqlParameter> param = new List<SqlParameter>();
            param.Add(new SqlParameter("cod_espec", codEspec));
            param.Add(new SqlParameter("porcentagem", aumento));

            string sql = "sp_CalculaAumento";
            return Metodos.ExecutaSelect(sql, param.ToArray());
        }
    }
}
