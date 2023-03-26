//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
/*
void PrintNumber(int N)
{
    if(N==0)
    {
        return;
    }
    Console.Write($"{N} ");
    PrintNumber(N-1);
}

Console.Write("Напишите число ");
int number = Convert.ToInt32(Console.ReadLine());
PrintNumber(number);*/

//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30
/*
void SummaNumber(int M, int N, int sum)
{
    if(M>N)
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}");
        return;
    }
    sum += M++; 
    SummaNumber(M,N,sum);  
}

Console.Write("Напишите первое число = ");
int numberfirst = Convert.ToInt32(Console.ReadLine());
Console.Write("Напишите второе число = ");
int numbersecond = Convert.ToInt32(Console.ReadLine());
SummaNumber(numberfirst,numbersecond, 0);*/

//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29

int Akkerman(int M, int N)
{
    if(M==0)
    {
        return N+1;
    }
    if(M>0 && N==0)
    {
        return Akkerman(M-1,1);
    }
    if(M>0 && N>0)
    {
        return Akkerman(M-1, Akkerman(M, N-1));
    }
    return Akkerman(M, N);
}

Console.Write("Напишите первое число = ");
int numberfirst = Convert.ToInt32(Console.ReadLine());
Console.Write("Напишите второе число = ");
int numbersecond = Convert.ToInt32(Console.ReadLine());
Console.Write(Akkerman(numberfirst, numbersecond));
