using System;

public class Program
{
	public static void Main(string[] args)
	{
		int[] arr = new int[5];
		int max = 0;
		
		Console.WriteLine("Enter The Values: ");
		
		for(int i=0; i<5; i++)
		{
			arr[i] = int.Parse(Console.ReadLine());
		}

		for(int i=0; i<5; i++)
		{
			if(arr[i] > max)
			{
				max = arr[i];
			}
		}

		Console.WriteLine("The Maximum Value is: " + max);
	}
}
