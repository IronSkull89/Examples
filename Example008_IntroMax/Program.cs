int Max(int arg1, int arg2, int arg3)
{
int result = arg1;
if (result < arg2) result = arg2;
if (result < arg3) result = arg3;
return result;
};

int a1 = 23;
int b1 = 65;
int c1 = 21;
int a2 = 80;
int b2 = 54;
int c2 = 40;
int a3 = 15;
int b3 = 10;
int c3 = 1;

int max = Max(Max(a1,b1,c1),
              Max(a2,b2,c2),
              Max(a3,b3,c3));

Console.WriteLine(max);              