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
int q=0;
for(int i=1;i<=a;i++){
    q=i+s;
    if((q)>(a-1)) q=q%a; 
    newarray[i]=array[q];
}
Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine($"[{string.Join(", ", newarray)}]");