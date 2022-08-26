// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
void Cub(int Num)
    {
        int y=1;
        Console.Write(Num +"-> ");
        for(int i=y; i<=Num; i++)
            {
                y=i*i*i;
                Console.Write(y);
                if(i!=Num)
                    Console.Write(",");
            }
    }

int x;
Console.WriteLine("Введите число:");
x=Convert.ToInt32(Console.ReadLine());
if(x>0)
    Cub(x);
else
    Console.WriteLine("Введенное число должно быть больше 0");
