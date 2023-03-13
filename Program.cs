using CurrencyChange;

decimal money = 50.74m;
string moneySignature = "USD";

Currency currency = new();

currency.ChangeToEuro(ref money,ref moneySignature);

currency.ChangeToUSD(ref money,ref moneySignature);