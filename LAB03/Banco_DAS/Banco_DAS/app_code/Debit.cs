using System;
using System.Collections.Generic;
using System.Text;

namespace Banco_DAS.app_code
{
    class Debit : Account
    {
        ///<summary>
        ///La variable cash es el dinero que tiene la cuenta.
        ///</summary>
        public decimal sell(decimal balance)
        {
            Console.WriteLine("Escribe la cantidad de dinero que deseas retirar acontinuación:\n");
            try
            {
                string money = Console.ReadLine();
                decimal withdrawal = decimal.Parse(money);
                Console.WriteLine("Se esta verificando los fondos.");
                decimal cash = (balance - withdrawal);
                if (cash >= 0)
                {
                    return cash;
                }
                else
                {
                    return -1;
                }
            }catch (NullReferenceException e)
            {
                return -2;
            }
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
