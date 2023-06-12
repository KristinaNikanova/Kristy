Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());

int count = (int) Math.Log10(num) + 1;

if (count < 3) Console.WriteLine("Количество цифр меньше трёх");

count -= 3;
num /= (int) Math.Pow(10, count);

Console.WriteLine("Третья цифра: " + num % 10);
