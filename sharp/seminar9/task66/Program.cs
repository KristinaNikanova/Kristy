Console.WriteLine("Введите число M (от)");
int M = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите число N (до)");
int N = Convert.ToInt32(Console.ReadLine()); 

Console.WriteLine(recSum (M, N));

static int recSum (int M, int N)
{
    if (M > N) return recSum (N, M);
    if (N==M) return M;
    return N += recSum (M, N-1);
}

