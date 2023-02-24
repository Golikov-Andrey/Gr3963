// Задача №32
// Напишите программу замена элементов массива: положительные элементы замените
//  на соответствующие отрицательные, и наоборот.

// //forms 1D array of length 'len' with random values <-> min & max
// int[] Gen1DArr(int len, int min, int max)
// {
//     if (min > max) //to ensure 
//     {
//         int temp = min; min = max;
//         max = temp;
//     }
//     int[] arr = new int[len];
//     for (int i = 0; i < len; i++) arr[i] = new Random().Next(min, max + 1);
//     return arr;
// }  
// //prints 1D array into consle
// void Print1DArr(int[] arr)
// {
//     Console.Write("[");
//     for (int i = 0; i < arr.Length - 1; i++) Console.Write($"{arr[i]}, ");
//     Console.WriteLine($"{arr[arr.Length - 1]}]");
// }

// void InvertArr(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     { 
//         arr[i] = -arr[i]; 
//     }
// }

// int[] testArr = Gen1DArr(12, -9, 9);
// Print1DArr(testArr);
// InvertArr(testArr);
// Print1DArr(testArr);


// void PrintData(string text, int print)
// {
//     Console.WriteLine($"{text}:{print}");
// }

// int[] Gen1DArry(int min, int max, int indexcount)
// {
//     int buf;
//     if (min > max)
//     {
//         buf = min;
//         min = max;
//         max = buf;
//     }
//     int[] binarray = new int[indexcount];
//     System.Random numSintezator = new System.Random();
//     for (int i = 0; i < indexcount; i++)
//     {
//         binarray[i] = numSintezator.Next(min, max);
//     }
//     return binarray;
// }

// void  InversArray(int [] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i]*=-1;
//     }

// }

// void Print10Arry(int[] array)
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         Console.Write($"{array[i]},");
//     }
//     Console.WriteLine($"{array[array.Length - 1]}]");
// }

// int[] array = Gen1DArry(-9, 9, 12);

// Print10Arry(array);
// InversArray(array);
// Print10Arry(array);

/*
Задача №32
Напишите программу замена элементов массива: положительные элементы замените 
на соответствующие отрицательные, и наоборот.
*/

Console.Clear();

int[] Gen1DArr(int len, int min, int max)
{
    // Корректировка входных данных
    if (min > max)
    {
        int buf = min;
        min = max;
        max = buf;
    }

    Random rnd = new Random();
    int[] arr = new int[len];

    for (int i = 0; i < len; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }

    return arr;
}

void Print1DArr(int[] arr)
{
    Console.Write("[");

    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]},\t");
    }
    Console.WriteLine($"{arr[arr.Length - 1]}]");
}

//Метод для вывода данных
void WriteMess(string mess)
{
    Console.WriteLine(mess);
}

void InversArr(int[] arr)
{
    for (int i = 0; i < arr.Length ; i++)
    {
        arr[i] = arr[i]*-1;
    }
}


int[] mass = Gen1DArr(12, -9, 9);
Print1DArr(mass);
InversArr(mass);
Print1DArr(mass);