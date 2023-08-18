namespace CashRegisterDigital
{
    /// <summary>
    /// English INPUT OUTPUT class for the Cash Register console application
    /// </summary>
    public class InputOutputEN : IInputOutput
    {
        ArithmetricUnit arithmetricUnit = new ArithmetricUnit();

        public void CashRegisterWelcome()
        {
            Console.WriteLine("---------------CashRegister---------------");
            Console.WriteLine("Please type in the product prices: ");
            Console.WriteLine("type in 'done' to end the input");
        }
        /// <summary>
        /// Takes User Input returns the Input in a double
        /// </summary>
        /// <returns>inputSum</returns>
        public double ProductsInput()
        {

            string input = Console.ReadLine();
            double euro;

            if (input.ToLower() == "done")
            {
                euro = -1;
            }
            else
            {
                euro = Convert.ToDouble(input);
            }

            return euro;

        }
        /// <summary>
        /// Gives the given Input back and tells the Costumer how much it costs
        /// </summary>
        /// <param name="sum"></param>
        /// <returns></returns>
        public double ProductsOutput(double sum)
        {
            Console.WriteLine("The total cost of the products are: {0} ", sum);
            return sum;

        }

        /// <summary>
        /// Convert input string to a double and returns it
        /// </summary>
        /// <returns>double euro</returns>
        public double CostumerMoneyInput()
        {
            Console.WriteLine("Enter the amount to be paid:");
            double euro = Convert.ToDouble(Console.ReadLine());
            return euro;

        }
        /// <summary>
        /// Tells the costumer how much he gets for change
        /// </summary>
        /// <param name="sum"></param>
        /// <returns>double change</returns>
        public double CostumerChangeOutput(double change)
        {
            Console.WriteLine($"The change is: {change}");
            return change;

        }
        /// <summary>
        /// method that show the products that were bought
        /// </summary>
        public void ReceiptShow()
        {
            Console.WriteLine("Do you want to print out the receipt?");
            Console.WriteLine("Y/N");
            string Input = Console.ReadLine();

            if (Input.ToLower() == "n")
            {
                Environment.Exit(0);

            }
            else if (Input.ToLower() == "y")
            {
                Console.WriteLine("Content of the product list:");
                int itemCount = 1;


                foreach (double item in arithmetricUnit.productlist)
                {
                    Console.WriteLine($"{itemCount}. {item}");
                    itemCount++;

                }
            }
            else
            {
                Console.WriteLine("Please enter a 'Y' for yes or an 'N' for no.");
            }

            Console.ReadKey();
        }





    }
}