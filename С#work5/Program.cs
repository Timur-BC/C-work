// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


// Console.Write("Ввести число: ");
// int anyNumber = Convert.ToInt32(Console.ReadLine());
// string anyNumberText = Convert.ToString(anyNumber);
// if (anyNumberText.Length > 2){
//   Console.WriteLine("Третья цифра --> " + anyNumberText[2]);
// }
// else {
//   Console.WriteLine("-> третьей цифры нет(");
// }


//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


// Console.Write("Введи цифру, день недели: ");
// int dayNum = Convert.ToInt32(Console.ReadLine());

// void CheckDayWeek (int dayNum) {
//   if (dayNum == 6 || dayNum == 7) {
//   Console.WriteLine("Выходной -> да");
//   }
//   else if (dayNum < 1 || dayNum > 7) {
//     Console.WriteLine("Не вверный ввод");
//   }
//   else Console.WriteLine("Рабочий день -> нет");
// }

// CheckDayWeek(dayNum);


// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// int ReadInt(string text)
// {
//     System.Console.Write(text);
//     return Math.Abs(Convert.ToInt32(Console.ReadLine()));
// }

// int CountNumbers(int N)
// {
//     int count = 0;

//     if (N == 0)
//     {
//         return 1;
//     }

//     while (N > 0)
//     {
//         N /= 10; // number = number / 10
//         count++;
//     }

//     return count;
// }

// // -----------------------------------------------------------------------

// int count = CountNumbers(ReadInt("Введите число: "));
// System.Console.WriteLine($"Количество цифр в числе -> {count}");


// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120


// int ReadInt(string text)
// {
//     System.Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }
// int Result(int N)
// {
//     int factorial = 1;
//     for(int i=1; i<=N; i++)
//     {
//         factorial=factorial*i;
//     }
//     return factorial;
// }

// int number = ReadInt("Введите число: ");
// int result = Result(number);
// System.Console.WriteLine(result);

// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]
//-----------------------------------------------
// int[] array = new int [8];
// Random rand = new Random();

// for(int i = 0; i < 8; i++)
// {
//     array[i] = rand.Next(0, 2);
// }
// System.Console.WriteLine(string.Join(" ", array));

// void FillArray(int[] arr)
// {
//     Random rand = new Random();

//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = rand.Next(0, 2);
//     }
// }

// void PrintArray(int[] arr)
// {
//     System.Console.WriteLine(string.Join(" ", arr));
// }

// int ReadInt(string text) // string, int[], string[], bool, void
// {
//     System.Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

// // ------------------------------------------------------

// int sizeArray = ReadInt("Введите размер массива: ");
// int[] array = new int[sizeArray];
// FillArray(array);
// PrintArray(array);


// int ReadInt()
// {
//     System.Console.WriteLine("Enter a:");
//     return Convert.ToInt32(System.Console.ReadLine());
// }

// void NumberToBinary(int number)
// {
//     if (number == 0)
//     {
//         return;
//     }
//     NumberToBinary(number / 2);
//     System.Console.Write(number % 2);
// }

// Console.Clear();
// int a = ReadInt();
// NumberToBinary(a);

// ------------------------------------------------------



// Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, 
// а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]


// void Main()
// {
//     int[] array = FillArray(7, 0, 10);  // Сгенерировали массив
//     PrintArray(array);                  // Вывели исходный массив
//     ReverseArray(array);                // Развернули массив при помощи нашей функции
//     PrintArray(array);                  // Вывели массив
//     Array.Reverse(array);               // Развернули массив при помощи встроенной функции
//     PrintArray(array);                  // Вывели массив
// }

// void ReverseArray(int[] arrayToReverse)
// {
//     // Создали временную переменную для хранения промежуточных значений
//     int temp = 0; 
    
//     // Запустили цикл, который проходит по нашему массиву (количество итераций равно половине длины массива)
//     for (int i = 0; i < arrayToReverse.Length / 2; i++)
//     {
//         // Сохранили в временную переменную значение, которое стояло в начале массива (для того, чтобы оно не потерялось)
//         temp = arrayToReverse[i]; 

//         // Поменяли значение элемента массива, которое стояло в начале, на значение, которое стояло в конце
//         arrayToReverse[i] = arrayToReverse[arrayToReverse.Length - 1 - i]; 

//         // Поменяли значение элемента массива, которое стояло в конце, на значение, которое хранилось во временной переменной
//         arrayToReverse[arrayToReverse.Length - 1 - i] = temp; 
//     }
// }

// int[] FillArray(int size = 5, int leftRange = 0, int rightRange = 20)
// {
//     int[] tempArray = new int[size];
//     Random rand = new Random();

//     for (int i = 0; i < tempArray.Length; i++)
//     {
//         tempArray[i] = rand.Next(leftRange, rightRange + 1);
//     }

//     return tempArray;
// }

// void PrintArray(int[] arrayForPrint)
// {
//     System.Console.WriteLine("[" + string.Join(", ", arrayForPrint) + "]");
// }

// Main();

