/* Задача 19
Напишите программу, которая принимает на вход пятизначное 
число  и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */
Console.Clear();
Console.Write("Введите целое пятизначное число: ");
int fiveDigit = int.Parse(Console.ReadLine()!);

if (fiveDigit <= 9999 || fiveDigit > 99999)
    Console.WriteLine("Введено некоректное число");
else
{   int frstDgt = fiveDigit / 10000;
    int scndDgt = (fiveDigit / 1000) - frstDgt * 10;
    int frthDgt = (fiveDigit % 100) / 10;
    if (frstDgt == fiveDigit % 10 && scndDgt == frthDgt)
        Console.WriteLine($"Введеное число {fiveDigit} является палиндромом");
    else
        Console.WriteLine($"Введеное число {fiveDigit} НЕ является палиндромом");
}
