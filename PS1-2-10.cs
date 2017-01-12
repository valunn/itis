using System;
 
public class Test
{
	public static void Main()
	{
		int n = int.Parse(Console.ReadLine());
 
        while (n > 0)
        {
            Console.Write(n % 2);
            n /= 2;
        }
 
        Console.WriteLine();
	}
}