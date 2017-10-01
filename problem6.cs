using System;

class problem6{
	static void Main(String[] args){
		int m, n;
		Console.WriteLine("Write m:");
		m = Int32.Parse(Console.ReadLine());
		Console.WriteLine("Write n:");
		n = Int32.Parse(Console.ReadLine());
		if(m > n){
			Console.WriteLine("GCD of {0}, and {1} is = {2}", m, n, getGCD(m, n));
		}else{
			Console.WriteLine("GCD of {0}, and {1} is = {2}", n, m, getGCD(n, m));
		}
	}

	static double getGCD(double m, double n){
		if(n == 0){
			return m;
		}
		return getGCD(n, m % n);
	}
}