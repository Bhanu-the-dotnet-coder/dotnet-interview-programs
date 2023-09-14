// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// string msg = Prime.IsPrimeNumbers(7) == true ? "Prime" : "Not a prime";
// Console.WriteLine(msg);

// string name = Reverse.Reversename();
// Console.WriteLine(name);
int Addition = 0;
int Multiplication = 0;
int Subtraction = 0;
int Division = 0;
//While calling the Method, decorate the ref keyword for ref arguments
//Addition, Multiplication, Subtraction, and Division variables values will be updated by Math Function
//ExampleforRefandOut.Math(200, 100, ref Addition, ref Multiplication, ref Subtraction, ref Division);
// Console.WriteLine($"Addition: {Addition}");
// Console.WriteLine($"Multiplication: {Multiplication}");
// Console.WriteLine($"Subtraction: {Subtraction}");
// Console.WriteLine($"Division: {Division}");
Prime p = new Prime();
// Console.WriteLine("enter a value");
// string str = Console.ReadLine();
// p.RemoveDuplicates(str);

Console.WriteLine("Please enter the Search Item :");
int Item = int.Parse(Console.ReadLine());
int[] arr = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
int result = p.BinarySearch(arr, Item);
if (result > 0)
{
    Console.WriteLine($"SearchItem is {Item}  and found at {result}");

}
else
{
    Console.WriteLine($"Data not found");

}








