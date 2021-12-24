//Баранович Артур  
//1.
//а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.
//б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.
//в) Добавить диалог с использованием switch демонстрирующий работу класса.
Complex z1 = new Complex(1,-2);
Complex z2 = new Complex(3,-4);
z1.print(z1.Minus(z2));
Complex1 c1 = new Complex1(1, -2);
Complex1 c2 = new Complex1(3, -4);
c1.print(c1.Proizv(c2));
Console.WriteLine("Введите операцию - или *");
switch(Console.ReadLine())
{
    case "-":
        z1.print(z1.Minus(z2));
        break;
    case "*":
        c1.print(c1.Proizv(c2));
        break;
    default:
        Console.WriteLine("Вы немного ошиблись");
        break;
}
struct Complex
{
    public int a;
    public int b;

    public Complex(int a, int b)
    {
        this.a = a;
        this.b = b;
    }
    public Complex Minus(Complex x)
    {
        Complex result = new(this.a-x.a,this.b-x.b);
        return result;
    }
    public void print(Complex u)
    {
        if (u.b < 0)
            Console.WriteLine($"{u.a} {u.b}i");
        else
            Console.WriteLine($"{u.a} + {u.b}i");
    }
}
//b
class Complex1
{
    public int a;
    public int b;

    public Complex1(int a, int b)
    {
        this.a = a;
        this.b = b;
    }
    public Complex1 Minus(Complex1 x)
    {
        Complex1 result = new(this.a - x.a, this.b - x.b);
        return result;
    }
    public Complex1 Proizv(Complex1 x)
    {
        Complex1 result = new((this.a * x.a)-(this.b * x.b), (this.a * x.b) + (x.a * this.b));
        return result;
    }
    public void print(Complex1 u)
    {
        if (u.b < 0)
            Console.WriteLine($"{u.a} {u.b}i");
        else
            Console.WriteLine($"{u.a} + {u.b}i");
    }
}