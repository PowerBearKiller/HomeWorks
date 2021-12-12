//Баранович Артур
//1.Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку:
//а) используя склеивание;
//б) используя форматированный вывод;
//в) используя вывод со знаком $.

Console.WriteLine("Введите ваше имя");
string name = Console.ReadLine();
Console.WriteLine("Введите вашу фамилию");
string secandndname = Console.ReadLine();
Console.WriteLine("Введите ваш возраст");
string age = Console.ReadLine();
Console.WriteLine("Введите ваш рост");
string hight = Console.ReadLine();
Console.WriteLine("Введите ваш вес");
string wight = Console.ReadLine();

Console.WriteLine("Используя склеевание \nВаши данные: Имя - " +name + " ваша фамилия - " + secandndname + " Ваш возраст - " + age + " Ваш рост - " + hight + " Ваш вес - "+ wight);
Console.WriteLine("Используя форматировнный вовыд \nВаши данные: Имя - {0} ваша фамилия - {1} Ваш возраст - {2} Ваш рост - {3} Ваш вес - {4}", name, secandndname,age,hight,wight );
Console.WriteLine($"Используя вывод со знаком $ \nВаши данные: Имя - {name} ваша фамилия - {secandndname} Ваш возраст - {age} Ваш рост - {hight} Ваш вес - {wight}");
