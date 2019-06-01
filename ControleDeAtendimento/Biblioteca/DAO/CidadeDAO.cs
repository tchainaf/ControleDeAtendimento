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
    public class CidadeDAO : PadraoDAO
    {
        protected override SqlParameter[] CriaParametros(PadraoVO o)
        {
            return null;
        }

        protected override PadraoVO MontaVO(DataRow dr)
        {
            CidadeVO obj = new CidadeVO();
            obj.Id = Convert.ToInt32(dr["id"].ToString());
            obj.Nome = dr["nome"].ToString();
            return obj;
        }

        protected override string ProcedureName()
        {
            return "Cidades";
        }

        public List<CidadeVO> Listar()
        {
            DataTable table = ListarTabela();
            List<CidadeVO> list = new List<CidadeVO>();
            foreach (DataRow item in table.Rows)
                list.Add(MontaVO(item) as CidadeVO);
            return list;
        }
    }
}
