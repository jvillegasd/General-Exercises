using System;

class problem4{
	static void Main(String[] args){
		int n;
		Console.WriteLine("Write a number");
		n = Int32.Parse(Console.ReadLine());
		Console.WriteLine("Total: {0}", getTotal(n, 0, 0));
	}

	static int getTotal(int n, int sum, int cont){
		if(cont <= n){
			sum = sum + cont;
			cont++;
			return getTotal(n, sum, cont);
		}
		return sum;
	}
}