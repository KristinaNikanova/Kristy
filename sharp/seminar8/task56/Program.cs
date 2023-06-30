int[,] table = GenerateTable(5, 5, 0, 7);

WriteTable(table, "исходная таблица");

Console.WriteLine("строка с наименьшей суммой: " + FindMinRow(table));

int FindMinRow(int[,] table)
{
    int minRow = 0;
    int min = RowSum(table, minRow);
    for (int i = 1; i < table.GetLength(0); i++)
    {
        int sum = RowSum(table, i);
        if (sum < min)
        {
            min = sum;
            minRow = i;
        }
    }
    return minRow;
}

int RowSum(int[,] table, int i)
{
    int sum = 0;
    for (int j = 0; j < table.GetLength(1); j++)
    {
        sum += table[i, j];
    }
    return sum;
}

int[,] GenerateTable(int rows, int columns, int min, int max)
{
    int[,] table = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            table[i, j] = rnd.Next(min, max);
        }
    }

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
