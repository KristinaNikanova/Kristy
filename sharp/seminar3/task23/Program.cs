Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
int current = 1;
while (current <= number){
    Console.WriteLine(Math.Pow(current, 3));
    current++;
}