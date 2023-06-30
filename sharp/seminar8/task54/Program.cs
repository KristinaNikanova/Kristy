int[,] table = GenerateTable(5, 5, 0, 7);

WriteTable(table, "исходная таблица");

SortArray(table);

WriteTable(table, "результирующая таблица");

void SortArray(int[,] table)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        ShakerSort (table, i);
    }
}

void ShakerSort(int[,] table, int i)
{
    int endl = 0;
    int endr = table.GetLength(1) - 1;
    int count = 1;
    while (count > 0)
    {
        count = 0;
        for (int j = endl; j < endr; j++)
        {
            int k = j + 1;
            if (table[i, j] < table[i, k])
            {
                SwapItems(table, i, j, k);
                count++;
            }
        }
        endr -= 1;

        if (count == 0) break;

        for (int j = endr; j > endl; j--)
        {
            int k = j - 1;
            if (table[i, j] > table[i, k])
            {
                SwapItems(table, i, j, k);
                count++;
            }
        }
        endl += 1;
    }

}

void SwapItems(int[,] table, int i, int j, int k)
{
    table[i, j] ^= table[i, k];
    table[i, k] ^= table[i, j];
    table[i, j] ^= table[i, k];
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
