using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyChange
{
    public class Currency
    {
        void PrintOldCurrency(ref decimal currency, ref string currencyName) => Console.WriteLine("Old Currency From: " + currency + " " + currencyName);

        public void ChangeToEuro(ref decimal currency,ref string signature)
        {

            PrintOldCurrency(ref currency, ref signature);

            if (signature.Equals("USD")) //From USD
            {
                currency *= 0.93m;
            }
            else if(signature.Equals("JPY")) //FROM JAPANESE YEN
            {
                currency *= 0.007m;
            }

            signature = "EURO";

            Console.WriteLine("Current Currency : " + currency + " " + signature);
            Console.WriteLine();
        }

        public void ChangeToUSD(ref decimal currency,ref string signature)
        {
            PrintOldCurrency(ref currency, ref signature);

            if (signature.Equals("EURO")) //From EURO
            {
                currency *= 1.07m;
            }
            else if (signature.Equals("JPY")) //FROM JAPANESE YEN
            {
                currency *= 0.0075m;
            }

            signature = "USD";

            Console.WriteLine("Current Currency : " + currency + " " + signature);
            Console.WriteLine();
        }
    }
}
