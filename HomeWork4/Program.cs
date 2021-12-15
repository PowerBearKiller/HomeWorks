//Баранович Артур
//4. Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль.
//На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains).
//Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль,
//программа пропускает его дальше или не пропускает. С помощью цикла do while ограничить ввод пароля
//тремя попытками.
string login = "root";
string password = "GeekBrains";
int attempts = 3;
bool auth(string log, string passwd)
{
    if (login == log && password == passwd)
        return true;
    else
    {
        return false;
    }
}
do
{
    Console.WriteLine("Введите Логин");
    string a = Console.ReadLine();
    Console.WriteLine("Введите Пароль");
    string b = Console.ReadLine();
    if (auth(a, b))
    {
        Console.WriteLine("Вы в системе");
        return;
    }
    attempts--;
    Console.WriteLine("Осталось " + attempts + " Попыток");
}
while (attempts > 0);