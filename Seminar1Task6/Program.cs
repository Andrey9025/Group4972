Console.WriteLine("Write number");
int a = int.Parse(Console.ReadLine()??"0");
if (a % 2 == 0)
{
    Console.WriteLine(a + " even " + "delete");
}
else 
{
    Console.WriteLine(a + " not even " + " not delete");
    }