using System;

public class Test
{
	public static void Main()
	{
		double sum,sumold,e,k,x,y,z;
        e = Convert.ToDouble(Console.ReadLine());
        x = Convert.ToDouble(Console.ReadLine());
        sumold = x;
        y = x * x * x;
        z = 6;
        sum = sumold + x;
        k = 1;
        while (Math.Abs(sum - sumold) > e)
        {
            k++;
            y *= x * x;
            z *= (2 * k) * (2 * k + 1);
            sumold = sum;
            sum += (y / z);
        }
        Console.WriteLine(sum);
        Console.WriteLine(k);
	}
}
