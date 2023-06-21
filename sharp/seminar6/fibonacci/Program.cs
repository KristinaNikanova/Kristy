int number = 0;

while (number <= 0)
{
    Console.WriteLine("Введите число: ");
    number = Convert.ToInt32(Console.ReadLine());
}

int fidx = number - 1;
int bidx = fidx;
int length = number + fidx;
int[] array = new int[length];

Fibonacci fibonacci = new();
while (fidx < length)
{
    int next = fibonacci.Next();
    array[fidx] = next;
    if ((bidx & 1) == 0) next = -next;
    array[bidx] = next;
    fidx++;
    bidx--;
}


foreach (int i in array)
{
    Console.Write($"{i} ");
}
Console.WriteLine(array);

class Fibonacci
{
    private int i1 = 0;
    private int i2 = 1;

    public int Next()
    {
        int temp = i1;
        i2 += i1;
        i1 = i2 - temp;
        return temp;
    }
}