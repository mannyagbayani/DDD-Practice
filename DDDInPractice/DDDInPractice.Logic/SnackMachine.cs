using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDInPractice.Logic
{
    /// <summary>
    /// the sealed modifier prevents other classes from inheriting from it.
    /// </summary>
    public sealed class SnackMachine:Entity
    {
        public Money MoneyInside { get; private set; }
        public Money MoneyInTransaction { get; private set; }


        public void InsertMoney(Money money)
        {
            MoneyInTransaction += money;
        }

        public void ReturnMoney()
        {
           // MoneyInTransaction = 0;
        }

        public void BuySnack()
        {
            MoneyInside += MoneyInTransaction;
            MoneyInTransaction = Money.None;
        }

        public SnackMachine()
        {
            MoneyInside = Money.None;
            MoneyInTransaction = Money.None;
        }
    }
}
