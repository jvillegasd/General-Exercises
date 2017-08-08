using System;

class problem1 {
	static void Main(String[] args) {
		Console.WriteLine("Please, write a number:");
		int n = Int32.Parse(Console.ReadLine());
		Console.WriteLine(getFibonacci(n));
	}

	static int getFibonacci(int n) {
		if(n > 1) {
			return getFibonacci(n - 1) + getFibonacci(n - 2);
		}
		return n;
	}
}