// Задача 28: Напишите программу,
//которая принимает на вход число M и N и
//выдаёт произведение чисел от M до N.
//2,4 -> 24
//1,5 -> 120

Console.Clear();
Console.WriteLine("Введите первое число : ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число : ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Произведение чисел от {m} до {n} = {proizvedenie(m,n)}");

int proizvedenie(int m, int n){
int proizved=1;
for (int i=m;i<=n;i++) {
    proizved=proizved*i;
}
return proizved;
}


