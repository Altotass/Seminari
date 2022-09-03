// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void YYY()
{ Console.WriteLine("Введите размер массива ");
int x = Convert.ToInt32(Console.ReadLine());
int [] mass = new int[x];
Random r = new Random();
int count = 0;
QQQ(mass);
        Console.WriteLine();
        Console.WriteLine("=======================================");
            for (int i = 0; i < mass.Length; i++)
                if (mass[i] %2 == 0)
                count++;
                    Console.WriteLine($"В массиве {x} чисел, из них чётных {count}");
                    Console.WriteLine("=======================================");

void QQQ (int[] mass)
{         for(int i = 0; i < x; i++)
        {         mass[i] = r.Next(100,1000);
        Console.Write($"{mass[i]},");
        }
}
}
YYY();