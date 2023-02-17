//Задача №20
//Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 2D пространстве.

// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}

//Метод выводит данные пользователю
void PrintData(string msg, double val)
{
    Console.WriteLine(msg+val);
}

//Метод находит расстояние между точками на плоскости
double CalcLen2D(int x1, int x2, int y1, int y2)
{
    //return Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2));
    return Math.Sqrt(Math.Pow((x2 - x1),2) + Math.Pow((y2 - y1),2));
}

int x1 = ReadData("Введите координату x точки A: ");
int y1 = ReadData("Введите координату y точки A: ");
int x2 = ReadData("Введите координату x точки B: ");
int y2 = ReadData("Введите координату y точки B: ");

double res = CalcLen2D(x1,x2,y1,y2);

PrintData("Растояние между точками A и B: ", res);