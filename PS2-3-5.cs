using System;

public class Test
{
	public static void Main()
	{
		double e,x,x0;
        e = Convert.ToDouble(Console.ReadLine());
        x0 = 0;
        x = Math.Cos(x0);
        while (Math.Abs(x - x0) > e)
        {
            x0 = x;
            x = Math.Cos(x);
        }
        Console.WriteLine(x);
	}
}
