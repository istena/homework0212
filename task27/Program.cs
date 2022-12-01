Console.Clear();
Console.Write("Введите первое число: ");
int a= Convert.ToInt32(Console.ReadLine());
int sum=0;
while ((a/10)>0){
    sum+=(a%10);
    a=a/10;
}
sum+=(a%10);
Console.Write($"Сумма чисел = {sum}  ");
