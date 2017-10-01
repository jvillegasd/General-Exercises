using System;

class problem8{

	static void Main(String[] args){
		Console.WriteLine("Digit yor binary number please:");
		String binarynum = Console.ReadLine();
		Console.WriteLine("Your binary number: {0} is {1} in base 10.", binarynum, getBase10(binarynum, binarynum.Length - 1, 0));
	}

	private static double getBase10(String binarynum, int exponent, int index){
		if(exponent > -1){
			if(binarynum.Substring(index, 1).Equals("1")){
				return getBase10(binarynum, exponent - 1, index + 1) + (Math.Pow(2, exponent));
			}else{
				return getBase10(binarynum, exponent - 1, index + 1);
			}
		}
		return 0;
	}
}