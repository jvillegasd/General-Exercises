using System;

class problem2 {

	static void Main(String[] args) {
		Console.WriteLine("Write the value of n and r");
		String numbers = Console.ReadLine(); //Please write like: number,number Not space please
		int comma = numbers.IndexOf(',');
		int n = Int32.Parse(numbers.Substring(0, comma));
		int r = Int32.Parse(numbers.Substring(comma + 1));
		int C = getFactorial(n)*(getFactorial(r)*getFactorial(Math.Abs(n - r)));
		Console.WriteLine("C = {0}", C);
	}

	static int getFactorial(int n) {
		if(n < 2) {
			return 1;
		}
		return n * getFactorial(n - 1);
	}
}