//Мария
Console.WriteLine(" Мария Введите число");
int num = int.Parse(Console.ReadLine() ?? "0");

if (num % 7 == 0 && num % 23 == 0)
{
    Console.WriteLine("Кратно");
}
else
{
    Console.WriteLine("Не кратно");
}

//Григорий
Console.WriteLine("Григорий Введите число: ");
int firstNumber = int.Parse(Console.ReadLine() ?? "0");


int rem1 = firstNumber % 23;
int rem2 = firstNumber % 7;

if (rem1 == 0 && rem2 == 0)
{
    Console.WriteLine("Кратно");
}
else
{

    Console.WriteLine("Не кратно");
}

// Владимир Задача №14
// Напишите программу, которая принимает на вход число и проверяет, 
// кратно ли оно одновременно 7 и 23.

Console.Write("Владимир Введите первое число: ");
int num = Convert.ToInt32(Console.ReadLine());
if ((num % 7 == 0) && (num % 23 == 0))
{
    Console.WriteLine($"Число {num} кратно 23 и 7");
}
else
{
    Console.WriteLine($"Число {num} не кратно 23 и 7");
}

//Максим
Console.Write("Максим Введите число: ");
int number = int.Parse(Console.ReadLine());

if (number % 7 == 0 && number % 23 == 0)
{
    Console.WriteLine("Число кратно 7 и 23.");
}
else
{
    Console.WriteLine("Число не кратно 7 и 23.");
}


//Михаил
Console.Write("Михаил Введите число - ");
int num = Convert.ToInt32(Console.ReadLine());


if ((num % 23 == 0) && (num % 7 == 0))
{

    Console.WriteLine("Кратно");

}

else
{

    Console.WriteLine("НЕ Кратно");

    Console.WriteLine(num % 23);

    Console.WriteLine(num % 7);

}

//Борис
Console.Write("Борис Введите число: ");
int num1 = int.Parse(Console.ReadLine() ?? "0");
if (num1 % 23 == 0 && num1 % 7 == 0)
{
    Console.WriteLine("Число кратно 7 и 23!");
}
else
{ Console.WriteLine("Число НЕ кратно 23 и 7!"); }


//Илья
Console.WriteLine(" Илья Введите любое число");
int Num1 = int.Parse(Console.ReadLine()??"0");

if ((Num1%7 == 0) && (Num1%23 == 0))
{
    Console.WriteLine("Делится");
}
else
{
    Console.WriteLine("Не делится");
}

//Никита
Console.Write(" Никита Введите число: ");
int num = int.Parse(Console.ReadLine() ?? "0");

if (num % 7 == 0 && num % 23 == 0)
{
    Console.WriteLine($"Число {num} кратно и 7, и 23!");
}
else
{
    if (num % 7 != 0 && num % 23 != 0)
    {
        Console.WriteLine($"Число {num} не кратно ни 7, ни 23");
    }
    else
    {
        if (num % 7 != 0)
        {
            Console.WriteLine($"Число {num} не кратно 7");
        }
        if (num % 23 != 0)
        {
            Console.WriteLine($"Число {num} не кратно 23");
        }
    }
}

//Григорий
Console.WriteLine("Григорий Введите число: ");
int firstNumber = int.Parse(Console.ReadLine()??"0");


int rem1 = firstNumber%23;
int rem2 = firstNumber%7;

if(rem1 == 0 && rem2 == 0)
{
    Console.WriteLine("Кратно");
}else{

    Console.WriteLine("Не кратно");
}

Console.WriteLine("Введите число: ");
int firstNumber = int.Parse(Console.ReadLine()??"0");


int rem1 = firstNumber%23;
int rem2 = firstNumber%7;

string? result = (rem1 == 0 && rem2 == 0) ? "кратно":"Не Кратно";
Console.WriteLine(result);

//Салами
Console.Write("Салами Введите первое число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num % 7 == 0 && num % 23 == 0)
{
    System.Console.WriteLine("Кратно одновременно 7 и 23");
}
else
{
    Console.WriteLine("Не кратно одновременно 7 и 23");
}

//Владимир
Console.Write("Введите первое число: ");
int num = Convert.ToInt32(Console.ReadLine());

bool bNumber = ((num % 7 == 0) && (num % 23 == 0)); 
string res = bNumber? $"Число {num} кратно 23 и 7" : $"Число {num} не кратно 23 и 7";
Console.WriteLine(res);