using System;

public class Test
{
	public static void Main()
	{
		int num,n,a,b,c,d,e,f;
        num = int.Parse(Console.ReadLine());

        bool l = false;

        n = num - 1;
        f = n % 10;
        n /= 10;
        e = n % 10;
        n /= 10;
        d = n % 10;
        n /= 10;
        c = n % 10;
        n /= 10;
        b = n % 10;
        a = n / 10;

        if (a+c+e == b+d+f) l = true;
        else
        {
            n = num + 1;
            f = n % 10;
            n /= 10;
            e = n % 10;
            n /= 10;
            d = n % 10;
            n /= 10;
            c = n % 10;
            n /= 10;
            b = n % 10;
            a = n / 10;

            if (a+c+e == b+d+f) l = true;
        }

        Console.WriteLine(l);
	}
}