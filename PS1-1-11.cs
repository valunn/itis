using System;

public class Test
{
	public static void Main()
	{
		double s,x1,x2,x3,y1,y2,y3;
        x1 = Convert.ToDouble(Console.ReadLine());
        y1 = Convert.ToDouble(Console.ReadLine());
        x2 = Convert.ToDouble(Console.ReadLine());
        y2 = Convert.ToDouble(Console.ReadLine());
        x3 = Convert.ToDouble(Console.ReadLine());
        y3 = Convert.ToDouble(Console.ReadLine());

        s = ((x1-x3) * (y2-y3) - (x2-x3) * (y1-y3)) / 2;

        Console.WriteLine(s);
	}
}