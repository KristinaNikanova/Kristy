Console.WriteLine("Введите количество чисел: ");
int countPrima = Convert.ToInt32(Console.ReadLine());
int countSecunda = 0;

Console.WriteLine("Введите числа:");

while (countPrima > 0)
{
    int number = Convert.ToInt32(Console.ReadLine());
    if (number > 0) countSecunda++;
    countPrima--;
}

Console.WriteLine($"чисел больше нуля: {countSecunda}");
