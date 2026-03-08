// Calculate Sum and Average

using System;

class Program(){
    static void Main(){
        int [] marks = new int[5];
        int total = 0;
        
        Console.WriteLine("Enter The Marks of 5 Students: ");

        for (int i = 0; i < marks.Length; i++)
        {
            marks[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = 0; i < marks.Length; i++)
        {
            total = total + marks[i];
        }

        Console.WriteLine("Total Marks of 5 Students is: "+total);

        int Average = total / 5;

        Console.WriteLine("Average Marks of 5 Student is: "+Average);

    }
}
