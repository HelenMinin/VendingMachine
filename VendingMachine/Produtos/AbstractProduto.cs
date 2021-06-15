using System;

namespace VendingMachine.Produtos
{
    public abstract class AbstractProduto
    {
        public string Nome { get; private set; }
        public decimal Preco { get; private set; }

        public AbstractProduto(string nome, decimal preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public void LiberarProduto(decimal valorColocado)
        {
            /*
             Quem tem que saber a regra de liberação de um produto ????
             */
            Console.WriteLine($"Liberando o produto {Nome}!!");
        }
    }
}