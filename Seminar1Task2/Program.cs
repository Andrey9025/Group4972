Console.WriteLine("Write number 1:");
int num1 = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Write number 2:");
int num2 = int.Parse(Console.ReadLine() ?? "0");

if (num1 > num2)
{
    Console.WriteLine("num1 = " + num1+ " " +"num2 = "+num2 + " max = "+ num1);
}

if (num1 < num2)
{
    Console.WriteLine("num1 = "+ num1+ " " + "num2 = "+num2 + " max = " + num2);
}
 