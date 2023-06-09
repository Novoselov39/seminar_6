Console.Clear();

int[] ReadMass()
{
    Console.WriteLine("Введите размерность массива:");
    int i, n = Convert.ToInt32(Console.ReadLine());
    int[] mas = new int[n];
    Console.WriteLine("Введите массив:");
    string[] str = Console.ReadLine().Split(new char[] { ' ', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries);
    for (i = 0; i < (n < str.Length ? n : str.Length); ++i)
        mas[i] = Convert.ToInt32(str[i]);
    return mas;
}

void CountPositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    Console.WriteLine($"Количество положительных эллементов массива = {count}");
}

CountPositiveNumbers(ReadMass());

