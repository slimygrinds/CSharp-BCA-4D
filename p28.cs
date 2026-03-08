// Count Positive and Negative Numbers using array
using System;

public class Program{
    static void Main(){
    
        int[] arr = new int[5]; 
        int Positive = 0, Negative = 0;

        Console.WriteLine("Enter 5 Values: ");
        
        for(int i=0; i<5; i++){
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        for(int i=0; i<5; i++){
            if(arr[i] > 0){
                Positive ++;
            }
            else if(arr[i] < 0){
                Negative ++;
            }
        }

        Console.WriteLine("Total Positive Numbers: " + Positive);
        Console.WriteLine("Total Negative Numbers: " + Negative);
    }
}
