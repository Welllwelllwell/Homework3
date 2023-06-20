// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

System.Console.WriteLine("Введите пятизначное число");
int numberA = Convert.ToInt32(Console.ReadLine());
string str = numberA.ToString();
if (str[4]==str[0]||str[3]==str[1])
{
 System.Console.WriteLine("Число палиндром");
}
else
{
    System.Console.WriteLine("Число не является палиндромом");
}

