//Баранович Артур
//7.
//a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).
//б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.
Console.WriteLine("Введите первое число");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int y = Convert.ToInt32(Console.ReadLine());
void recFunc(int a, int b)
{
    if (a == b)
        Console.Write(b + " ");
    else
    {
        recFunc(a, b-1);
        Console.Write(b + " ");
    }
}
recFunc(x, y);
//b
int summ = 0;
void recFunc2(int a, int b)
{
    if (a == b)
        summ = summ + b;
    else
    {
        recFunc2(a, b - 1);
        summ = summ + b;
    }
}
recFunc2(x, y);
Console.WriteLine(summ);