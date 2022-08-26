// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
void Num(string Stroka)
{
    char[] ObrNum=Stroka.ToCharArray();
    Array.Reverse(ObrNum);
    string Palindrom=new string(ObrNum);
    if (Stroka==Palindrom)
        Console.WriteLine("Введенное число является полиндромом");
        else Console.WriteLine("Введенное число не является полиндромом");
}
int n;
Console.WriteLine("Введите пятизначное число:");
n=Convert.ToInt32(Console.ReadLine());
string Text=Convert.ToString(n);
if (Text.Length != 5)
    {   
        int z=Text.Length;
        Console.WriteLine("Нужно было ввести пятизначное число, а не "+z +" значное");
    }
    else 
        Num(Text);