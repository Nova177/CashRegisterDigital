namespace CashRegisterDigital
{
    class CashRegister
    {

        private IInputOutput inputOutput;
        private ArithmetricUnit mathUnit;
        

        /// <summary>
        /// Creates a CashRegister instance with a specified input-output handler.
        /// </summary>
        /// <param name="inputOutput"></param>
        public CashRegister(IInputOutput inputOutput)
        {
            this.inputOutput = inputOutput;
            mathUnit = new ArithmetricUnit();
        }

        /// <summary>
        /// This class combines the methods from the class ArithemtricUnit and InputOut class.
        /// </summary>
        public void CashRegisterSystem()
        {

            inputOutput.CashRegisterWelcome();

            double price;
            do
            {
                price = inputOutput.ProductsInput();
                if (price >= 0)
                {
                    mathUnit.AddProductsCosts(price);
                    
                }

            } while (price >= 0);
            inputOutput.ProductsOutput(mathUnit.CalculateSum());


            double Money = inputOutput.CostumerMoneyInput();
            mathUnit.AddCostumerMoney(Money);

            double change = mathUnit.CalculateChange(Money);
            inputOutput.CostumerChangeOutput(change);
            
            inputOutput.ReceiptShow();

        }




    }
}