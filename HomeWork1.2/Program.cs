//Баранович Артур
//а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2, y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2 - y1, 2).Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
//б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.

Console.WriteLine("ВВедите  X числа А");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите Y числа А");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("ВВедите X числа B");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите Y числа В");
double y2 = Convert.ToDouble(Console.ReadLine());

double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
Console.WriteLine("Растоение между точками " + string.Format("{0:F2}", r));

//пункт б

 void rast()
{
    double R1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    Console.WriteLine("Растоение между точками " + string.Format("{0:F2}", R1));
}

rast();