using System;

public class Test
{
	public static void Main()
	{
		int n,sum;

        sum  = 0;

        n = 3;
        while (n < 1000) 
        {
            sum += n;
            n += 3;
        }

        n = 5;
        while (n < 1000) 
        {
            if (n % 3 != 0) sum += n;
            n += 5;
        }

        Console.WriteLine(sum);
	}
}