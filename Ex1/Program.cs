// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
//7 -> 28
//4 -> 10
//8 -> 36

Console.Clear();
Console.WriteLine("Введите число А: ");
int limit = int.Parse(Console.ReadLine());

Console.WriteLine($"Результат суммы чисел от 1 до {limit} = {GetSumma(limit)}");


int GetSumma(int limit){
    int summa =0;
    for (int i=0; i<=limit; i++) {
         summa+=i;
    }
    return summa;
}
