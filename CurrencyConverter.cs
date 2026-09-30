class CurrencyConverter
{//method to
    public double ConvertCurrency(double sekAmount, string currency)
    {
      switch (currency)
{
    case "EUR":
        return sekAmount * 0.09;

    case "GBP":
        return sekAmount * 0.08;

    case "JPY":
        return sekAmount * 15;

    case "USD":
        return sekAmount * 0.10;

    default:
        return 0;
}
    }
}
