// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
//456 -> 3
//78 -> 2
//5 - > 1
//89126 -> 5

Console.Clear();
Console.WriteLine("Введите число : ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Количество цифр в числе {number} = {num_count(number)}");

int num_count(int number){
int j=0;
while(number!=0){
   number = number/10;
      j=j+1;
}
return j;
}


