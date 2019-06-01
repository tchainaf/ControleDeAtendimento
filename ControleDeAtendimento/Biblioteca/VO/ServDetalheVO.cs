namespace Biblioteca.VO
{
    public class ServDetalheVO : PadraoVO
    {
        public int CodAten { get; set; }
        public int CodServico { get; set; }
        public int Qtde { get; set; }
        public double PrecoUnit { get; set; }

        //Propriedades para apoio
        public string Nome { get; set; }
        public double PrecoTotal { get; set; }
    }
}
