
// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
void ReadArray(int[] R)
    {
        Console.WriteLine("Координата Х");
        R[0] = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Координата У");
        R[1] = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Координата Z");
        R[2] = Convert.ToInt32(Console.ReadLine());
     }
// void WriteArray(int[] W)
//     {
//         for(int i=0; i<W.Length; i++)
//             Console.Write(W[i]+" ");
//     }
void WorkArray(int[] Point1, int[] Point2)
    {
        double[] x = new double[3];
        for(int i=0; i<Point1.Length; i++)
            {
                x[i] = Math.Abs(Point1[i]-Point2[i]);
            }
        for(int i=0; i<Point1.Length-1; i++)
            {
                x[i+1]=Math.Sqrt(x[i]*x[i]+x[i+1]*x[i+1]);
            }
        Console.WriteLine("Расстояние между точками " +x[2]);
       
    }
int[] A = new int[3];
int[] B = new int[3];

Console.WriteLine("Введите координаты первой точки");
ReadArray(A);
Console.WriteLine("Введите координаты второй точки");
ReadArray(B);
WorkArray(A, B);
