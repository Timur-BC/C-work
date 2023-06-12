
// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8

// Random rand = new Random();
// int randomNumber = rand.Next(10, 100);

// System.Console.WriteLine(randomNumber);

// if (randomNumber / 10 > randomNumber % 10) {
//     System.Console.WriteLine($"Левое число больше -> {randomNumber / 10}");
// }
//     else if (randomNumber % 10 > randomNumber / 10) {
//         System.Console.WriteLine($"Правое число больше -> {randomNumber % 10}");
// }
//         else {
//             System.Console.WriteLine("Числа равны");
// }


// Console.Write("Введите первое число:");
//     int fNumber = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите второе число:");
//     int sNumber = Convert.ToInt32(Console.ReadLine());

// if (fNumber%sNumber == 0) {
//     Console.WriteLine("Числа кратные");
// } 
//     else Console.WriteLine("Числа не кратные: " + fNumber % sNumber);

// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
// 7 и 23.

// 14 -> нет 
// 46 -> нет 
// 161 -> да

// Console.Write("Введите число: ");
//     int Number = Convert.ToInt32(Console.ReadLine());
// if (Number % 7 == 0 && Number % 23 == 0 ) {
// System.Console.WriteLine($"{Number} -> да");
// }   else {
//         System.Console.WriteLine($"{Number} ->  нет");
// }



// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

System.Console.WriteLine("Введите число1: ");
int Number1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите число2: ");
int Number2 = Convert.ToInt32(Console.ReadLine());

if (Number1 * Number1 == Number2 || Number2 * Number2 == Number1)
{
    System.Console.WriteLine("да");
}
else
{
    System.Console.WriteLine("нет");
}
