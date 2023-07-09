//Урок 4. Функции
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// Console.WriteLine($"\nЗадача 25. Возведене числа A в натуральную степень B");

// int Exponentiation(int numberA, int numberB){
//   int result = 1;
//   for(int i=1; i <= numberB; i++){
//     result = result * numberA;
//   }
//     // int result = Math.Pow(numberA, numberB);
//     return result;
// }

//   Console.Write("Введите число A: ");
//   int numberA = Convert.ToInt32(Console.ReadLine());
//   Console.Write("Введите число B: ");
//   int numberB = Convert.ToInt32(Console.ReadLine());

//   int exponentiation = Exponentiation(numberA, numberB);
//   Console.WriteLine("ответ: " + exponentiation);

// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// 1, 2, 3 
// 4, 6, 1 
// 2, 1, 6
// 1 встречается 3 раза 
// 2 встречается 2 раз 
// 3 встречается 1 раз 
// 4 встречается 1 раз 
// 6 встречается 2 раза


// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим 
// следующий массив:
// 9 2 3
// 4 2 4
// 2 6 7


// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

// int ReadInt(string text)
// {
//     System.Console.WriteLine(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

// void Numbers(int M, int N)
// {
//     if (M > N) return;
//     System.Console.Write(M + " ");
//     Numbers(M + 1, N);
// }

// int M = ReadInt("Введите начальное число: ");
// int N = ReadInt("Введите конечное число: ");

// if (M < N)
// {
//     Numbers(M, N);
// }
// else 
// {
//     Numbers(N, M);
// }



// int ReadInt(string text)
// {
//     System.Console.WriteLine(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int SumNumbers(int X)
// {
//     if (X == 0) return 0;
//     return X % 10 + SumNumbers(X / 10);
// }



// int X = ReadInt("Введите число: ");
// System.Console.WriteLine($" Сумма цифр введённого числа равна: {SumNumbers(X)}");


//Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
//A = 3; B = 5 -> 243 (3⁵)
//A = 2; B = 3 -> 8

int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int Power(int X, int Y)
{
    if (Y == 0) return 1;
    return X * Power(X, Y - 1);
}



int X = ReadInt("Введите число: ");
int Y = ReadInt("Введите число: ");
System.Console.WriteLine($"Число {X} в степени {Y}: {Power(X,Y)}");