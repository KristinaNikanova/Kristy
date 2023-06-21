double k1 = getCoef("k1");
double b1 = getCoef("b1");
double k2 = getCoef("k2");
double b2 = getCoef("b2");

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;

// todo: форматированный вывод
Console.WriteLine($"Точка пересечения: {x}; {y}");

static double getCoef(String name)
{
    Console.WriteLine($"Введите коэффициент {name}: ");
    return Convert.ToDouble(Console.ReadLine());
}