/*
Задача №37
Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д.
Результат запишите в новом массиве.
*/

// int[] Gen1DArr(int len, int min, int max)
// {
//     // Корректировка входных данных
//     if (min > max)
//     {
//         int buf = min;
//         min = max;
//         max = buf;
//     }

//     Random rnd = new Random();
//     int[] arr = new int[len];

//     for (int i = 0; i < len; i++)
//     {
//         arr[i] = rnd.Next(min, max + 1);
//     }

//     return arr;
// }

// void Print1DArr(int[] arr)
// {
//     Console.Write("[");

//     for (int i = 0; i < arr.Length - 1; i++)
//     {
//         Console.Write($"{arr[i]},\t");
//     }
//     Console.WriteLine($"{arr[arr.Length - 1]}]");
// }

// int[] ConvertArr(int[] arr)
// {

//     int len = arr.Length / 2;
//     if (arr.Length % 2 == 1)
//     {
//         len = len + 1;
//     }


//     int[] mass = new int[len];

//     for (int i = 0; i < len; i++)
//     {
//         mass[i] = arr[i] * arr[len-1 - i];
//     }

//     return mass;
// }

// int[] mass = Gen1DArr(11, -100, 100);
// Print1DArr(mass);

// Print1DArr(ConvertArr(mass));

int[] Gen1DArray(int len, int min, int max)
{
    // Блок корректировки входных данных 
    if(min > max)
    {
        int buf = min;
        min = max;
        max = buf;
    }
    int[] arr = new int[len];
    for(int i = 0; i < len; i++)
    {
        arr[i] = new Random().Next(min, max + 1);
    }
    return arr;
}
void Print1DArray(int[]arr)
{
    Console.Write("[");
    for(int i = 0; i < arr.Length-1; i++)
    {
        Console.Write(arr[i]+", ");    
    }
    Console.Write(arr[arr.Length-1]);
    Console.WriteLine("]");
}

int[] ConvertArr(int[] arr)
{
    int[] bufArr = new int[(arr.Length/2) + 1];
    for(int i = 0; i < ((arr.Length/2)+1); i++)
    {
        bufArr[i] = arr[i]*arr[arr.Length - 1 - i];
    }
    return bufArr;
}


int[] testArr = Gen1DArray(13, 1, 9);
Print1DArray(testArr);
int[] newArr = ConvertArr(testArr);
Print1DArray(newArr);