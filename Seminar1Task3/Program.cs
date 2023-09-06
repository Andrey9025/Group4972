int day = int.Parse(Console.ReadLine() ?? "0");

string[] dayOfWeek = new string[7];

dayOfWeek[0] = "Monday";
dayOfWeek[1] = "Tuesday";
dayOfWeek[2] = "Wednesday";
dayOfWeek[3] = "Thursday";
dayOfWeek[4] = "Friday";
dayOfWeek[5] = "Saturday";
dayOfWeek[6] = "Sunday";

Console.WriteLine(dayOfWeek[day - 1]);
