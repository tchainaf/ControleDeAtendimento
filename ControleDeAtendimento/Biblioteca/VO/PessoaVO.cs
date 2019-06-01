using System;

namespace Biblioteca.VO
{
    public class PessoaVO : PadraoVO
    {
        private string nome;
        private DateTime dataNasc;
        private string telefone;

        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                if (value.Length < 1)
                    throw new Exception("O nome deve ser preenchido!");
                nome = value;
            }
        }

        public DateTime DataNascimento
        {
            get
            {
                return dataNasc;
            }
            set
            {
                if (value >= DateTime.Now)
                    throw new Exception("A data de nascimento deve ser anterior ao dia de hoje!");
                dataNasc = value;
            }
        }

        public string Telefone
        {
            get
            {
                return telefone;
            }
            set
            {
                if (value.Contains("_"))
                    throw new Exception("O telefone deve ser preenchido!");
                telefone = value;
            }
        }
    }
}
