int[] array = {42,94,12,2,77,5,34,268,34, 92};
int n = array.Length;
int find = 34;

int i = 0;

while (i<n)
{
    if (array[i] == find)
    {
        Console.WriteLine(i);
        break;
    }
    i++;
}

