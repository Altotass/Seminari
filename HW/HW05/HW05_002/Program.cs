// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void TTT()
{
Console.WriteLine("Введите размер массива");
int x = Convert.ToInt32(Console.ReadLine());
int [] massiv = new int[x];
int sum = 0;
QQQ (massiv);
    for(int j = 0; j < x; j = j+2)
    {     sum = sum + massiv[j];
    }
    Console.WriteLine();
    Console.WriteLine("Сумма цифр на нечетных позициях = " + sum);
    return;
void QQQ (int[] massiv)   // функция заполнения массива
{     Console.Write($"Полученный массив ");
    for(int i = 0; i < x; i++)
    {     massiv[i] = new Random().Next(-10,10);
    Console.Write($"{massiv[i]},");
    }
}
}
TTT ();