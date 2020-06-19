using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("a sayısını gir: ");
		int a=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("b sayısını gir: ");
		int b=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("x sayısını gir: ");
		int x=Convert.ToInt32(Console.ReadLine());
		toplama(a,b,x);
		
	}
	static void toplama(int a, int b, int x)
	{int toplam=0;
		for(int i=a;i<b;i++)
		{
			if(i%x==0)
				toplam=toplam+i;
		}
	 Console.WriteLine(toplam);
	}
}