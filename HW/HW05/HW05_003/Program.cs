// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.WriteLine("Введите размер массива ");
int x = Convert.ToInt32(Console.ReadLine());
double [] massiv = new double[x];
double NumMin = Int32.MaxValue;  // ????? Вопрос преподавателю!!! если ставлю massiv[0] , то получаю NumMin = 0
double NumMax = massiv[0];
QQQ (massiv);
    for(int i = 0; i < x; i++)
        {
        if (NumMin > massiv[i]) NumMin = massiv[i];
        if (NumMax < massiv[i]) NumMax = massiv[i];
        }
        Console.WriteLine($" Минимальное число = {NumMin}");
        Console.WriteLine($" Максимальное число = {NumMax}");
        Console.WriteLine($" Разница между ними = " + (NumMax - NumMin));
void QQQ (double[] massiv)   // функция заполнения массива
{ 
    Console.Write($"Полученный массив  ");
    for(int i = 0; i < x; i++)
    {
    massiv[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;  // Превратили в вещественный вид
    Console.Write($"{massiv[i]}; ");
    }
    Console.WriteLine();
}