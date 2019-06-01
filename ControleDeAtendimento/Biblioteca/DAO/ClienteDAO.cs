using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Biblioteca.VO;

namespace Biblioteca.DAO
{
    public class ClienteDAO : PadraoDAO
    {
        protected override SqlParameter[] CriaParametros(PadraoVO o)
        {
            ClienteVO obj = o as ClienteVO;
            List<SqlParameter> param = new List<SqlParameter>();
            if (obj.Id > 0)
                param.Add(new SqlParameter("id", obj.Id));
            if (!string.IsNullOrEmpty(obj.Nome))
                param.Add(new SqlParameter("nome", obj.Nome));
            if (!string.IsNullOrEmpty(obj.Telefone))
                param.Add(new SqlParameter("telefone", obj.Telefone));
            if (obj.DataNascimento != new DateTime())
                param.Add(new SqlParameter("dt_nascimento", obj.DataNascimento));
            if (!string.IsNullOrEmpty(obj.CPF))
                param.Add(new SqlParameter("cpf", obj.CPF));
            if (!string.IsNullOrEmpty(obj.Endereco))
                param.Add(new SqlParameter("endereco", obj.Endereco));
            if (obj.CodCidade > 0)
                param.Add(new SqlParameter("cod_cidade", obj.CodCidade));
            return param.ToArray();
        }

        protected override PadraoVO MontaVO(DataRow dr)
        {
            ClienteVO obj = new ClienteVO();
            obj.Id = Convert.ToInt32(dr["id"].ToString());
            obj.Nome = dr["nome"].ToString();
            obj.Telefone = dr["telefone"].ToString();
            obj.DataNascimento = Convert.ToDateTime(dr["dt_nascimento"].ToString());
            obj.CPF = dr["cpf"].ToString();
            obj.Endereco = dr["endereco"].ToString();
            obj.CodCidade = Convert.ToInt32(dr["cod_cidade"].ToString());
            return obj;
        }

        protected override string ProcedureName()
        {
            return "Cliente";
        }

        public override void InsereOuAltera(PadraoVO o)
        {
            SqlParameter[] parametros = new SqlParameter[1];
            parametros[0] = new SqlParameter("@cpf", (o as ClienteVO).CPF);
            DataTable dt = Metodos.ExecutaSelect("sp_ValidaCPF", parametros);
            if (dt.Rows[0][0].ToString() == "1")
                throw new Exception("O CPF inserido já foi cadastrado!");

            string sql = "sp_IncluiOuAltera" + ProcedureName();
            Metodos.ExecutaSQL(sql, CriaParametros(o));
        }

        public List<ClienteVO> Listar(ClienteVO cliente)
        {
            DataTable table;
            if (cliente == null)
                table = ListarTabela();
            else
                table = Pesquisa(cliente);
            List<ClienteVO> list = new List<ClienteVO>();
            foreach (DataRow item in table.Rows)
                list.Add(MontaVO(item) as ClienteVO);
            return list;
        }

        public ClienteVO PesquisaPorCPF(string cpf)
        {
            SqlParameter[] parametros = new SqlParameter[1];
            parametros[0] = new SqlParameter("@cpf", cpf);

            string sql = "sp_Pesquisa" + ProcedureName();
            DataTable tb = Metodos.ExecutaSelect(sql, parametros);
            if (tb.Rows.Count < 1)
                throw new Exception("Cliente não cadastrado!");
            return MontaVO(tb.Rows[0]) as ClienteVO;
        }
    }
}
