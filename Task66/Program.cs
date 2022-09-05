//Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.


Console.WriteLine("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int sum = SumMN(M, N);
System.Console.WriteLine("M = " + M + "; N = " + N + " -> " + sum);


int SumMN(int m, int n)
{
    if (m > n)
    {
        return 0;
    }
    else
    {
        return m + SumMN(m + 1, n);
    }
}