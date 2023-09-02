
Console.WriteLine("Hello, World!");
string str = "telefOn";
int x = Convert.ToInt32(Console.ReadLine());
if (x > str.Length)
{
    str = str.ToUpper();
}
else
{
    str = str.ToLower();
}
Console.WriteLine(str);