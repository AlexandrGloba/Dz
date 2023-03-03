//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь

Console.WriteLine("Введите колличество чисел: ");
int M = Convert.ToInt32(Console.ReadLine());
int count = 0;
for (int i = 0; i < M; i++)
{
    Console.Write($"Введите число : ");
    int x = Convert.ToInt32(Console.ReadLine());
    if (x > 0)
        count++;
}
Console.WriteLine($"Введено чисел больше нуля: {count}");

