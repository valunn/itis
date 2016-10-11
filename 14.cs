using System;

public class Test
{
	public static void Main()
	{
		double sum,sumold,e,x,y;
        int z,k;
        e = Convert.ToDouble(Console.ReadLine());
        x = Convert.ToDouble(Console.ReadLine());
        sumold = 1;
        z = 2;
        y = x;
        sum = sumold - (y * z);
        k = 1;
        while (Math.Abs(sum - sumold) > e)
        {
            k++;
            z++;
            y *= x;
            sumold = sum;
            if (k % 2 == 0) sum += (y * z);
            else sum -= (y * z);
        }
        Console.WriteLine(sum);
        Console.WriteLine(k);
	}
}