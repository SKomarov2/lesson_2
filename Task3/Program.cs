Console.Write("Введите N1 ");
int N1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N2 ");
int N2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N3 ");
int N3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N4 ");
int N4 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N5 ");
int N5 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N6 ");
int N6 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N7 ");
int N7 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N8 ");
int N8 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N9 ");
int N9 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N10 ");
int N10 = Convert.ToInt32(Console.ReadLine());
int[] Numbers = { N1, N2, N3, N4, N5, N6, N7, N8, N9, N10 };
int index = 0;
while (index < Numbers.Length)
{

    if (Numbers[index] % 2 == 0)
    {
        Console.Write($"{Numbers[index]}, ");  
    }
    index++;
}    
if (index == Numbers.Length)
{
    Console.Write("Всё");
}