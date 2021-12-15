//Баранович Артур
//6. *Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000.
//«Хорошим» называется число, которое делится на сумму своих цифр. Реализовать подсчёт времени выполнения программы,
//используя структуру DateTime.
DateTime beginTime = DateTime.Now;
int goodNumbers = 0;
int summNumbers;
int x;
for (int num = 1; num <= 1000000000; num++)
{
    summNumbers = 0;
    x = num;
    while (x != 0)
    {
        summNumbers += x % 10;
        x /= 10;
    }
    if (num % summNumbers == 0)
        goodNumbers++;
}
Console.WriteLine(goodNumbers);
DateTime endTime = DateTime.Now;
Console.WriteLine("Время выполнения: {0: 0} секунд", (endTime - beginTime).TotalSeconds);