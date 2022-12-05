//Гипотеза Гольдбаха
Console.Clear();
int Prosto(int numbers){
    for (int i=2;i<numbers/2;i++){
        if (numbers%i==0) return 0;       
    }
    return 1;
}
int Task(int res){
    for (int i=2;i<res/2;i++){
        if (Prosto(i)==1){
        if (Prosto(res-i)==1) return i;
        }
    }
    return 0;
}
Console.Write("Введите  чисело: ");
int a= Convert.ToInt32(Console.ReadLine());
int res=Task(a);
if (res!=0){
    Console.Write($"{res}+{a-res}={a}");
}

