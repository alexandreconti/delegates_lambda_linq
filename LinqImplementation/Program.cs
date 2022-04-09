Console.WriteLine("Hello, World!");

// Specify the data souce
int[] numbers = new int[] { 2, 3, 4, 5 };

// Define the query expression
var result = numbers
    .Where(x => x % 2 == 0)
    .Select(x => x * 2);

// Execute the query
foreach (int number in result)
{
    Console.WriteLine(number);
}
