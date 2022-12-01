Console.Clear();
Console.Write("Введите первое число: ");
int a= Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b= Convert.ToInt32(Console.ReadLine());
int res=1;
for (int i=0;i<b;i++){
    res=res*a;
}
Console.Write($"{a} в степени {b} равно {res} ");