using System;

public class Test
{
	public static void Main()
	{
		int a,b,t,pr;
        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());
        pr = a * b;

        if (a < b)
        {
            t = b; b = a; a = t;
        }

        while (a != b) 
        {
            a %= b;
            t = b; b = a; a = t;
        }

        Console.WriteLine(pr / a);
	}
}