int i = 4;
int j = 3;

int[,] table = new int[i, j];
FillParams fParams = new FillParams(table);

while (true)
{
    if (FillLeftToRight (table, fParams)) break;
    if (FillTopToBottom (table, fParams)) break;
    if (FillRightToLeft (table, fParams)) break;
    if (FillBottomToTop (table, fParams)) break;
}

WriteTable (table, null);


bool FillLeftToRight(int[,] table, FillParams fParams)
{
    for (int i = fParams.endl; i <= fParams.endr; i++)
    {
        table[fParams.endt, i] = ++fParams.count;
    }
    fParams.endt++;
    return fParams.isOver();
}


bool FillTopToBottom(int[,] table, FillParams fParams)
{
    for (int i = fParams.endt; i <= fParams.endb; i++)
    {
        table[i, fParams.endr] = ++fParams.count;
    }
    fParams.endr--;
    return fParams.isOver();
}

bool FillRightToLeft(int[,] table, FillParams fParams)
{
    for (int i = fParams.endr; i >= fParams.endl; i--)
    {
        table[fParams.endb, i] = ++fParams.count;
    }
    fParams.endb--;
    return fParams.isOver();
}

bool FillBottomToTop(int[,] table, FillParams fParams)
{
    for (int i = fParams.endb; i >= fParams.endt; i--)
    {
        table[i, fParams.endl] = ++fParams.count;
    }
    fParams.endl++;
    return fParams.isOver();
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


class FillParams
{
    public int[,] table;
    public int limit;
    public int count;
    public int endl;
    public int endr;
    public int endt;
    public int endb;

    public FillParams(int [,] table)
    {
        this.table = table;
        this.limit = table.GetLength(0) * table.GetLength(1);
        this.count = 0;
        this.endl = 0;
        this.endr = table.GetLength(1) - 1;
        this.endt = 0;
        this.endb = table.GetLength(0) - 1;
    }

    public bool isOver ()
    {
        return count == limit;
    }
}

