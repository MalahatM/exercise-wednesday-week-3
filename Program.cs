// Currency Converter uppgift

// Create an object from CurrencyConverter class
CurrencyConverter converter = new CurrencyConverter();

// Ask the user for an amount in SEK
Console.WriteLine("Enter amount in SEK:");
double sekAmount = double.Parse(Console.ReadLine()!);

// Show available currencies
Console.WriteLine("Choose a currency:");
Console.WriteLine("EUR");
Console.WriteLine("GBP");
Console.WriteLine("JPY");
Console.WriteLine("USD");

// Read the user's currency choice
string currency = Console.ReadLine()!.ToUpper();

// Convert the currency
double convertedAmount = converter.ConvertCurrency(sekAmount, currency);

// Show the result
Console.WriteLine($"Converted amount: {convertedAmount} {currency}");