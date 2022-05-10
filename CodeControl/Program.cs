// control work

string [] arrayinput = {"Надеюсь", "что", "все", "решил", "правильно", "!"};
int N = 3;
Console.WriteLine();
Console.Write("Исходный массив:  ");
PrintArray (arrayinput);
Console.Write("Новый массив из строк <=" + N +" символов: " );
PrintArray (TrancationArray (arrayinput, N));
Console.WriteLine();
string [] TrancationArray (string [] array, int n)          // метод создания нового массива строк из исходного по заданному кол символов
{
   int count = 0;
   for (int i = 0; i < array.Length; i++) 
   {
       if (array[i].Length <= n) count++;   
   }
   string [] arraynew = new string [count];
   int j = 0;
   for (int i = 0; i < array.Length; i++) 
   {
       if (array[i].Length <= n) 
       {
           arraynew [j] = array[i]; 
           j++;
       }
   }
   return arraynew;
}
void PrintArray (string [] array)                         // метод печати массива
{
    Console.Write ("[ ");
    for (int i = 0; i < array.Length; i++) 
    {
    Console.Write ("'"+ array[i] +"'"+ " ");
    }
    Console.WriteLine ("]");
}
