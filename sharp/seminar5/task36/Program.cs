int [] array = new int [10];
Random random = new Random();
for (int i =0; i < array.Length; i++ )
{
    array [i] = random.Next(0, 100);
}
int summ = 0;

for (int i =0; i < array.Length; i++ )
{
   if ((i & 1) != 0) summ = summ + array [i];
}

foreach(int i in array){
    Console.Write($"{i} ");
}
Console.WriteLine();

Console.WriteLine(summ);

