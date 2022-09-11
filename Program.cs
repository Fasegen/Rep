// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.Write("Введите k1: ");
var k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b1: ");
var b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
var k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
var b2 = Convert.ToDouble(Console.ReadLine());

var x = (b2 - b1) / (k1 - k2);
var y = k1 * x + b1;
 
x = Math.Round(x, 4);
y = Math.Round(y, 4);
 
Console.WriteLine($"Пересечение в точке: ({x};{y})");


// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Write("Введите элементы через запятую: ");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(","), int.Parse);
int count = 0;
 
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] < 0)
    {
        count++;
    }
}
 
Console.WriteLine(count);


-