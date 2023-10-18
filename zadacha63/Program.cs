// Задайте значение N. Напишите программу, которая выведит все натуральные числа в промежутке от 1 до N
// N=5->"1,2,3,4,5"
// n=6->"1,2,3,4,5,6"

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

void Print(int N)
{
    Console.Write($"{N} -> ");
    for (int i = 1; i <= N; i++)
    {
       Console.Write($"{i} "); 
    }
}
Print(N);
Console.WriteLine();

//Рекурсия

string PrintNumber(int start, int end)
{
    if(start == end) return Convert.ToString(start);
    return (start + " " + PrintNumber(start + 1, end));
}

Console.Write($"{N} -> ");
Console.Write(PrintNumber(1, N));