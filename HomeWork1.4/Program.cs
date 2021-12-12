//Баранович Артур
//5.
//а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
//б) Сделать задание, только вывод организовать в центре экрана.
//в) *Сделать задание б с использованием собственных методов (например, Print(string ms, int x, int y).
string info = "Артур Баранович, г. Москва";
Console.WriteLine(info);
////б
Console.SetCursorPosition((Console.WindowWidth - info.Length) / 2, Console.WindowHeight / 2);
Console.WriteLine(info);
//B
void Print(string ms, int x, int y)
{
    Console.SetCursorPosition(x, y);
    Console.WriteLine(ms);
}
int a = (Console.WindowWidth - info.Length) / 2;
int b = Console.WindowHeight / 2;
Print(info, a, b);