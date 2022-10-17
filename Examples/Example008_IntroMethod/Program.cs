int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int a1 = 42;
int a2 = 94;
int a3 = 12;
int b1 = 2;
int b2 = 77;
int b3 = 5;
int c1 = 96;
int c2 = 324;
int c3 = 23;

int max = Max(
    Max(a1,a2,a3),
    Max(b1,b2,b3),
    Max(c1,c2,c3));


Console.WriteLine(max);