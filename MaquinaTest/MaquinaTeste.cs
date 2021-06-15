using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using System.IO;
using VendingMachine;
using VendingMachine.Moedas;
using VendingMachine.Produtos;
using Xunit;

namespace MaquinaTest
{
    public class MaquinaTeste
    {
        [Fact]
        public void IncluirCocaCola()
        {
            Maquina maquina = new Maquina();

            maquina.EscolherProdutos(new CocaCola());

            Assert.Equal("Coca Cola", maquina.Produto.Nome);
        }

        [Fact]
        public void IncluirSprite()
        {
            Maquina maquina = new Maquina();

            maquina.EscolherProdutos(new Sprite());

            Assert.Equal("Sprite", maquina.Produto.Nome);
        }

        [Fact]
        public void IncluirAgua()
        {
            Maquina maquina = new Maquina();

            maquina.EscolherProdutos(new Agua());

            Assert.Equal("Agua", maquina.Produto.Nome);
        }

        [Fact]
        public void IncluirCincoCentavo()
        {
            Maquina maquina = new Maquina();

            maquina.ColocarMoedas(new MoedaCincoCentavo());

            Assert.Equal((decimal) 0.05, maquina.ValorColocado);
        }

        [Fact]
        public void IncluirCinquentaCentavo()
        {
            Maquina maquina = new Maquina();

            maquina.ColocarMoedas(new MoedaCinquentaCentavo());

            Assert.Equal((decimal)0.5, maquina.ValorColocado);
        }

        [Fact]
        public void IncluirDezCentavo()
        {
            Maquina maquina = new Maquina();

            maquina.ColocarMoedas(new MoedaDezCentavo());

            Assert.Equal((decimal)0.10, maquina.ValorColocado);
        }

        [Fact]
        public void IncluirDoisReais()
        {
            Maquina maquina = new Maquina();

            maquina.ColocarMoedas(new MoedaDoisReais());

            Assert.Equal(2, maquina.ValorColocado);
        }

        [Fact]
        public void IncluirUmReal()
        {
            Maquina maquina = new Maquina();

            maquina.ColocarMoedas(new MoedaUmReal());

            Assert.Equal(1, maquina.ValorColocado);
        }

        [Fact]
        public void IncluirVinteCentavo()
        {
            Maquina maquina = new Maquina();

            maquina.ColocarMoedas(new MoedaVinteCentavo());

            Assert.Equal((decimal)0.20, maquina.ValorColocado);
        }

        [Fact]
        public void IncluirTodasAsMoedas()
        {
            Maquina maquina = new Maquina();

            maquina.ColocarMoedas(new MoedaCincoCentavo());
            maquina.ColocarMoedas(new MoedaCinquentaCentavo());
            maquina.ColocarMoedas(new MoedaDezCentavo());
            maquina.ColocarMoedas(new MoedaDoisReais());
            maquina.ColocarMoedas(new MoedaUmReal());
            maquina.ColocarMoedas(new MoedaVinteCentavo());

            Assert.Equal((decimal)3.85, maquina.ValorColocado);
        }
    }
}