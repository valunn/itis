using System;

public class Test
{
	public static void Main()
	{
		int n = int.Parse(Console.ReadLine());
        
        if ((n == 0) || (n == 1)) { Console.WriteLine(1); }
        else if (n == 2) { Console.WriteLine(2); }
        else if (n == 3) { Console.WriteLine(6); }
        else if (n == 4) { Console.WriteLine(4); }
        else { Console.WriteLine(0); }
	}
}