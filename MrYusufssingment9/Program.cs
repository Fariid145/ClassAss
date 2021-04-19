using System;


public class MrYusufssignment9
{
    static void Main(string[] args)
    {
        Console.WriteLine(removeOneChar("fariiiiiiiiiiiid", 1));
       
    }
    public static string removeOneChar(string name, int n)
    {
        return name.Remove(n, 1);
    }
}