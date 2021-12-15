//Баранович Артур
//1. Написать метод, возвращающий минимальное из трёх чисел.
Console.WriteLine("Введите 3 числа");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
int minNumber(int x, int y, int z)
{
    int m;
    if (x < y) m = x;
    else m = y;
    if (m < z) return m;
    else return z;
}
Console.WriteLine(minNumber(a, b, c));