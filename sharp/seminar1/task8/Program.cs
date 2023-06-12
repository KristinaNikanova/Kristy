Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());

int x = 1;

while(x <= N)
{
    if((x&1) == 0) Console.WriteLine(x);
    x = x+1;
}
