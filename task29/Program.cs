//36
Console.Clear();
void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-100, 100);
}
int Count(int[] array)
{
    int sum=0;
    for (int i = 0; i < array.Length; i++){
        if(i%2==1)  sum+=array[i];
    }
    return sum;
} 
Console.Write("Введите количество чисел: ");
int a= Convert.ToInt32(Console.ReadLine());
int []array=new int [a];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
Console.Write($"Сумма элементов стоящих на нечетных местах: {Count(array)}");