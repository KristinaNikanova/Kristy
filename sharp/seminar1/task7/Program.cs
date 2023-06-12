/* если ведущие нули не имеют значения, то можно кол-во цифр вычислить через длину строки 
проверить что оно не меньше трех, сразу взять третий символ и вывести его
*/
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

int count = (int) Math.Log10 (num) +1;

if(count<3) Console.WriteLine("количество цифр меньше трех");
else 
{
    count = count-3;
    num=num/(int) MathF.Pow(10,count);
    Console.WriteLine(num%10);
}
