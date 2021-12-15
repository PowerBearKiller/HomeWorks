//Баранович Артур
//5.
//а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
//б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
Console.WriteLine("Введите свою массу");
double mass = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите свой рост");
double height = Convert.ToDouble(Console.ReadLine());
double indexMass = mass / Math.Pow(height, 2);
if (18.5 > indexMass)
    Console.WriteLine("Вам нужно набрать вес");
if (18.5 <= indexMass && indexMass <= 25)
    Console.WriteLine("У вас нормальная масса тела");
if (indexMass > 25) 
    Console.WriteLine("Вам нужно похудеть");
Console.WriteLine(indexMass);
//b
if (18.5 > indexMass)
{
    double massNeed = 18.5 * Math.Pow(height, 2);
    massNeed = massNeed - mass;
    Console.WriteLine("Вам нужно набрать {0: 0.0} кг", massNeed);
}
if (indexMass > 25)
{
    double massNeed = 25 * Math.Pow(height, 2);
    massNeed =  mass - massNeed;
    Console.WriteLine("Вам нужно сбросить {0: 0.0} кг", massNeed);
}