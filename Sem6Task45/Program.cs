// Метод, генерирующий массив
int[] GenArray(int len, int minValue, int maxValue)
{
    int[] arr = new int[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue + 1);
    }
    return arr;
}

//Метод, выводящий на печать массив
void Print1DArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

int[] CopyArrayStandartTools(int[] inputArr)
{
    int[] outArr = new int[inputArr.Length];
    inputArr.CopyTo(outArr,0);
    return outArr;
}

int[] testArr = GenArray(40,1,50);
Print1DArr(testArr);
int[] testArrNew = CopyArrayStandartTools(testArr);
Print1DArr(testArrNew);
