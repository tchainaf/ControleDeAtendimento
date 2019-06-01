using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.VO;

namespace Biblioteca.DAO
{
    public class ServDetalheDAO : PadraoDAO
    {
        protected override SqlParameter[] CriaParametros(PadraoVO o)
        {
            ServDetalheVO obj = o as ServDetalheVO;
            List<SqlParameter> param = new List<SqlParameter>();
            if (obj.CodAten > 0)
                param.Add(new SqlParameter("cod_atendimento", obj.CodAten));
            if (obj.CodServico > 0)
                param.Add(new SqlParameter("cod_servico", obj.CodServico));
            if (obj.Qtde > 0)
                param.Add(new SqlParameter("qtdeservico", obj.Qtde));
            return param.ToArray();
        }

        protected override PadraoVO MontaVO(DataRow dr)
        {
            ServDetalheVO obj = new ServDetalheVO();
            obj.CodAten = Convert.ToInt32(dr["cod_atendimento"].ToString());
            obj.CodServico = Convert.ToInt32(dr["cod_servico"].ToString());
            obj.Qtde = Convert.ToInt32(dr["qtdeservico"].ToString());
            obj.PrecoUnit = Convert.ToDouble(dr["precoUnit"].ToString());
            return obj;
        }

        protected override string ProcedureName()
        {
            return "AtenXservico";
        }

        public override void InsereOuAltera(PadraoVO o)
        {
            string sql = "sp_Inclui" + ProcedureName();
            Metodos.ExecutaSQL(sql, CriaParametros(o));
        }

        public List<ServDetalheVO> Listar(int codAten)
        {
            string sql = "sp_Itens" + ProcedureName();
            SqlParameter[] parametros = new SqlParameter[1];
            parametros[0] = new SqlParameter("@id", codAten);
            DataTable table = Metodos.ExecutaSelect(sql, parametros);
            List<ServDetalheVO> list = new List<ServDetalheVO>();
            foreach (DataRow item in table.Rows)
                list.Add(MontaVO(item) as ServDetalheVO);
            return list;
        }
    }
}
