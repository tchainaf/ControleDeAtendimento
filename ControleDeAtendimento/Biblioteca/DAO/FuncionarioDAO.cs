using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Biblioteca.VO;

namespace Biblioteca.DAO
{
    public class FuncionarioDAO : PadraoDAO
    {
        protected override SqlParameter[] CriaParametros(PadraoVO o)
        {
            FuncionarioVO obj = o as FuncionarioVO;
            List<SqlParameter> param = new List<SqlParameter>();
            if (obj.Id > 0)
                param.Add(new SqlParameter("id", obj.Id));
            if (!string.IsNullOrEmpty(obj.Nome))
                param.Add(new SqlParameter("nome", obj.Nome));
            if (!string.IsNullOrEmpty(obj.Telefone))
                param.Add(new SqlParameter("telefone", obj.Telefone));
            if (obj.DataNascimento != new DateTime())
                param.Add(new SqlParameter("dt_nascimento", obj.DataNascimento));
            if (obj.Salario > 0)
                param.Add(new SqlParameter("salario", obj.Salario));
            if (obj.CodEspecialidade > 0)
                param.Add(new SqlParameter("cod_espec", obj.CodEspecialidade));
            if (!string.IsNullOrEmpty(obj.Foto))
                param.Add(new SqlParameter("foto", obj.Foto));
            return param.ToArray();
        }

        protected override PadraoVO MontaVO(DataRow dr)
        {
            FuncionarioVO obj = new FuncionarioVO();
            obj.Id = Convert.ToInt32(dr["id"].ToString());
            obj.Nome = dr["nome"].ToString();
            obj.Telefone = dr["telefone"].ToString();
            obj.DataNascimento = Convert.ToDateTime(dr["dt_nascimento"].ToString());
            obj.Salario = Convert.ToDouble(dr["salario"].ToString());
            obj.CodEspecialidade = Convert.ToInt32(dr["cod_espec"].ToString());
            obj.Foto = dr["foto"].ToString();
            return obj;
        }
        protected override string ProcedureName()
        {
            return "Func";
        }

        public List<FuncionarioVO> Listar(FuncionarioVO func)
        {
            DataTable table;
            if (func != null)
                table = Pesquisa(func);
            else
                table = ListarTabela();
            List<FuncionarioVO> list = new List<FuncionarioVO>();
            foreach (DataRow item in table.Rows)
                list.Add(MontaVO(item) as FuncionarioVO);
            return list;
        }
    }
}
