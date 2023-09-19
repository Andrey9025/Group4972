int Prompt(string msg)
{

System.Console.WriteLine($"{msg}");
return Convert.ToInt32(Console.ReadLine());
}
int number = Prompt("Write number");

int fnumber(int number)
{
while (number > 999)
{
number /= 10;
}
return number % 10;
}

bool check(int number)
{
if (number < 100)
return false;
else return true;
}

if (check(number) != true)
System.Console.WriteLine("there is no third digit");
else
System.Console.WriteLine($"the third digit {number} is {fnumber(number)}");