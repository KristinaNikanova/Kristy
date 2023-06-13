int [] array = new int [10];
Random random = new Random();
for (int i =0; i < array.Length; i++ )
{
    array [i] = random.Next(1, 100);
}

int min = array[0];
int max = array[0];

for (int i = 1; i < array.Length; i++ )
{
    if (array [i] < min) min = array [i];
    else if (array [i] > max) max = array [i];
}

int diff = max - min;

foreach(int i in array){
    Console.Write($"{i} ");
}
Console.WriteLine();

Console.WriteLine($"min = {min} ");
Console.WriteLine($"max = {max} ");
Console.WriteLine($"diff = {diff} ");