namespace CashRegisterDigital
{

    /// <summary>
    /// German INPUT OUTPUT class for the Cash Register console application
    /// </summary>
    public class InputOutputDE : IInputOutput
    {

        ArithmetricUnit arithmetricUnit = new ArithmetricUnit();
        /// <summary>
        /// Cosnsole output instructions
        /// </summary>
        public void CashRegisterWelcome()
        {
            Console.WriteLine("---------------KASSE---------------");
            Console.WriteLine("Bitte gib die Produkt Kosten ein: ");
            Console.WriteLine("'fertig' zum beenden der eingabe!");
        }

        /// <summary>
        /// Takes User Input returns the Input in a double
        /// </summary>
        /// <returns>inputSum</returns>
        public double ProductsInput()
        {

            string input = Console.ReadLine();
            double euro;

            if (input.ToLower() == "fertig")
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
            Console.WriteLine("Die Gesamtkosten der Produkte sind: {0} ", sum);
            return sum;

        }

        /// <summary>
        /// Convert input string to a double and returns it
        /// </summary>
        /// <returns>double euro</returns>
        public double CostumerMoneyInput()
        {
            Console.WriteLine("Gib den zu zahlenden Betrag ein:");
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
            Console.WriteLine($"Das Wechselgeld beträgt: {change}");
            return change;


        }
        public void ReceiptShow()
        {
            Console.WriteLine("Möchtest du den Kassenbon ausdrucken?");
            Console.WriteLine("J/N");
            string Input = Console.ReadLine();

            if (Input.ToLower() == "n")
            {
                Environment.Exit(0);

            }
            if (Input.ToLower() == "j")
            {
                Console.WriteLine("Inhalt der Produktliste:");
                int itemCount = 1;
                foreach (double item in arithmetricUnit.productlist)
                {
                    Console.WriteLine($"{itemCount}. {item}");
                    itemCount++;

                }
            }
            else
            {
                Console.WriteLine("Bitte gib ein 'J' für Ja oder ein 'N' fü nein machen");
            }
            
            Console.ReadKey();
        }
       
           
            

    }


     


       
}