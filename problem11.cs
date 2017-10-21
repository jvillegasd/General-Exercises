using System;

class problem11{

    static void Main(String[] args){
        String word = "";
        Console.WriteLine("Write a word: ");
        word = Console.ReadLine();
        Console.WriteLine("The word is palindrome? {0}", itsPalindrome(word, word.Length - 1, ""));
    }

    private static bool itsPalindrome(String word, int index, String palindrome){
        if (index == -1)
        {
            return palindrome.Equals(word);
        }
        return itsPalindrome(word, index - 1, palindrome + word.Substring(index, 1));
    }
}