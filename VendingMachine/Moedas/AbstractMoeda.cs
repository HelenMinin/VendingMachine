namespace VendingMachine.Moedas
{
    public abstract class AbstractMoeda
    {
        public decimal Valor { get; private set; }

        public AbstractMoeda(decimal valor)
        {
            Valor = valor;
        }
    }
}
