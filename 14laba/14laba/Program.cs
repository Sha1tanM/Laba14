// Ввод данных с клавиатуры
Console.WriteLine("Введите размерность массива (количество строк и столбцов):");
int size = int.Parse(Console.ReadLine());
int[,] array = new int[size, size];
Console.WriteLine("Введите элементы массива:");

for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        array[i, j] = int.Parse(Console.ReadLine());
    }
}

// Сортировка двумерного массива по возрастанию
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int k = 0; k < array.GetLength(0); k++)
        {
            for (int l = 0; l < array.GetLength(1); l++)
            {
                if (array[i, j] < array[k, l])
                {
                    int temp = array[i, j];
                    array[i, j] = array[k, l];
                    array[k, l] = temp;
                }
            }
        }
    }
}

// Замена элементов с чётными индексами на элементы с нечётными индексами
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (i % 2 == 0 && j % 2 == 0 && i + 1 < array.GetLength(0) && j + 1 < array.GetLength(1))
        {
            int temp = array[i, j];
            array[i, j] = array[i + 1, j + 1];
            array[i + 1, j + 1] = temp;
        }
    }
}

// Вывод отсортированного и измененного массива
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}