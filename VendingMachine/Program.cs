using System;
using VendingMachine.Moedas;
using VendingMachine.Produtos;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Maquina maquina = new Maquina();

                maquina.ColocarMoedas(new MoedaCinquentaCentavo());
                maquina.ColocarMoedas(new MoedaUmReal());
                maquina.EscolherProdutos(new CocaCola());

                maquina.Finalizar();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
