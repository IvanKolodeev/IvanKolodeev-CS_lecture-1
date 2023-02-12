int max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2>result)  result = arg2;
    if (arg3>result)  result = arg3;
    return result;
}

int num1 = 15;
int num2 = 21;
int num3 = 39;
int num4 = 12;
int num5 = 23;
int num6 = 33;
int num7 = 13;
int num8 = 23;
int num9 = 35;

// int max1 = max(num1, num2, num3);
// int max2 = max(num4, num5, num6);
// int max3 = max(num7, num8, num9);
// int max4 = max(max1, max2, max3);
//Console.WriteLine(max1 + " " + max2 + " " + max3);

int max4 = max(max(num1, num2, num3), max(num4, num5, num6), max(num7, num8, num9));

Console.WriteLine(max4);
