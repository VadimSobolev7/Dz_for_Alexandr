//  Напишите программу, которая принимает на вход координаты двух точек и
//  находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты X");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты Y");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты Z");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты X1");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты Y1");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты Z1");
int z2 = Convert.ToInt32(Console.ReadLine());
double result = Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1));
Console.WriteLine(result);

