/* Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */
Console.Clear();
Console.Write("Введите целое положительное число: ");
int num = int.Parse(Console.ReadLine());
int count = 1;

if (num == 0 )
    Console.Write("0");

for (int i = 1; i <=num; i++)
    Console.Write($"{Math.Pow(i, 3)} ");

Console.WriteLine();

