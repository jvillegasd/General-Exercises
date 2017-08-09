using System;

class problem3{
	static void Main(String[] args){
		int lenght;
		int[] vector = new int[100];
		Console.WriteLine("Set the lenght of the array:");
		lenght = Int32.Parse(Console.ReadLine());
		vector = setVector(vector, lenght, 0);
		vector = sortVector(vector, 0, lenght);
		for(int i = 0; i < lenght; i++){ //print the result
			Console.WriteLine(vector[i]);
		}
	}

	static int[] setVector(int[] vector, int lenght, int index){ //I wanted to set the vector like that
		if(index < lenght){
			Console.WriteLine("Write the element of the pos. {0}", index);
			vector[index] = Int32.Parse(Console.ReadLine());
			index++;
			return setVector(vector, lenght, index);
		}
		return vector;
	}

	static int getLowEIndex(int[] vector, int index, int lenght, int lindex, int lower){ //this return the index of the lowest element
		if(index < lenght){
			if(vector[index] < lower){
				lower = vector[index];
				lindex = index;
			}
		    index++;
		    return getLowEIndex(vector, index, lenght, lindex, lower);
		}
		return lindex;
	}

	static int[] sortVector(int[] vector, int index, int lenght){
		if(index < lenght){
			int lindex = getLowEIndex(vector, index, lenght, index, vector[index]);
			int aux = vector[index];
			vector[index] = vector[lindex];
			vector[lindex] = aux;
			index++;
			sortVector(vector, index, lenght);
		}
		return vector;
	}
}