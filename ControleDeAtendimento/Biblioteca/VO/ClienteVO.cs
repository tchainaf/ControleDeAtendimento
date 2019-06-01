using System;

namespace Biblioteca.VO
{
    public class ClienteVO : PessoaVO
    {
        private string cpf;
        private string endereco;
        private int codCidade;

        public string CPF
        {
            get
            {
                return cpf;
            }
            set
            {
                if (value.Length != 14)
                    throw new Exception("O CPF deve ser preenchido!");
                cpf = value;
            }
        }

        public string Endereco
        {
            get
            {
                return endereco;
            }
            set
            {
                if (value.Length < 1)
                    throw new Exception("O endereço deve ser preenchido!");
                endereco = value;
            }
        }

        public int CodCidade
        {
            get
            {
                return codCidade;
            }
            set
            {
                if (value < 1)
                    throw new Exception("A cidade deve ser preenchida!");
                codCidade = value;
            }
        }
    }
}