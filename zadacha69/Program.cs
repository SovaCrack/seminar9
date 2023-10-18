// Напишите программу, которая на вход принимает два числа А и В, 
// и взводит число А в целую степень В с помощью рекурсии.
// А = 3; B = 5-> 243(3/5)
// А = 2; B = 3-> 8

Console.WriteLine("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());

int Pow(int a, int b)
{
    if( b == 0) return b;
    else if (b == 1) return a;
    else
    {
        return a*Pow(a, b-1);
    }
}

Console.WriteLine(Pow(a, b));