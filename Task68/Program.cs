//Напишите программу вычисления функции Аккермана 
//с помощью рекурсии. Даны два неотрицательных числа m и n


Console.WriteLine("Введите не отрицательное число m: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите не отрицательное число n: ");
int x2 = Convert.ToInt32(Console.ReadLine());
if ( x1 < 0 || x2 < 0)
{
    Console.WriteLine("Введено отрицательное число");
}
int result = Akkerman(x1, x2);
Console.WriteLine("Результат вычисления функции Аккермана = " + result);





int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return Akkerman(m - 1, Akkerman(m, n - 1));
    }

}

