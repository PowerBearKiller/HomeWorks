//Баранович Артур
//3. * Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел.
//Предусмотреть методы сложения, вычитания, умножения и деления дробей. Написать программу,
//демонстрирующую все разработанные элементы класса.
//Добавить свойства типа int для доступа к числителю и знаменателю;
//Добавить свойство типа double только на чтение, чтобы получить десятичную дробь числа; 
//**Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение
//ArgumentException("Знаменатель не может быть равен 0"); ***Добавить упрощение дробей.
Fractions z1 = new Fractions(5,35);
Fractions z2 = new Fractions(3, 2);
z1.print(z1.plus(z2));
z1.print(z1);
int a = z2.Nod(z1);
z1.a /= a;
z1.b /= a;
z1.print(z1);
Console.WriteLine(z1.showFract);
class Fractions
{
    public int a;
    public int b;
    public double showFract
    {
        get { return Convert.ToDouble(this.a) / Convert.ToDouble(this.b); }
    }

    public Fractions(int a, int b)
    {
        if (b == 0)
            throw new ArgumentException($"Знаменатель не может быть равен 0");
        this.a = a;
        this.b = b;
    }

    public Fractions plus(Fractions x)
    {
        if (this.b == x.b)
        { Fractions result = new(this.a + x.a, this.b); return result; }
        else
        { Fractions result = new(this.a * x.b + x.a * this.b, this.b * x.b); return result; }
    }
    public Fractions minus(Fractions x)
    {
        if (this.b == x.b)
        { Fractions result = new(this.a - x.a, this.b); return result; }
        else
        { Fractions result = new(this.a * x.b - x.a * this.b, this.b * x.b); return result; }
    }
    public Fractions proizv(Fractions x)
    {
        Fractions result = new(this.a * x.a, this.b * x.b); return result; 
    }
    public Fractions del(Fractions x)
    {
        Fractions result = new(this.a * x.b, this.b * x.a); return result;
    }
    public void print(Fractions x)
    {
            Console.WriteLine($"{x.a}/{x.b}");
    }
    public int Nod(Fractions x)
    {
        int temp;
        int c;
        int y;
        c = Math.Abs(x.a);
        y = Math.Abs(x.b);
        while (y != 0 && c != 0)
        {
            if (c % y > 0)
            {
                temp = c;
                c = y;
                y = temp % y;
            }
            else break;
        }
        if (y != 0 && c != 0) return y;
        else return 0;
    }

}