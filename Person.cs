// Person class
class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string FavoriteColor { get; set; }

    public void ReadInfo()
    {
        Console.WriteLine("Enter your name:");
        Name = Console.ReadLine()!;

        Console.WriteLine("Enter your age:");
        Age = int.Parse(Console.ReadLine()!);

        Console.WriteLine("Enter your favorite color:");
        FavoriteColor = Console.ReadLine()!;
    }

    public void Introduce()
    {
        Console.WriteLine(
            $"Hi, my name is {Name}. I am {Age} years old and my favorite color is {FavoriteColor}."
        );
    }
}