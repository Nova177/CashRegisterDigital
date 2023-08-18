namespace CashRegisterDigital
{
    /// <summary>
    /// public class that adds double Numbers and give it back
    /// </summary>
    public class ArithmetricUnit
    {
        /// <summary>
        /// LinkedList that saves the products that.
        /// </summary>
        public LinkedList<double> productlist {get; private set; } = new LinkedList<double>();
        private double CostumerMoney { get; set; }

        /// <summary>
        /// Add productscosts, if positive, to the productlist
        /// </summary>
        /// <param name="productcost"></param>
        /// <exception cref="Exception">Products cant be a negative number</exception>
        public void AddProductsCosts(double productcost)
        {
            if (productcost < 0)
            {
                throw new Exception("Produkte können nicht negativ sein!");
            }
            productlist.AddLast(productcost);
        }
        /// <summary>
        /// overrides the attribute CostumerMoney
        /// </summary>
        /// <param name="costumermoney"></param>
        public void AddCostumerMoney(double costumermoney)
        {
            CostumerMoney = costumermoney;
        }
        /// <summary>
        /// Calculates the change 
        /// </summary>
        /// <param name="change"></param>
        /// <returns>double change</returns>
        /// <exception cref="Exception">Costumer cant have less than the price</exception>
        public double CalculateChange(double change)
        {


            if (CostumerMoney < productlist.Sum())
            {
                throw new Exception("Der Kunde hat zu wenig Geld");
            }
            change = CostumerMoney - productlist.Sum();
            return change;

        }
        /// <summary>
        /// Calculates the Sum of the productlist.
        /// </summary>
        /// <returns>productlist.Sum</returns>
        public double CalculateSum()
        {


            return productlist.Sum();
        }
       




    }
}