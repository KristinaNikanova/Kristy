int[,] array = GenerateTable(3, 5, -10, 10);
WriteTable(array, null);
double[] avgs = new double[array.GetLength(1)];
for (int j = 0; j < array.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < array.GetLength(0); i++) sum += array[i, j];
    double avg = Math.Round(sum / array.GetLength(0), 2);
    avgs[j] = avg;
}

for (int i = 0; i < avgs.Length; i++) Console.Write($"{avgs[i]} ");

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