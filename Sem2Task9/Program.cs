
System.Random numSintezator = new System.Random();

//Вариант 1
int rndNumber = numSintezator.Next(10, 100);
Console.WriteLine(rndNumber);
int firstNum = rndNumber / 10;
int secondNum = rndNumber % 10;

if (firstNum > secondNum)
{
    Console.WriteLine("Первое число больше " + firstNum + " второго " + secondNum);
}
else
{
    Console.WriteLine(secondNum);
}

//Вариант 2
char[] digits = numSintezator.Next(10,100).ToString().ToCharArray();
Console.WriteLine(digits);
int firstNumber = ((int)digits[0])-48;
int secondNumber = ((int)digits[1])-48;

//<переменная> = (условие)?<значение1>:<значение2>;
//if(условие)
// {
//     <переменная> = <значение1>;
// }
// else
// {
//    <переменная> = <значение2>;
// }

int resultNumber = (firstNumber>secondNumber)?resultNumber=firstNumber:resultNumber=secondNumber;
Console.WriteLine(resultNumber);

//Вариант 3
int rndNumberArr = numSintezator.Next(10, 100);
Console.WriteLine(rndNumberArr);
int[] indxAnsw = new int[90];
indxAnsw[0] = 1;indxAnsw[1] = 1;indxAnsw[2] = 2;indxAnsw[3] = 3;indxAnsw[4] = 4;indxAnsw[5] = 5;indxAnsw[6] = 6;indxAnsw[7] = 7;indxAnsw[8] = 8;indxAnsw[9] = 9;
indxAnsw[10] = 2;indxAnsw[11] = 2;indxAnsw[12] = 2;indxAnsw[13] = 3;indxAnsw[14] = 4;indxAnsw[15] = 5;indxAnsw[16] = 6;indxAnsw[17] = 7;indxAnsw[18] = 8;indxAnsw[19] = 9;
indxAnsw[20] = 3;indxAnsw[21] = 3;indxAnsw[22] = 3;indxAnsw[23] = 3;indxAnsw[24] = 4;indxAnsw[25] = 5;indxAnsw[26] = 6;indxAnsw[27] = 7;indxAnsw[28] = 8;indxAnsw[29] = 9;
indxAnsw[30] = 4;indxAnsw[31] = 4;indxAnsw[32] = 4;indxAnsw[33] = 4;indxAnsw[34] = 4;indxAnsw[35] = 5;indxAnsw[36] = 6;indxAnsw[37] = 7;indxAnsw[38] = 8;indxAnsw[39] = 9;
indxAnsw[40] = 5;indxAnsw[41] = 5;indxAnsw[42] = 5;indxAnsw[43] = 5;indxAnsw[44] = 5;indxAnsw[45] = 5;indxAnsw[46] = 6;indxAnsw[47] = 7;indxAnsw[48] = 8;indxAnsw[49] = 9;
indxAnsw[50] = 6;indxAnsw[51] = 6;indxAnsw[52] = 6;indxAnsw[53] = 6;indxAnsw[54] = 6;indxAnsw[55] = 6;indxAnsw[56] = 6;indxAnsw[57] = 7;indxAnsw[58] = 8;indxAnsw[59] = 9;
indxAnsw[60] = 7;indxAnsw[61] = 7;indxAnsw[62] = 7;indxAnsw[63] = 7;indxAnsw[64] = 7;indxAnsw[65] = 7;indxAnsw[66] = 7;indxAnsw[67] = 7;indxAnsw[68] = 8;indxAnsw[69] = 9;
indxAnsw[70] = 8;indxAnsw[71] = 8;indxAnsw[72] = 8;indxAnsw[73] = 8;indxAnsw[74] = 8;indxAnsw[75] = 8;indxAnsw[76] = 8;indxAnsw[77] = 8;indxAnsw[78] = 8;indxAnsw[79] = 9;
indxAnsw[80] = 9;indxAnsw[81] = 9;indxAnsw[82] = 9;indxAnsw[83] = 9;indxAnsw[84] = 9;indxAnsw[85] = 9;indxAnsw[86] = 9;indxAnsw[87] = 9;indxAnsw[88] = 9;indxAnsw[89] = 9;

// Выводим данные в консоль 
Console.WriteLine(indxAnsw[rndNumberArr-10]);