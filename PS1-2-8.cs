using System;

public class Test
{
	public static void Main()
	{
		double n = Convert.ToDouble(Console.ReadLine());
        int k = Convert.ToInt32(Console.ReadLine());
        double sum = 1;

	    while (k > 0) 
        {
		    if (k % 2 == 1)
			    sum *= n;
	    	n *= n;
		    k >>= 1;
	    }

        Console.WriteLine(sum);
	}
}