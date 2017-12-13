using System;
					
public class Program
{
	public static void Main()
	{
		int[] a = {1, 2, 3, 4, 5};
		a = RotateRight(a);
		
		foreach(int x in a)
		{
			Console.Write(x);
		}
	}
	
	public static int[] RotateLeft(int[] a)
	{
		int[] b = new int[a.Length];
		
		for (int i = 1; i < a.Length; i++){
			b[i-1] = a[i];
		}
		b[a.Length-1] = a[0];
		return b;
	}
	
	public static int[] RotateRight(int[] a)
	{
		int[] b = new int[a.Length];
		
		for (int i = 1; i < a.Length; i++){
			b[i] = a[i-1];
		}
		b[0] = a[a.Length-1];
		return b;
	}
}
