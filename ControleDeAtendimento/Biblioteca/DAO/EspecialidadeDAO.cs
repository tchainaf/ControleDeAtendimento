using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Biblioteca.VO;

namespace Biblioteca.DAO
{
    public class EspecialidadeDAO : PadraoDAO
    {
        protected override SqlParameter[] CriaParametros(PadraoVO o)
        {
            EspecialidadeVO obj = o as EspecialidadeVO;
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("id", obj.Id);
            param[1] = new SqlParameter("nome", obj.Nome);
            return param;
        }

        protected override PadraoVO MontaVO(DataRow dr)
        {
            EspecialidadeVO obj = new EspecialidadeVO();
            obj.Id = Convert.ToInt32(dr["id"].ToString());
            obj.Nome = dr["nome"].ToString();
            return obj;
        }
        protected override string ProcedureName()
        {
            return "Espec";
        }

        public List<EspecialidadeVO> Listar()
        {
            DataTable table = ListarTabela();
            List<EspecialidadeVO> list = new List<EspecialidadeVO>();
            foreach (DataRow item in table.Rows)
                list.Add(MontaVO(item) as EspecialidadeVO);
            return list;
        }
    }
}
