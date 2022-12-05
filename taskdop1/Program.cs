//Массивы
Console.Clear();
void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 32);
}
string TaskMas(int[] array)
{
    string res="";
    int sum=0;
    for (int i = 0; i < array.Length; i++){
        if(array[i]%2==0) {
            sum++;
        }
    }
    int [] newarraytri= new int[array.Length-sum];
    int [] newarrayfour= new int[sum];
    int j=0,k=0;
    for (int i = 0; i < array.Length; i++){
        if(array[i]%2==0) {
            newarrayfour[j]=array[i];
            j++;
        }
        else {
            newarraytri[k]=array[i];
            k++;
        } 
    }
    Console.WriteLine($"[{string.Join(", ", newarraytri)}]");
    Console.WriteLine($"[{string.Join(", ", newarrayfour)}]");
    if (j>k) res="YES";
    else if(j<k) res="NO";
    else res="3.5 балла";

    return res;
} 
Console.Write("Введите количество чисел: ");
int a= Convert.ToInt32(Console.ReadLine());
int[] array = new int[a];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
string res=TaskMas(array);
Console.WriteLine(res);











