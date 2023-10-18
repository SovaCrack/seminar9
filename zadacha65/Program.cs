// Задайте значения M и N. Напишите программу которая выведет все натуральные числа в промежутке от M дo N.
//M = 1; N = 5 ->"1,2,3,4,5"
//M = 4; N = 8 ->"4,6,7,8"
 


void Print ( int M, int N)
{
    if(M!=N + 1)
    {
        Console.Write($"{M} ");
        Print(M +1, N);
    }
}

Console.WriteLine("Введите число М: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());


Print(M, N);

