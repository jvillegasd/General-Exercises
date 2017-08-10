using System;

class problem6{
	static void Main(String[] args){
		int m, n;
		Console.WriteLine("Write m:");
		m = Int32.Parse(Console.ReadLine());
		Console.WriteLine("Write n:");
		n = Int32.Parse(Console.ReadLine());
		if(m > n){
			Console.WriteLine("MCD of {0}, and {1} is = {2}", m, n, getMCD(m, n));
		}else{
			Console.WriteLine("MCD of {0], and {1} is = {2}", n, m, getMCD(n, m));
		}
	}

	static double getMCD(double m, double n){
		if(n == 0){
			return m;
		}
		return getMCD(n, m % n);
	}
}