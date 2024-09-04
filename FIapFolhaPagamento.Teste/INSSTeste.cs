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
    }
}
