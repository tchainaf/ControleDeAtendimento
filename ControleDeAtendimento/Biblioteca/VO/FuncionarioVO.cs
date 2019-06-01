using System;

namespace Biblioteca.VO
{
    public class FuncionarioVO : PessoaVO
    {
        private double salario;
        private int codEspec;

        public string Foto { get; set; }

        public double Salario
        {
            get
            {
                return salario;
            }
            set
            {
                if (value < 1)
                    throw new Exception("O salário deve ser preenchido!");
                salario = value;
            }
        }
        
        public int CodEspecialidade
        {
            get
            {
                return codEspec;
            }
            set
            {
                if (value < 1)
                    throw new Exception("A especialidade deve ser selecionada!");
                codEspec = value;
            }
        }
    }
}