
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
Console.WriteLine("\n\n2-masala");
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


Console.WriteLine("3-masala \n");
Console.WriteLine("uzbekcha hafta kunini kiriting :");
string uz = Console.ReadLine();
string eng = uz switch
{
    "dushanba" => "Monday",
    "seshanba" => "Tuesday",
    "chorshanba" => "Wednesday",
    "payshanba" => "Thursday",
    "juma" => "Friday",
    "shanba" => "Saturday",
    "yakshanba" => "Sunday",

};
Console.WriteLine($"uzbek tilidagi {uz } hafta kuni engilis tilida {eng} bo'ladi .");
