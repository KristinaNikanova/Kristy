Console.WriteLine("Введите число строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов");
int n = Convert.ToInt32(Console.ReadLine());

double [,] array = new double[m,n];
Random random= new Random();

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0;j < array.GetLength(1); j++)
    {
        // генерируем от -10 до 10 с двумя знаками после запятой
        array [i, j] = Math.Round((random.NextDouble() * 20) - 10, 2 );
    }
}

WriteTable (array, null);

static void WriteTable (double [,] table, string? header){
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