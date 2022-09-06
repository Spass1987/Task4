// Написать программу вычесления функции Аккермана

int Akkerman(int M, int N)
{
    if (M == 0) return N + 1;
    else 
    {
        if (N == 0 && M > 0) return Akkerman(M - 1, 1);
        else return Akkerman(M-1, Akkerman(M, N-1));
    }

}
Console.Write("Введите число M: ");
int M = int.Parse(Console.ReadLine());
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Функция Аккtрмана от {M} и {N} равна {Akkerman(M, N)}");