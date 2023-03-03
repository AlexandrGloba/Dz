//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь

Console.WriteLine("Введите колличество чисел: ");
int M = Convert.ToInt32(Console.ReadLine());
int count = 0;
for (int i = 0; i < M; i++)
{
    Console.Write($"Введите число : ");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number > 0)
        count++;
}
Console.WriteLine($"Введено чисел больше нуля: {count}");
//  Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Введите число b1: ");//вводим числа
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
// немного математики
double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;

Console.WriteLine($"Пересечение двух прямых в точке: ({x};{y})");//Магия

