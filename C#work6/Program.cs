

// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

// int[] coordinates = new int[2];

// Console.Write("Введите координату Х: ");
// coordinates[0] = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите координату Y: ");
// coordinates[1] = Convert.ToInt32(Console.ReadLine());

// if (coordinates[0] > 0 && coordinates[1] > 0)
// {
//     System.Console.WriteLine("Точка находится в 1-й четверти");
// }
// else if (coordinates[0] < 0 && coordinates[1] > 0)
// {
//     System.Console.WriteLine("Точка находится во 2-й четверти");
// }
// else if (coordinates[0] < 0 && coordinates[1] < 0)
// {
//     System.Console.WriteLine("Точка находится в 3-й четверти");
// }
// else if (coordinates[0] > 0 && coordinates[1] < 0)
// {
//     System.Console.WriteLine("Точка находится во 4-й четверти");
// }
// else
// {
//     System.Console.WriteLine("Введены неправильные координаты");
// }


// // Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
// Console.WriteLine("Введите чмсло");
// int number = Convert.ToInt32(Console.ReadLine());

// string[] array = {"X > 0 && Y > 0", "X < 0 && Y > 0", "X > 0 && Y < 0", "X > 0 && Y < 0"};

// if (number == 1)
// {
//     Console.WriteLine("X > 0 && Y > 0");
// }

// else if (number == 2)
// {
//     Console.WriteLine("X < 0 && Y > 0");
// }

// else if (number == 3)
// {
//     Console.WriteLine("X > 0 && Y < 0");
// }

// else if (number == 3)
// {
//     Console.WriteLine("X > 0 && Y < 0");
// }

// else
// {
//    Console.WriteLine("Такой четверти не существует"); 
// }


// Math.Pow(3, 4); // Возведение числа 3 в степень 4
// Math.Sqrt(11); // Взятие квадратного корня
// Math.Round(3.123123123, 3); // Округление
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

// int[] aCoordinate = new int[2];
//             Console.WriteLine("Введите x первой точки: ");
//             aCoordinate[0] = Convert.ToInt32(Console.ReadLine());
//             Console.WriteLine("Введите y первой точки: ");
//             aCoordinate[1] = Convert.ToInt32(Console.ReadLine());
//             int[] bCoordinate = new int[2];
//             Console.WriteLine("Введите x первой точки: ");
//             bCoordinate[0] = Convert.ToInt32(Console.ReadLine());
//             Console.WriteLine("Введите y первой точки: ");
//             bCoordinate[1] = Convert.ToInt32(Console.ReadLine());

//             Console.WriteLine(Math.Round(Math.Sqrt(Math.Pow((bCoordinate[0] - aCoordinate[0]), 2) + Math.Pow((bCoordinate[1] - aCoordinate[1]),2)),3));




//             Console.WriteLine(string.Join(", ", array));
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
// от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4


// Console.WriteLine("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());

// int i=1;

// while (i <= number)
// {
//     Console.WriteLine(Math.Pow(i , 2)+ " ");
//     i++;
// }

// System.Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// for(int i = 1; i <= number; i++)
// {
//     Console.Write(Math.Pow(i, 2) + " ");
// }

string str = "12321";

if (str [0] == [4] || [1] == [3])
{
    System.Console.WhiteLine("Зеркальное");
}
else 
{
    System.Console.WhiteLine("Нет");
}