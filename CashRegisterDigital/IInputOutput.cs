using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashRegisterDigital
{
    public interface IInputOutput
    {
        void CashRegisterWelcome();
        double ProductsInput();
        double ProductsOutput(double products);

        double CostumerMoneyInput();

        double CostumerChangeOutput(double costumerMoney);
        void ReceiptShow();
    }
}