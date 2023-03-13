using CurrencyChange;

decimal money = 50.74m;
string moneySignature = "USD";
string result;

Currency currency = new();

currency.ChangeToEuro(ref money,ref moneySignature,out result);
Console.WriteLine(result);

currency.ChangeToUSD(ref money,ref moneySignature);