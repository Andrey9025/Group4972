using System.Threading.Tasks.Dataflow;

Console.WriteLine("Write number: ");
//Считываем данные с консоли
string? inputNum = Console.ReadLine();//??"0";
//Проверяем, чтобы данные были не пустыми
if (inputNum != null)
{
    //     Парсим введеное число
    //     int num = int.Parse(inputNum);
    //     Находим квадрат числа
    //     int res = num*num;
    //     Вводим данные в консоль
    //    Console.WriteLine(res);

    Console.WriteLine("Квадрат числа: " + (int)Math.Pow(int.Parse(inputNum), 2));
}

