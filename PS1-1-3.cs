using System;

public class Test
{
	public static void Main()
	{
		int x1,x2,y1,y2;
        x1 = int.Parse(Console.ReadLine());
        y1 = int.Parse(Console.ReadLine());
        x2 = int.Parse(Console.ReadLine());
        y2 = int.Parse(Console.ReadLine());

        bool l = false;

        if (x1+2 == x2)
        {
            if ((y1+1 == y2)||(y1-1 == y2)) l = true;
        }
        if (x1-2 == x2)
        {
            if ((y1+1 == y2)||(y1-1 == y2)) l = true;
        }
        if (x1+1 == x2)
        {
            if ((y1+2 == y2)||(y1-2 == y2)) l = true;
        }
        if (x1-1 == x2)
        {
            if ((y1+2 == y2)||(y1-2 == y2)) l = true;
        }

        if (l == true) Console.WriteLine("YES");
        else Console.WriteLine("NO");
        
	}
}