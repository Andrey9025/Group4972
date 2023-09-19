int Prompt(string msg)
{

System.Console.WriteLine($"{msg}");
return Convert.ToInt32(Console.ReadLine());
}
int number = Prompt("Write number");
string ss = "It's not a day of the week";
string check(int number)
{
if (number >= 6 && number < 8) ss = "It's a day off";
if (number >= 1 && number < 7) ss = " it's a weekday";
return ss;
}
System.Console.WriteLine(check(number));