//Баранович Артур
//3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
Console.WriteLine("Вводите числа");
List<int> numbers = new List<int> {};
do
{
    numbers.Add(Convert.ToInt32(Console.ReadLine()));
}
while (numbers[^1] != 0);

int[] numbers2 = numbers.ToArray<int>();
int summ = 0;
foreach (int item in numbers2)
{
    if (item % 2 != 0 && item > 0)
        summ = summ + item;
}
Console.WriteLine("Сумма всех нечетных положительных чисел равна" + summ);