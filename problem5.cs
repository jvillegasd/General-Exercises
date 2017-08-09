using System;

class problem5{
	static void Main(String[] args){
		int n;
		Console.WriteLine("Write a number");
		n = Int32.Parse(Console.ReadLine());
		if(n % 2 != 0){
			Console.WriteLine("It's impossible to get the sum!");
		}else{
			Console.WriteLine("Total: {0}", getSum(n, 0));
		}
	}

	static int getSum(int n, int sum){
		if(n >= 2){
			sum = n + getSum(n - 2, sum);
		}
		return sum;
	}
}