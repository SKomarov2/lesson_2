// int n = 5;
int[] array = { 5, 6, 8, 20, 12 };
int i=0;
int max = array[0];
while(i < array.Length)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    i++;
}
Console.WriteLine(max);