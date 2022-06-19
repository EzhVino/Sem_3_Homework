//Программа, которая принимает 5-значное число и проверяет, палиндром ли оно

Console.Clear();

void Reverse(int num)
{
    int d5 = num % 10;
    int d4 = num / 10 % 10;
    int d3 = num / 100 % 10;
    int d2 = num / 1000 % 10;
    int d1 = num / 10000 % 10;
    num = d5 * 10000 + d4 * 1000 + d3 * 100 + d2 * 10 + d1;
    Console.WriteLine(num);
}

Console.WriteLine("Введите пятизначное число:");
int n = Convert.ToInt32(Console.ReadLine());
if (n > 99999 || n < 10000)
{
    Console.WriteLine("Вы ввели не пятизначное число");
}
else
{
    Reverse(n);
}