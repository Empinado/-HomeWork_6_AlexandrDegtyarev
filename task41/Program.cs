// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


Console.WriteLine("Введите количество элементов массива: ");
int[] Array = new int[Convert.ToInt32(Console.ReadLine())];
Console.WriteLine();

for (int i = 0; i < Array.Length; i++)
{
    Console.WriteLine($"Введите {i + 1} элемент массива: ");
    Array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine();
Console.Write("[" + string.Join(",", Array) + "]");
Console.WriteLine();
int count = 0;

for (int i = 0; i < Array.Length; i++)
{
    if (Array[i] > 0)
    {
        count += 1;
    }
}

Console.WriteLine("Количество чисел больше 0: "+ count);