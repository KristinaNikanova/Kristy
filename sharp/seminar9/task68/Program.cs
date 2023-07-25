Console.WriteLine(akkerFunc(2, 3));

Console.WriteLine(akkerFunc(3, 2));



/*
решение, исходя из определения Петер в Wikipedia
*/
static int akkerFunc(int m, int n)
{
    if (m == 0) return n + 1;
    else
    {
        if (m != 0 && n == 0) return akkerFunc(m - 1, 1);
        else return akkerFunc(m - 1, akkerFunc(m, n - 1));
    }
}
