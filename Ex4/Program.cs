// Напишите программу, которая выводит массив из 8 элементов,
//заполненный нулями и единицами в случайном порядке.
//[1,0,1,1,0,1,0,0]

Console.Clear();

Random_massiv8();

void Random_massiv8(){
int[] massiv = new int[8];
int i=0;
Console.Write("Массив из 8 элементов из 0 и 1: ");
for (i = 0; i<=7; i++){
Random rnd = new Random();
massiv[i]  = rnd.Next(0, 2);
Console.Write(massiv[i]);
}
}