
Console.WriteLine("1-masala");
string str = "telefOn";
Console.WriteLine("Int tipidagi x soni kiriting : ");
int a = Convert.ToInt32(Console.ReadLine());
if (a > str.Length)
{
    str = str.ToUpper();
}
else
{
    str = str.ToLower();
}
Console.WriteLine(str);
Console.WriteLine("\n2-masala");
int x = 15;
int y = 10;
if (x>y)
{
    Console.WriteLine("x is greater than y");
}
else
{
    if(x<y)
    {
        Console.WriteLine("x is less than y");
    }
    else
    {
        if (x == y)
        {
            Console.WriteLine("x is equal to y");
        }
        else
        {
            Console.WriteLine("x and y are not comparable ");
        }
    }
}
