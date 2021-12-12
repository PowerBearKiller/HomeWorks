//Артур Баранович
//Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах.



Console.WriteLine("Введите ваш рост");
double hight = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите ваш вес");
double wight = Convert.ToDouble(Console.ReadLine());
double i = wight / (hight * hight);
Console.WriteLine("Ващ индекс массы тела - " + i);