using System;

public class Class1
{
	public Class1()
	{
		static void main(string[] args)
		{
            int[] arr = new int[5];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            
            Console.ReadLine();
        }
	}
}
