//Баранович Артур
//2.Реализуйте задачу 1 в виде статического класса StaticClass;
//а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
//б) Добавьте статический метод для считывания массива из текстового файла. Метод должен возвращать массив целых чисел;
//в)*Добавьте обработку ситуации отсутствия файла на диске.
int[] nums = new int[20];
StaticClass.addArray(nums);
int[] nums3 = StaticClass.showArray();
for (int i = 0; i < nums3.Length; i++)
{
    Console.WriteLine(nums3[i]);
}
static class StaticClass
{
    static public void addArray(int[] x)
    {
        int couples = 0;
        Random rand = new Random();
        for (int i = 0; i < x.Length; i++)
        {
            x[i] = rand.Next(-10000, 10000);
        }
        for (int i = 0; i < x.Length - 1; i++)
        {
            if (x[i] % 3 == 0 && x[i + 1] % 3 != 0)
                couples++;
            if (x[i] % 3 != 0 && x[i + 1] % 3 == 0)
                couples++;
        }
        Console.WriteLine(couples);
    }

    static public int[] showArray()
    {
        int[] nums2 = new int[5];
        if (File.Exists(@"C:\Users\Владимир\source\repos\HomeWorks4\test.txt"))
        {
        string[] lines = File.ReadAllLines(@"C:\Users\Владимир\source\repos\HomeWorks4\test.txt");
        for (int i = 0; i < nums2.Length; i++)
        {
            nums2[i] = Convert.ToInt32(lines[i]);
        }
        return nums2;
        }
        else
        {
            throw new ArgumentException($"Файл не существует!");
        }
    }
}

