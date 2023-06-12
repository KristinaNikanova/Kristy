Console.WriteLine("Введите число");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень");
int numberB = Convert.ToInt32(Console.ReadLine());
int product = 1;
for(int i = 0; i < numberB; i++)
{
    product = product*numberA;
}

Console.WriteLine(product);

