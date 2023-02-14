//static void Main(string[] args)
//{
Console.WriteLine("Ведите первое число:");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ведите второе число:");
int num2 = int.Parse(Console.ReadLine());
if (num2 % num1 == 0)
{
    Console.WriteLine("Второе число кратно первому.");
}
else
{
    Console.WriteLine("Второе число не кратно первому. Остаток " + (num2 % num1));
}
//}


Console.Write("Введите первое число: ");
int firstNum = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите второе число: ");
int secondNum = int.Parse(Console.ReadLine() ?? "0");

if (firstNum % secondNum == 0)
{
    Console.WriteLine(secondNum + " кратно " + firstNum);

}
else
{
    Console.WriteLine("Остаток от деления = " + (firstNum % secondNum));
}


// Задача №12
// Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. 
// Если второе число некратно первому, то программа выводит остаток от деления.

Console.Write("Введите первое число: ");
 firstNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondtNum = Convert.ToInt32(Console.ReadLine());
int rem = firstNum % secondtNum;
if (rem == 0)
{
    Console.WriteLine($"Число {firstNum} кратно {secondtNum}");
}
else
    Console.WriteLine($"Не кратно. Остаток от деления {firstNum} на {secondtNum} = {rem}");


Console.Write("Введите число №1: ");
 num1 = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число №2: ");
 num2 = int.Parse(Console.ReadLine() ?? "0");
 rem = num1 % num2;
if (rem == 0)
{
    Console.WriteLine("Второе число кратно первому!");
}
else
{
    Console.WriteLine("Второе число не кратно первому, остаток равен: " + rem);
}


Console.WriteLine("введите первое число");
 firstNum = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("введите второе число");
 secondNum = Convert.ToInt32(Console.ReadLine());
 rem = firstNum % secondNum;
if (rem == 0)
{
    Console.WriteLine("кратно");
}
else
{
    Console.WriteLine("не кратно, остаток " + rem);
}

Console.Write("Введите первое число: ");
int fstA = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите второе число: ");
int secA = int.Parse(Console.ReadLine() ?? "0");
if (fstA % secA == 0)
{
    Console.WriteLine("Кратное ");
}
else
{
    Console.WriteLine("Не кратное " + fstA % secA);
}

Console.WriteLine("Введите число1: ");
int firstNumber = int.Parse(Console.ReadLine()??"0");

Console.WriteLine("Введите число2: ");
int lastNumber = int.Parse(Console.ReadLine()??"0");
 rem = firstNumber%lastNumber;

if(rem ==1) { Console.WriteLine("Не кратно"); }

else {Console.WriteLine("Кратно");}


System.Random numSintezator = new System.Random();

int rndNumber1 = numSintezator.Next(1,100);

int rndNumber2 = numSintezator.Next(1,100);

if(rndNumber1%rndNumber2 == 0)

{
    Console.WriteLine("Кратно");
}

else
{
    Console.WriteLine("Не кратно" );
    Console.WriteLine(rndNumber1%rndNumber2);
}



