// See https://aka.ms/new-console-template for more information
Console.WriteLine("What is your name?");
var name = Console.ReadLine();

Console.WriteLine("What is your Favorite color");
var Color = Console.ReadLine();

Console.WriteLine("What is your favorite Animal");
var Animal = Console.ReadLine();

Console.WriteLine("What is your favorite Band");
var Band = Console.ReadLine();

Console.WriteLine($" One day {name} was walking through the woods when a {Color} {Animal} appeared out of no where listening to {Band}");
Console.WriteLine();

Console.WriteLine("give me a number to add");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("give me a number to add to the first one");
int num2 = int.Parse(Console.ReadLine());

int sum = num1 + num2;
Console.WriteLine($"The sum is {sum}");

Console.WriteLine("Give me a number to multiply");
 num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Give me a number to multiply to the first one");
 num2 = int.Parse(Console.ReadLine());

int product = Multiply(num1, num2);
Console.WriteLine($" The product is {product}");


static int Sum(params int[] list);

int Sum = 0;

 for(int i = 0; i < list.Length; i++) ;

 var Sum = Sum + list[i];


//int Sum = num1 + num2;
//return sum;
return num1 + num2;

public static int Multiply(int num1, int num2);

return x * y;