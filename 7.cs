using System;
 
public class Test
{
	public static void Main()
	{
		double sum,sumold,e,x,y,z,a1,a2;
        int k;
        e = Convert.ToDouble(Console.ReadLine());
 
        x = 5;
        y = 1 / (x * x * x);
        z = 3;
        sumold = - (y / z);
        y /= (x * x);
        z += 2;
        sum = sumold + (y / z);
        k = 2;
        while (Math.Abs(sum - sumold) > e)
        {
            k++;
            sumold = sum;
            y /= (x * x);
            z += 2;
            if (k % 2 == 0) sum += (y / z);
            else sum -= (y / z);
        }
        a1 = sum;
 
        x = 239;
        y = 1 / (x * x * x);
        z = 3;
        sumold = - (y / z);
        y /= (x * x);
        z += 2;
        sum = sumold + (y / z);
        k = 2;
        while (Math.Abs(sum - sumold) > e)
        {
            k++;
            sumold = sum;
            y /= (x * x);
            z += 2;
            if (k % 2 == 0) sum += (y / z);
            else sum -= (y / z);
        }
        a2 = sum;

        Console.WriteLine(a1);
        Console.WriteLine(a2);
        Console.WriteLine(16 * a1 - 4 * a2);
	}
}