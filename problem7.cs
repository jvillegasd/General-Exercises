using System;

class problem7{

	static void Main(String[] args){
		int number;
		Console.WriteLine("Write a number please:");
		number = Int32.Parse(Console.ReadLine());
		Console.WriteLine("The number {0} in binary is: {1}", number, getBinary(number));
	}

	static String getBinary(int number){
	  if(number != 0){
	    return getBinary(number / 2) + ((number % 2));
	  }
	  return "";
	}	
}