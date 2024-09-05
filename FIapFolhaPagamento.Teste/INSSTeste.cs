using FiapFolhaPagamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIapFolhaPagamento.Teste
{
    public class INSSTeste
    {
        [Fact]  
        public void Deveria_Aplicar_Faixa_1()
        {
            var inss = new Inss();

            var desconto = inss.CalcularDesconto(1412);

            Assert.Equal(105.9m, desconto); 
        }

        [Fact]  

        public void Deveria_Aplicar_Faixa_2()
        {
            const decimal salario = 2100.00m;
            const decimal descontoEsperado = 167.82m;
            var inss = new Inss();

            var desconto = inss.CalcularDesconto(salario);
            Assert.Equal(descontoEsperado, desconto);
        }
    }
}
