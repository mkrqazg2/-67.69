// Задача 67: Показать натуральные числа от N до 1, N задано.

/* Console.Write(" Введите число: ");
int number = int.Parse(Console.ReadLine());
void PrintNumber(int number)
{
    if (number < 1) return;
    Console.Write($"{number} ");
    PrintNumber(number - 1);
}
PrintNumber(number); */

//Задача 69: Задайте значения M и N. Напишите программу, которая найдёт сумму элементов в промежутке от M до N.
//M = 1; N = 4 -> 10
Console.Write( " Введите первое число: ");
int m = int.Parse(Console.ReadLine());
Console.Write( " Введите второе число: ");
int n = int.Parse(Console.ReadLine());
int sum(int n)
    {
        if (n==m) return m;
        else return n+sum(n-1);
    }
    Console.WriteLine($"Сумма чисел : {sum(n)}");

