using System;

public class Program
{
	public static void Main(string[] args)
	{
		int[] arr = new int[5];
		int min = 0;
		
		Console.WriteLine("Enter The Values: ");
		
		for(int i=0; i<5; i++)
		{
			arr[i] = int.Parse(Console.ReadLine());
            min = arr[0];
		}

		for(int i=0; i<5; i++)
		{
			if(arr[i] < min)
			{
				min = arr[i];
			}
		}

		Console.WriteLine("The minimum Value is: " + min);
	}
}
