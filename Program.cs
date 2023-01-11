// Задача 41. Пользователь вводит с клавиатуры М чисел. Посчитайте, сколько чисел больше 0 ввел пользователь.

/*int CountPositiveNumbers(int m)
{
    int n = 0;
    for (int i = 0; i < m; i++)
    {
        Console.Write("Input numbers: ");
        int num = Convert.ToInt32(Console.ReadLine());
        if (num > 0) n++;
    }
    return n;
}

Console.Write("How many numbers do you want input: ");
int m = Convert.ToInt32(Console.ReadLine());
int result = CountPositiveNumbers(m);
Console.Write(result);
*/

// Задача 43. Напишите программу, которая найдет точку пересечения двух прямых, заданных уравнениями y=k1*x+b1, y=k2*x+b2; значения b1, k1, b2, k2 задаются пользователем.

/*void IntersectionPoint(double b1, double k1, double b2, double k2)
{
    if (k1 != k2)
    {
        double x = (b1 - b2) / (k2 - k1);
        double y = (k2 * b1 - k1 * b2) / (k2 - k1);
        Console.Write($"The intersection point is ({x},{y})");
    }
    if (k1 == k2 && b1 != b2)
        Console.Write("The straight lines are parallel");
    if (k1 == k2 && b1 == b2)
        Console.Write("The straight lines are match ");

}

Console.Write("Input a value of straight line b1:  ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a value of straight line k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a value of straight line b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a value of straight line k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

IntersectionPoint(b1, k1, b2, k2);
*/