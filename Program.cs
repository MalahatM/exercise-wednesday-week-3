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

// Uppgift 2 - Password Strength Checker

Console.Write("Enter a password: ");
string password = Console.ReadLine()!;

bool hasEnoughLength = false;
bool hasUppercase = false;
bool hasLowercase = false;
bool hasNumber = false;
bool hasSpecialCharacter = false;


// Check the password length
if (password.Length >= 8)
{
    hasEnoughLength = true;
}


// Check each character in the password
foreach (char c in password)
{
    // Check for uppercase letter
    if (char.IsUpper(c))
    {
        hasUppercase = true;
    }

    // Check for lowercase letter
    if (char.IsLower(c))
    {
        hasLowercase = true;
    }

    // Check for number
    if (char.IsDigit(c))
    {
        hasNumber = true;
    }

    // Check for special character
    if (!char.IsLetterOrDigit(c))
    {
        hasSpecialCharacter = true;
    }
}


// Check the password strength
if (hasEnoughLength &&
    hasUppercase &&
    hasLowercase &&
    hasNumber &&
    hasSpecialCharacter)
{
    Console.WriteLine("The password is Strong.");
}
else if (hasEnoughLength &&
         hasUppercase &&
         hasLowercase &&
         (hasNumber || hasSpecialCharacter))
{
    Console.WriteLine("The password is Moderate.");
}
else
{
    Console.WriteLine("The password is Weak.");
}
//uppgift 3
Person person1 = new Person();
person1.ReadInfo();
person1.Introduce();

Person person2 = new Person();
person2.ReadInfo();
person2.Introduce();