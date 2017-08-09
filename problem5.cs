using System;

class problem5{
	static void Main(String[] args){
		int n;
		Console.WriteLine("Write a number");
		n = Int32.Parse(Console.ReadLine());
		Console.WriteLine("Total: {0}", getSum(n, 0));
	}

	static int getSum(int n, int sum){
		if(n >= 2){
			sum = n + getSum(n - 2, sum);
		}
		return sum;
	}
}