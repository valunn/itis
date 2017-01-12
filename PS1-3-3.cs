using System;

public class Test
{
	public static void Main()
	{
		double xo,yo,ro,x,y,r,xmin,ymin,rmin;
        xo = Convert.ToDouble(Console.ReadLine());
        yo = Convert.ToDouble(Console.ReadLine());
        ro = Convert.ToDouble(Console.ReadLine());
        rmin = Double.MaxValue;

        int n = int.Parse(Console.ReadLine());
        for (int i=0; i < n; i++)
        {
            x = Convert.ToDouble(Console.ReadLine());
            y = Convert.ToDouble(Console.ReadLine());
            r = Math.Sqrt( (x-xo)*(x-xo) + (y-yo)*(y-yo) );
            if (r > ro) && (r < rmin)
            {
                rmin = r;
                xmin = x;
                ymin = y;
            }
        }

        Console.WriteLine(xmin);
        Console.WriteLine(ymin);
	}
}