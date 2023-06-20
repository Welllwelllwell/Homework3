// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
int[] coordinatyA = new int[3];
int[] coordinatyB = new int[3];
int i = 0;
double distance = 0;

System.Console.WriteLine("Введите координату Х точки А");
coordinatyA[0] = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите координату Y точки А");
coordinatyA[1] = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите координату Z точки А");
coordinatyA[2] = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите координату Х точки B");
coordinatyB[0] = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите координату Y точки B");
coordinatyB[1] = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите координату Z точки B");
coordinatyB[2] = Convert.ToInt32(Console.ReadLine());
i = (coordinatyA[0] + coordinatyB[0]) ^ 2 + (coordinatyA[1] + coordinatyB[1]) ^ 2 + (coordinatyA[2] + coordinatyB[2]) ^ 2;
distance = Math.Sqrt(i);
System.Console.WriteLine(distance);
