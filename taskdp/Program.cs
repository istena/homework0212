//task dop2
Console.Clear();
Console.Write("Введите количество чисел: ");
int a= Convert.ToInt32(Console.ReadLine());
int []array=new int [a];
Console.Write("Введите чисела: ");
for(int i=0;i<a;i++){
    array[i]=Convert.ToInt32(Console.ReadLine());
}
Console.Write("Введите сдвиг: ");
int s=Convert.ToInt32(Console.ReadLine());
int []newarray=new int [a];
for(int i=0;i<a;i++){
    if (i<s) newarray[i]=array[i+a-s];
    else newarray[i]=array[i-s];
}
Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine($"[{string.Join(", ", newarray)}]");

