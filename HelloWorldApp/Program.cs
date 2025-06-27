// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Learning C# is fun!");
Console.WriteLine("Let's Build awesome Apps!");


// int age = 25;
// string name = "Benja";
// bool isLearning = true;

Console.Write("What is Your Name?");
string? inputName = Console.ReadLine();
string name = inputName ?? string.Empty;

Console.Write("How old are you?");
int age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Hello {name}, you are {age} years old.");