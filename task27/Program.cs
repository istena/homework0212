//38 Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
Console.Clear();
void InputArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(0,100);
}
double MinEl(double [] array)
{
    double min=array[0];;
    for (int i = 1; i < array.Length; i++){
        if(array[i]<min) min=array[i];
    }
    return min;
} 
double MaxEl(double [] array)
{
    double max=array[0];;
    for (int i = 1; i < array.Length; i++){
        if(array[i]>max) max=array[i];
    }
    return max;
} 
Console.Write("Введите количество чисел: ");
int a= Convert.ToInt32(Console.ReadLine());
double []array=new double [a];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
double min=MinEl(array);
double max=MaxEl(array);
Console.Write($"Разница между максимальным и минимальным элемнтом {max-min}");
