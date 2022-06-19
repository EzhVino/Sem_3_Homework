//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N

Console.Clear();

void ListSqrt(int number){
    int count = 1;

    Console.Write(number + " -> ");

    if(number>0){

    while (count<=number){
        Console.Write(Math.Pow(count, 3) + ", ");
        count++;
    }}
    else{
        count = -1;
        while (count>=number){
        Console.Write(Math.Pow(count, 3) + ", ");
        count--;
    }
}}

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
ListSqrt(num);
