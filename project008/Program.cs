/*
Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5. -> ""1, 2, 3, 4, 5""
M = 4; N = 8. -> ""4, 6, 7, 8""
*/
using static System.Console;
Clear();
string writeNumbers(int start, int end)
{
    if (start >= end) return start.ToString();
    return (start + ", " + writeNumbers(start + 1, end));
}

Console.Write("Введите первое число: ");
int m = int.Parse(ReadLine());
Console.Write("Введите второе число: ");
int n = int.Parse(ReadLine());
if (m > n)
{
    Console.WriteLine("Задайте первое число больше второго");
}
else
{
    Console.WriteLine(writeNumbers(m, n));
}

/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Clear();
string writeNumbers(int start, int end)
{
    if (start >= end) return start.ToString();
    return (start + ", " + writeNumbers(start + 1, end));
}

Console.Write("Введите первое число: ");
int m = int.Parse(ReadLine());
Console.Write("Введите второе число: ");
int n = int.Parse(ReadLine());
///Метод нахождения суммы натуральных элементов в промежутке от M до N
void GapNumberSum (int m, int n, int sum)
{
    if (m > n) 
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от 1 до 2 числа: {sum}"); 
        return;
    }
    sum = sum + (m++);
    GapNumberSum(m, n, sum);
}

GapNumberSum(m, n, 0);


/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 3, n = 2 -> A(m,n) = 29
*/

Clear();
WriteLine("Введите начальное число m:");
int m = int.Parse(ReadLine());

WriteLine("Введите начальное число n:");
int n = int.Parse(ReadLine());

///Метод вычисления функции Аккермана:
int AckermannFunction (int m, int n)
{
    if (m == 0) return n + 1;
    if (m != 0 && n == 0) return AckermannFunction(m - 1, 1);
    if (m > 0 && n > 0) return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
return AckermannFunction(m, n);
}

WriteLine($"Функция Аккермана для чисел A({m},{n}) = {AckermannFunction(m, n)}");
