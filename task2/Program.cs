// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
//S=sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)(z2-z1))


void GetCoordinates(string message, int[] dot)
{
    Console.WriteLine(message);
    for(int i=0; i < dot.Length; i++)
    {
        dot[i] = Convert.ToInt32(Console.ReadLine());
    }
}

int[] dot1 = new int[3];
GetCoordinates("Введите координаты первой точки: ", dot1);

int[] dot2 = new int[3];
GetCoordinates("Введите координаты второй точки: ", dot2);

double spasing=Math.Sqrt(Math.Pow(dot2[0]-dot1[0], 2) + Math.Pow(dot2[1]-dot1[1], 2) + Math.Pow(dot2[2]-dot1[2], 2));

Console.Write("A ( ");
foreach (var v in dot1)
{
    Console.Write(v + " ");
}
Console.Write("); B ( ");

foreach (var v in dot2)
{
    Console.Write(v + " ");
}
Console.Write($") -> {spasing}");

