using LINQDemoCSharp_45;
using System.Linq;

Console.WriteLine("int collections:");

var numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//Filtering with LINQ
var numsAboveFive = numbers.Where(number => number > 5).ToList();

numsAboveFive.ForEach(number => Console.WriteLine(number));

//Filter
var evenNumbers = numbers.Where(number => number % 2 == 0).ToList();

foreach (var number in evenNumbers)
{
    Console.WriteLine(number);
}

Console.WriteLine();

//Sum method
Console.WriteLine($"Sum: {numbers.Sum()}");

//Average method
Console.WriteLine($"Average: {numbers.Average()}");

//Min and Max method
Console.WriteLine($"Min: {numbers.Min()} Max: {numbers.Max()}");

Console.WriteLine();

//Transforming with LINQ
var squaredNumbers = numbers.Select(number => number * number);

foreach(var number in squaredNumbers)
{
    Console.WriteLine(number);
}

Console.WriteLine();
Console.WriteLine("string collections:");

var names = new string[] { "Alex", "Bryan", "Greg", "Jayson", "Muzammel", "Richard", "William", "Seth", "Mack"};

//Filtering with LINQ
var longerNames = names.Where(name => name.Length > 4).ToArray();

foreach(var name in longerNames)
{
    Console.WriteLine(name);
}

Console.WriteLine();

//Transforming with LINQ
var upperCaseNames = names.Select(name => name.ToUpper()).ToArray();

foreach (var name in upperCaseNames)
{
    Console.WriteLine(name);
}

//Sorting (ordering) with LINQ

Console.WriteLine();

var orderedName = names.OrderBy(name => name.Length).ToArray();

foreach (var name in orderedName)
{
    Console.WriteLine(name);
}

Console.WriteLine();

var dog1 = new Dog() { Name = "Bingo", Age = 5 };
var dog2 = new Dog() { Name = "Marmaduke", Age = 3 };
var dog3 = new Dog() { Name = "Marmaduke", Age = 1};

var dogPark = new List<Dog>() { dog1, dog2, dog3 };

var orderedDogs = dogPark.OrderBy(dog => dog.Name).ThenBy(dog => dog.Age);

foreach (var dog in orderedDogs)
{
    Console.WriteLine($"Name: {dog.Name} Age: {dog.Age}");
}