using System;

class poblem9{
	
	static void Main(String[] args){
		int[] array = new int[100];
		int length = 101;
		while(length > 100){
			Console.WriteLine("Write an array length lower than 100");
			length = Convert.ToInt32(Console.ReadLine());
		}
		for(int i = 0; i < length; i++){
			Console.WriteLine("Element no {0}", i + 1);
			array[i] = Convert.ToInt32(Console.ReadLine());
		}
		Console.WriteLine("The sum of all element is: {0}", getSum(array, length, 0));
	}

	private static int getSum(int[] array, int length, int index){
		if(index < length){
			return getSum(array, length, index + 1) + array[index];
		}
		return array[length];
	}
}