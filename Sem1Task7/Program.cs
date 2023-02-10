// Задача №7
// Напишите программу, которая принимает на вход трёхзначное число
//  и на выходе показывает последнюю цифру этого числа.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 && number <1000)
{
    Console.WriteLine("Последняя цифра числа: "+number%10);
}
else
Console.WriteLine("Введено не то число");