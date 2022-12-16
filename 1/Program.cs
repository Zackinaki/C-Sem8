// task 41
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 
// ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();
Console.Write("Введите кол-во чисел: ");
int n = Convert.ToInt32(Console.ReadLine()), count = 0;
for (int i = 0; i < n; i++)
{
    int x = Convert.ToInt32(Console.ReadLine());
    if (x > 0)
        count++;
}
Console.WriteLine(count);

// // task 41

// Console.Clear();
// int[] numbers = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// int count = 0;
// foreach (int element in numbers)
// {
//     if (element > 0)
//         count++;
// }
// Console.WriteLine(count);

