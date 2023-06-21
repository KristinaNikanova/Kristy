int [] array = new int [10];
Random random = new Random();
for (int i =0; i < array.Length; i++ )
{
    array [i] = random.Next(100, 1000);
}
int count = 0;
foreach (int i in array){
    if ((i & 1) == 0) count++;
}
foreach(int i in array){
    Console.Write($"{i} ");
}
Console.WriteLine();

Console.WriteLine (count);
