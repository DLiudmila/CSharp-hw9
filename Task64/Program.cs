//Задайте значение N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от N до 1. 


Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("N = " + N + " -> \"");
PrintTillOne(N);
Console.WriteLine("\"");


void PrintTillOne(int num)
{
    if (num < 1)
    {
        return;
    }
    if (num != 1 )
    {
        System.Console.Write(num + ", ");
    }
    else
    {
        System.Console.Write(num);
        return;
    }
    PrintTillOne(num - 1);
}
