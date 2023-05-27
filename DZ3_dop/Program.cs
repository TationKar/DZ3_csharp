/* На столе лежат n монеток. Некоторые из них лежат вверх решкой,
а некоторые – гербом. Определите минимальное число монеток, которые нужно перевернуть,
чтобы все монетки были повернуты вверх одной и той же стороной. 1-Решка, 0-Орел */
Console.Clear();
int size = new Random().Next(10, 20);
int[] coins = new int[size];
int heads = 0, tails = 0;

for (int i = 0; i < size; i++)
{
    coins[i] = new Random().Next(0, 2);
    if (coins[i] == 1)
        tails++;
    Console.Write($"{coins[i]} ");    
}
Console.WriteLine();

heads = size - tails;

if (heads > tails || heads == tails)
    Console.WriteLine($"Всего монет {size} из них нужно перевернуть {tails} лежащих решкой вверх");
else 
    Console.WriteLine($"Всего монет {size} из них нужно перевернуть {heads} лежащих орлом вверх");