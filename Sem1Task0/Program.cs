// Задача №0
// Напишите программу, которая на вход принимает число и 
// выдаёт его квадрат (число умноженное на само себя).

Console.WriteLine("Введите число: ");
//Считываем данные с консоли
string? inputNum = Console.ReadLine();

//Проверяем, чтобы данные были не пустыми
if (inputNum != null)
{
    //Парсим введенное число
    int number = int.Parse(inputNum);

    //Находим квадрат числа
    //int outNum = number*number;
    int outNum = (int)Math.Pow(number,2);

    // Выводим данные в консоль 
    Console.WriteLine("Квадрат числа: "+outNum);

    //Console.WriteLine("Квадрат числа: "+Math.Pow(int.Parse(inputNum),2));
}