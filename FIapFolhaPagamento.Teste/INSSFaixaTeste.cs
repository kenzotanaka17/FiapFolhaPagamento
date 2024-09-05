using FiapFolhaPagamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIapFolhaPagamento.Teste
{
    public class INSSFaixaTeste
    {

        public static IEnumerable<object[]> DadosValorFaixa =>
            new List<object[]>
            {
                new object[](0, 1412.00m, 7.5m, 1412m),
                new object[]()
            };


        [Fact]

        public void INSS_Faixa_Deve_Conter_Valor()
        {
            var faixa = new INSSFaixa
            {
                Piso = 0,
                Teto = 1422
            };

            Assert.True(faixa.ContemValor(1200));
        }
        [Fact]

        public void Deve_Obter_1412()
        {
            var faixa = new INSSFaixa
            {
                Piso = 0,
                Teto = 1412,
                Aliquota = 7.5m
            };
            var resultado = faixa.ObtemValorFaixa(1412);
            const decimal esperado = 1412m;

            Assert.Equal(esperado, resultado);
        }
    }
}
