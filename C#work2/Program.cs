
// int Max(int arg1, int arg2, int arg3) {
//     int result = arg1;
//     if (arg2 > result) result = arg2;
//     if (arg3 > result) result = arg3;
//     return result;
// }

// int a1 = 155555;
// int b1 = 12;
// int c1 = 999;
// int a2 = 77;
// int b2 = 66;
// int c2 = 55;
// int a3 = 44;
// int b3 = 33;
// int c3 = 222;

// // int max1 = Max (a1, b1, c1);
// // int max2 = Max (a2, b2, c2);
// // int max3 = Max (a3, b3, c3);
// // int max = Max (max1, max2, max3);

// int max = Max(
//     Max (a1, b1, c1),
//     Max (a2, b2, c2),
//     Max (a3, b3, c3));

// Console.WriteLine(max);



// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.Clear();
// Console.WriteLine("Задача 10 ");
// Console.Write("Введи трёхзначное число: ");
// int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
// string stringNumber = Convert.ToString(threeDigitNumber);
// Console.WriteLine("вторая цифра этого числа -> "+stringNumber[1]);

// Console.WriteLine("Ввести трёхзначное число: ");
// int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
// string stringNumber = Convert.ToString(threeDigitNumber);
// Console.WriteLine("вторая цифра этого числа -> "+stringNumber[1]);

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

