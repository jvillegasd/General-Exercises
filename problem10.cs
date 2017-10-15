using System;

class problem10{
    
    static void Main(String[] args){
        int[] array = new int[100];
        int length = 101;
        while (length > 100)
        {
            Console.WriteLine("Write an array length lower than 100");
            length = Convert.ToInt32(Console.ReadLine());
        }
        for (int i = 0; i < length; i++)
        {
            Console.WriteLine("Write element {0}", i);
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("The inverted array is: ");
        array = getInvertedArray(array, length, 0);
        for (int i = 0; i < length; i++)
        {
            Console.WriteLine(array[i]);
        }
    }

    private static int[] getInvertedArray(int[] array, int length, int index){
        if (index <= (int)((length - 1)/2))
        {
            int aux = array[index];
            array[index] = array[length - index - 1];
            array[length - index - 1] = aux;
            return getInvertedArray(array, length, index + 1);
        }
        return array;
    }
}