Console.WriteLine("Введите номер дня недели:");
int day = Convert.ToInt32(Console.ReadLine());

if (day < 1 || day > 7) Console.WriteLine("Введено неверное значение");
else if (day > 5) Console.WriteLine("Да, выходной");
else Console.WriteLine("Нет, рабочий");
