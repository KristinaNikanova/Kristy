Console.WriteLine("Точка A:");
int [] coordA = input_Coord();
Point A = new Point(coordA[0], coordA[1], coordA[2]);

Console.WriteLine("Точка B:");
int [] coordB = input_Coord();
Point B = new Point(coordB[0], coordB[1], coordB[2]);

double distance = Math.Sqrt(Math.Pow(A.x - B.x, 2) 
                            + Math.Pow(A.y - B.y, 2) 
                            + Math.Pow(A.z - B.z, 2));


Console.WriteLine("расстояние: " + distance);



int [] input_Coord (){
    while (true){
        Console.WriteLine("Введите три координаты через пробел:");
        string? input_str = Console.ReadLine();
        if (input_str == null) continue;
        string [] coordinates = input_str.Split();
        if (coordinates.Length < 3) continue;

        int x = Convert.ToInt32(coordinates[0]);
        int y = Convert.ToInt32(coordinates[1]);
        int z = Convert.ToInt32(coordinates[2]);
        return new[] {x, y, z};
    }
}


class Point{
    public readonly int x;
    public readonly int y;
    public readonly int z;
    public Point(int x, int y, int z){
        this.x = x;
        this.y = y;
        this.z = z;
    }
}

