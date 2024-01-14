// int n = 5;
// int[] array = { 5, 6, 8, 20, 12 };
// int i=0;
// int max = array[0];
// while(i < array.Length)
// {
//     if (array[i] > max)
//     {
//         max = array[i];
//     }
//     i++;
// }
// Console.WriteLine(max);

int[] array = { 5, 56, 8, 20, 40 };
int max = array[0];
for (int i = 0;  i < array.Length; i++)
{
    if (max < array[i])
    {
    max = array[i];
    }
}    
Console.WriteLine(max);

 max = array[0];
 foreach(int e in array)
 {
    if(e > max)
    {
        max = e;
    }
 }
 Console.WriteLine(max);