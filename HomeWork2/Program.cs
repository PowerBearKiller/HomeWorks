//Баранович Артур  
//2.
//а) С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке).
//Требуется подсчитать сумму всех нечётных положительных чисел. Сами числа и сумму вывести на экран,
//используя tryParse.
int a;
int sum = 0;
List<int> numbers = new List<int> { };
do
{
    Console.WriteLine("Введите число");
    bool result = int.TryParse(Console.ReadLine(), out a);
    if (result)
    {
        if (a > 0 && a % 2 != 0)
        {
            numbers.Add(a);
            sum = sum + a;
        }
    }
    else
    {
        Console.WriteLine("Цифры писать нужно");
        a = 1;
    }
} while (a != 0);
foreach(int x in numbers)
{
    Console.WriteLine(x);
}

Console.WriteLine(" Сумма ваших нечетных, положительных чисел - " + sum);