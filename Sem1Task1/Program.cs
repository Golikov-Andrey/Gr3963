// //ввод числа №1
// Console.Write("Введите число №1: ");
// string? numLine1 = Console.ReadLine();
// //ввод числа №2
// Console.Write("Введите число №1: ");
// string? numLine2 = Console.ReadLine();
// if (numLine1 != null && numLine2 != null)
// {
//     //Convert to int
//     int num1 = int.Parse(numLine1);
//     int num2 = int.Parse(numLine2);
//     if (num2 * num2 == num1)
//     {
//         Console.WriteLine("Да, является!");
//     }
//     else
//     {
//         Console.WriteLine("Нет, не является!");
//     }
// }
// Console.Write("Введите первое число: ");
// string? numLine1 = Console.ReadLine();
// Console.Write("Введите второе число: ");
// string? numLine2 = Console.ReadLine();

// if(numLine1 != null && numLine2 != null)
// {
//     int num1 = int.Parse(numLine1);
//     int num2 = int.Parse(numLine2);

//     if(num1 == (int)Math.Pow(num2, 2))
//     {
//         Console.WriteLine("Первое число - квадрат второго!");
//     }
//     else
//     {
//         Console.WriteLine("Первое число - не квадрат второго!");
//     }
// }

// Задача №1
// Напишите программу, которая на вход принимает два числа и проверяет, 
// является ли первое число квадратом второго.

Console.Write("Введите 1 число: ");
var number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2 число: ");
var number2 = Convert.ToInt32(Console.ReadLine());

if (number1 == Math.Pow(number2, 2))
    Console.WriteLine($"Число {number1} является квадратом числа {number2}");
else
    Console.WriteLine($"Число {number1} НЕ является квадратом числа {number2}");