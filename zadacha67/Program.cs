// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45-> 9 

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
N = sumNum(N);
Console.WriteLine(N);

int sumNum(int N)
{
    if(N == 0) return N;
    return N % 10 + sumNum(N / 10);
}
