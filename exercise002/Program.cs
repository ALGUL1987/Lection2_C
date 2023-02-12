/*
Найти максимум из 9 чисел
*/
int max = 0;
int[] array = { 10, 12, 443, 423, 51, 64, 57, 87, 91 };

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }
}
Console.WriteLine(max);