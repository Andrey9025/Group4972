﻿Console.WriteLine("Write num:");
int num = int.Parse(Console.ReadLine()??"0");
if(num >100&&num<1000)
{
    int lastDigit = num%10;
     Console.WriteLine("Последняя цифра числа" + "num" + "это" + lastDigit);
}
else 
{
    Console.WriteLine("Число не трехзначное");
}