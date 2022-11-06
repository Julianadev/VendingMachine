using MaquinaDeVenda_C_.Models;

namespace MaquinaDeVenda_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            VendingMachine vendingMachine = new VendingMachine();
            vendingMachine.Count = 5;
            vendingMachine.Capacity = 10;
            vendingMachine.moneyCollected = 100;
            vendingMachine.manuFacturer = "Coca-Cola";
            vendingMachine.Display(0);
            vendingMachine.DispenseProducts(0);
            vendingMachine.RefillProducts();
        }
    }
}



    
