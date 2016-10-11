using System;

public class Test
{
	public static void Main()
	{
		double sum,sumold,e,y,z;
        int x,k;
        e = Convert.ToDouble(Console.ReadLine());
        x = Convert.ToInt32(Console.ReadLine());
        sumold = 1;
        y = x;
        z = 1;
        sum = sumold + x;
        k = 1;
        while (Math.Abs(sum - sumold) > e)
        {
            k++;
            y *= x;
            z *= k;
            sumold = sum;
            sum += (y / z);
        }
        Console.WriteLine(sum);
        Console.WriteLine(k);
	}
}