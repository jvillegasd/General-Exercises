using System;

class problem12{

    static void Main(String[] args){
        int number;
        String[] descomposition = new String[100];
        Console.WriteLine("Write a number: ");
        number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("All descomposition of {0} are: ", number);
        descomposition = getDescomposition1(number, descomposition, 0, number);
        int Length = 0;
        for(int i = 0; i < descomposition.Length; i++)
        {
            if(descomposition[i] != null)
            {
                Length++;
            }
        }
        descomposition = getDescomposition2(number, descomposition, Length, number);
        for (int i = 0; i < descomposition.Length; i++)
        {
            Console.WriteLine(descomposition[i]);
        }
    }

    private static String[] getDescomposition1(int number, String[] descom, int index, int numberO){ //(n - 1) + 1
        if (number != 1)
        {
            descom[index] = number - 1 + "";
            for(int i = 0; i <= numberO - number; i++)
            {
              descom[index] = descom[index] + "+1";
            }
            return getDescomposition1(number - 1, descom, index + 1, numberO);
        }
        return descom;
    }
    
    private static String[] getDescomposition2(int number, String[] descom, int index, int numberO){ //(n - 2) + 2
        if(number >= 0)
        {
            if(number > 2)
            {
              descom[index] = number - 2 + "+" + 2;
            }
            if(number <= 2)
            {
              descom[index] = number + "";
            }
            for(int i = 0; i < numberO - number; i++)
            {
                descom[index] = descom[index] + "+1";
            }
            return getDescomposition2(number - 2, descom, index + 1, numberO);
        }
        return descom;
    }
}