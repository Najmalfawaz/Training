using System;

class Program
{
	static void Main(String[] args)
	{
		int decNum = 0;
		int binNum = 0;

		string tempRun = "";

		Console.WriteLine("Enter a decimal number : ");
		decNum = Convert.ToInt32(Console.ReadLine());

		while (decNum >= 1)
		{
			tempRun += (decNum % 2).ToString();
			decNum = decNum / 2;
		}
		for (int i = tempRun.Length - 1; i >= 0; i--)
		{
			binNum = binNum * 10 + tempRun[i] - 0x30;
		}
		Console.WriteLine("Binary Number:" + binNum);
	}
}