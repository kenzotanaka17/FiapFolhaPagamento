namespace FiapFolhaPagamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //Criar uma estrutura de dados para representar a tabela
            //Calcular o desconto progressivo por faixa
            //Somar os descontos de cada faixa
        }
    }
    public class INSSFaixa {
        public decimal Piso { get; set; }

        public decimal Teto { get; set; }

        public decimal Aliquota { get; set; }
    }
}
