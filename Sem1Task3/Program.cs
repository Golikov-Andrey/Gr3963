// Задача №3
// Напишите программу, 
// которая будет выдавать название дня недели по заданному номеру.

// Console.Write("Введите число");
// var day = Convert.ToInt32(Console.ReadLine());

// // if (day > 7)
// // {
// //     day = day % 7;
// // }
// if (day > 0 && day < 8)
// {
//     string[] dayWeek = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота" };
//     Console.WriteLine(dayWeek[day - 1]);
// }
// else
// {
//     Console.WriteLine("Вы ввели не день недели!");
// }

// //Задача №3
// //Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// Console.Write("Введите номер дня недели: ");
// string? lineDay = Console.ReadLine();
// if (lineDay != null)
// {
//     int day = int.Parse(lineDay);
//     // string[] dayWeek = new string[7];
//     // dayWeek[0] = "Понедельник";
//     // dayWeek[1] = "Вторник";
//     // dayWeek[2] = "Среда";
//     // dayWeek[3] = "Четверг";
//     // dayWeek[4] = "Пятница";
//     // dayWeek[5] = "Суббота";
//     // dayWeek[6] = "Воскресенье";  
//     //Console.WriteLine(dayWeek[day - 1]);

//     string outDayOfWeek = System.Globalization.CultureInfo.GetCultureInfo("ru-Ru").DateTimeFormat.GetDayName((DayOfWeek)Enum.GetValues(typeof(DayOfWeek)).GetValue(day));
//     Console.WriteLine(outDayOfWeek);
// }

Console.WriteLine("Введите день недели: ");
string? inputNum1 = Console.ReadLine();

if ( int.Parse(inputNum1) >= 0 && int.Parse(inputNum1) < 7)
{
    switch (inputNum1)
    {
        case "0":
            Console.WriteLine("пн ");
            break;
        case "1":
            Console.WriteLine("вт ");
            break;
        case "2":
            Console.WriteLine("ср ");
            break;
        case "3":
            Console.WriteLine("чт ");
            break;
        case "4":
            Console.WriteLine("пт ");
            break;
        case "5":
            Console.WriteLine("сб ");
            break;
        case "6":
            Console.WriteLine("вс ");
            break;
        default:
        Console.WriteLine("Вы ввели не день недели!");
        break;


    }
}