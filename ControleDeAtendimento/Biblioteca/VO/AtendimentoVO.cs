using System;
using System.Collections.Generic;

namespace Biblioteca.VO
{
    public class AtendimentoVO : PadraoVO
    {
        private int codCliente;
        private int codFunc;

        public List<ServDetalheVO> servDetalhes = new List<ServDetalheVO>();

        public DateTime Data { get; set; }

        public double PrecoTotal { get; set; }

        public int CodCliente
        {
            get
            {
                return codCliente;
            }
            set
            {
                if (value < 1)
                    throw new Exception("Informe o CPF do cliente que foi atendido!");
                codCliente = value;
            }
        }

        public int CodFuncionario
        {
            get
            {
                return codFunc;
            }
            set
            {
                if (value < 1)
                    throw new Exception("Selecione o funcionário que realizou o atendimento!");
                codFunc = value;
            }
        }

        //Propriedades para apoio
        public string Func { get; set; }
        public string Cliente { get; set; }
    }
}