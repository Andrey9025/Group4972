Console.WriteLine("Write number 1:");
int numa = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Write number 2:");
int numb = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Write number 3:");
int numc = int.Parse(Console.ReadLine() ?? "0");

int max = numa;
if (max < numb) 
{
    max = numb;
} 
if (max < numc) 
{
    max = numc;
}
 Console.WriteLine("Maximum =" + max);
