int Prompt(string msg)
{

System.Console.WriteLine($"{msg}");
return Convert.ToInt32(Console.ReadLine());
}
int number = Prompt("Write number");
if (number >=100 && number <1000)
{
    int mid = (number % 100 - number % 10) / 10;
    System.Console.WriteLine($"cesond number {number} is {mid}");
}
else
System.Console.WriteLine("this number is not three-digit");