using System;

public class Test
{
	public static void Main()
	{
		int a;
        a = int.Parse(Console.ReadLine());
        while (a != 0)
        {
            if (a < 0)
            {
                Console.WriteLine(Math.Abs(a));
            }
            else
            {
                d = 1;
                while (d < a) d *= 2;
                Console.WriteLine(a);
            }
            a = int.Parse(Console.ReadLine());
        }
	}
}