// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World! Temir");

// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Введите ваше имя");
// string username = Console.ReadLine();
// Console.Write("Привет ");
// Console.Write(username);

// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.Write("Введите первое число: ");
//  int fNumber = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите второе число: ");
//  int sNumber = Convert.ToInt32(Console.ReadLine());

// int max = 0;
// int min = 0;

// if(fNumber > sNumber)
// {
//     max = fNumber;
//     min = sNumber;
// }
// else
// {
//     max = sNumber;
//     min = fNumber;
// }
// Console.WriteLine("Число = " + max + " больше чем " + "Число = " + min);
//////////////////////////////////////////////////////////////////////////////////////////////////////////

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Console.Write("Введите первое число:");
//     int fNumber = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите второе число:");
//     int sNumber = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите третье число:");
//     int tNumber = Convert.ToInt32(Console.ReadLine());

// int max = 0;

// if (fNumber > max) {
//     max = fNumber;
// }
// if (sNumber > max) {
//     max = sNumber;
// }
// if (tNumber > max) {
//     max = tNumber;
// }

// Console.WriteLine("Самое большое число: = " + max);
//////////////////////////////////////////////////////////////////////////////////////////////////////////

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//  4 -> да
// -3 -> нет
//  7 -> нет

// Console.Write("Введите числа четно ли:");
//     int number = Convert.ToInt32(Console.ReadLine());

// int chet = number % 2;

// if(chet == 0) {
//     Console.WriteLine("Делиться");
// }
//     else {
//         Console.WriteLine("Не делиться");
// }
//////////////////////////////////////////////////////////////////////////////////////////////////////////

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int chetNumber = 2;
if(number > 1)
{
while(chetNumber <= number)
    {
    Console.Write(chetNumber + " ");
    chetNumber = chetNumber + 2;
    }
}
//////////////////////////////////////////////////////////////////////////////////////////////////////////