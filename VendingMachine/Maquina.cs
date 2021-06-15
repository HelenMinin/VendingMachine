using System;
using System.Collections.Generic;
using VendingMachine.Moedas;
using VendingMachine.Produtos;

namespace VendingMachine
{
    public class Maquina
    {
        #region Propriedades
        public decimal ValorColocado { get; set; }
        public AbstractProduto Produto { get; set; }
        #endregion

        #region Metodos Publicos

        public void ColocarMoedas(AbstractMoeda moeda)
        {
            ValorColocado += moeda.Valor;
        }

        public void EscolherProdutos(AbstractProduto produto)
        {
            if (Produto != null)
            {
                Console.WriteLine("Não é possivel selecionar dois produtos");
                return;
            }

            Produto = produto;
        }

        public void CancelarVenda()
        {
            if (IsVendaEmAndamento())
                throw new Exception("Não é possivel cancelar uma venda que não está em andamento");

            LiberarMoeda(ValorColocado);

            LimparMaquina();
        }

        public void Finalizar()
        {
            if (IsVendaEmAndamento())
                throw new Exception("Não é possivel finalizar uma venda que não está em andamento");

            LiberarTroco();
            LiberarProduto();

            LimparMaquina();
        } 

        #endregion

        #region Metodos Privados

        private AbstractProduto LiberarProduto()
        {
            if (ValorColocado < Produto.Preco)
            {
                Console.WriteLine($"Valor inserido {ValorColocado} é inferior ao valor do produto {Produto.Preco}");
                return null;
            }

            Produto?.LiberarProduto(ValorColocado);
            return Produto;
        }

        private void LiberarTroco()
        {
            if (IsTemTroco())
                LiberarMoeda(ValorColocado - Produto.Preco);
        }

        private bool IsTemTroco() => Produto.Preco < ValorColocado;

        private bool IsVendaEmAndamento() => ValorColocado == Decimal.Zero;

        private List<AbstractMoeda> LiberarMoeda(decimal valorQueSeraLiberado)
        {
            List<AbstractMoeda> moedas = new List<AbstractMoeda>();

            Console.WriteLine($"Liberando o valor {valorQueSeraLiberado}!!");

            return moedas;
        } 
        
        private void LimparMaquina()
        {
            ValorColocado = Decimal.Zero;
            Produto = null;
        }

        #endregion
    }
}
