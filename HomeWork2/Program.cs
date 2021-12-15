//Баранович Артур
//2. Написать метод подсчета количества цифр числа.
Console.WriteLine("Введите число");
            int a = Int32.Parse(Console.ReadLine());
            int s = 0;
            while(a != 0)
            {
                a = a/10;
                s++;
                
            }
            Console.WriteLine(s);