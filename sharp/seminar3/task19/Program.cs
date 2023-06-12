int length = 0;
int number = 0;

// для именно пятизначного числа тут нужно поменять условие на (length != 5)
while (length == 0){
    Console.WriteLine("Введите число:");
    number = Convert.ToInt32(Console.ReadLine());
    length = (int)Math.Log10(number) + 1;
}

// для числа любой длины
int divider = (int)Math.Pow(10, length-1);

bool palindrome = true;

while (divider > 10){
    int leftNum = number / divider;
    int rightNum = number % 10;
    if (leftNum != rightNum){
        Console.WriteLine("Не является палиндромом");
        palindrome = false;
        break;
    }
    number = (number - leftNum*divider)/10;
    divider /= 100;
}

if (palindrome){
    Console.WriteLine("Является палиндромом");
}
