using System;

namespace Biblioteca.VO
{
    public class ServicoVO : PadraoVO
    {
        private string nome;
        private int codEspec;
        private double preco;

        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                if (value.Length < 1)
                    throw new Exception("A descrição deve ser preenchida!");
                nome = value;
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

        public double Preco
        {
            get
            {
                return preco;
            }
            set
            {
                if (value < 1)
                    throw new Exception("O preço deve ser preenchido!");
                preco = value;
            }
        }
    }
}