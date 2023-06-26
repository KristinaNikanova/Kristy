int[,] array = GenerateTable(2, 5, -10, 10);
WriteTable(array, null);

Console.WriteLine("Введите число");
int item = Convert.ToInt32(Console.ReadLine()); 

int[]? position = GetPosition(item, array);

if (position == null) Console.WriteLine("элемент не найден");
else Console.WriteLine($"строка {position[0]} столбец {position[1]}");


int[]? GetPosition(int item, int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            if (array[i, j] == item) return new int[] { i, j };

    return null;
}

int[,] GenerateTable(int rows, int columns, int min, int max)
{
    int[,] table = new int[rows, columns];
    Random rnd = new();

    for (int i = 0; i < table.GetLength(0); i++)
        for (int j = 0; j < table.GetLength(1); j++)
            table[i, j] = rnd.Next(min, max);

    return table;
}

void WriteTable(int[,] table, string? header)
{
    if (header != null) Console.WriteLine(header);
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            Console.Write("{0} ", table[i, j]);
        }
        Console.WriteLine();
    }
}

