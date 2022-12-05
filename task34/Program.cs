//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
Console.Clear();
void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100, 1000);
}
int Count(int[] array)
{
    int count=0;
    for (int i = 0; i < array.Length; i++){
        if(array[i]%2 == 0)  count++;
    }
    return count;
} 
Console.Write("Введите количество чисел: ");
int a= Convert.ToInt32(Console.ReadLine());
int []array=new int [a];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
Console.Write($"Количество четных чисел: {Count(array)}");
