using System.ComponentModel;

namespace CashRegisterDigital
{
    class Program
    {

        public static void Main(string[] args)
        {
            IInputOutput inputOutput = new InputOutputEN();
            CashRegister cashRegister = new CashRegister(inputOutput);

            cashRegister.CashRegisterSystem();





        }
    }



}
