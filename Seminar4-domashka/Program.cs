Console.Clear();
Console.WriteLine("Введите номер задачи (25, 27 или 29) для проверки:");
int num = int.Parse(Console.ReadLine());
if(num==25) Task25();
else if(num==27) Task27();
else if (num==29) Task29();
else Console.WriteLine("Дополнительные задачи не выполняла.");

void Task25(){
   
// Задача 25: Напишите цикл, который принимает
//на вход два числа (A и B) и возводит число A в
//натуральную степень B.
Console.Clear();
Console.WriteLine("Введите основание степени А: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите показатель степени В: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Значение степени с основание {a} и показателем {b} = {stepen(a,b)}");

int stepen(int a, int b){
int stepen=1;
for (int i=1;i<=b;i++) {
    stepen=stepen*a;
}
return stepen;
}
};


void Task27(){
   
// Задача 27: Напишите программу, которая принимает на вход число и 
//выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.Clear();
Console.WriteLine("Введите число : ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма цифр в числе {number} = {num_summ(number)}");

int num_summ(int number){
int sum=0;
while(number!=0){
      int k=number%10;
      sum = sum+k;
      number=number/10;

}
return sum;
};
}

void Task29(){
// Задача 29: Напишите программу, которая задаёт массив из N элементов 
//и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

Console.Clear();
Console.WriteLine("Введите размерность массива: ");
int razmer = Convert.ToInt32(Console.ReadLine());

int[] massiv = new int[razmer];
massiv=Rand_mass(massiv);
Console.Write(String.Join(",",massiv));


int [] Rand_mass(int[] massiv_local){
    int i=0;
    Random rnd =new Random();
    for (i=0;i<massiv_local.Length;i++){
      massiv_local[i]  = rnd.Next();
    }
    return massiv_local;
}
};