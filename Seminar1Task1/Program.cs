Console.WriteLine("Write number 1:");
int num1 = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Write number 2:");
int num2 = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine(num1 == Math.Pow(num2, 2) ? "yes" : "no");

// <условие> ? <вариант1>:<вариант2>
//if (num1 == Math.Pow(num2, 2))
//{
 //   Console.WriteLine("yes");
//}
//else
//{
//    Console.WriteLine("no");
//}
