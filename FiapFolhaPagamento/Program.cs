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

        public bool ContemValor(decimal valor)
        {
            if (valor > Teto)
                return true;
            return valor >= Piso;
        }
    }

    public class Inss
    {

        public Inss()
        {
            Faixas = new List<INSSFaixa>
            {
             new INSSFaixa { Piso = 0, Teto = 1412, Aliquota = 7.5m },
             new INSSFaixa { Piso = 1412.01m, Teto = 2666.68m, Aliquota = 9 },
             new INSSFaixa { Piso = 2666.69m, Teto = 4000.03m, Aliquota = 12 },
             new INSSFaixa { Piso = 4000.04m, Teto = 7786.02m, Aliquota = 14 }
            };
        }
        public List<INSSFaixa>Faixas { get; set; }

        public decimal CalcularDesconto(decimal salarioBruto)
        {
            decimal desconto = 0m;
            foreach (var item in Faixas)
            {
                if (salarioBruto >= item.Piso && salarioBruto <= item.Teto)
                {
                    desconto = salarioBruto * item.Aliquota / 100;
                    return desconto;
                }
            }
            return 0;
        }
    }
}
