Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine()); 

recOutput (N);

static void recOutput (int N)
{
    Console.Write($"{N} ");
    if (N > 1) recOutput (N-1);
}
