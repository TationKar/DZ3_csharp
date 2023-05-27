/* Задача 21
Напишите программу, которая принимает на вход координаты двух 
точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */
Console.Clear();
Console.Write("Введите координату AX: ");
int ax = int.Parse(Console.ReadLine());
Console.Write("Введите координату AY: ");
int ay = int.Parse(Console.ReadLine());
Console.Write("Введите координату AZ: ");
int az = int.Parse(Console.ReadLine());
Console.Write("Введите координату BX: ");
int bx = int.Parse(Console.ReadLine());
Console.Write("Введите координату BY: ");
int by = int.Parse(Console.ReadLine());
Console.Write("Введите координату BZ: ");
int bz = int.Parse(Console.ReadLine());
double s = Math.Sqrt(Math.Pow((ax-bx), 2) + Math.Pow((ay-by), 2) + Math.Pow((az-bz), 2));
Console.WriteLine($"Расстояние между точками {Math.Round(s, 2)}");