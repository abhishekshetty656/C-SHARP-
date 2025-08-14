using System;

class palindrome
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a string to check if it is a palindrome:");
        string input = Console.ReadLine();
        
        if (IsPalindrome(input))
        {
            Console.WriteLine($"'{input}' is a palindrome.");
        }
        else
        {
            Console.WriteLine($"'{input}' is not a palindrome.");
        }
    }
    static bool IsPalindrome(string str)
    {
        if (string.IsNullOrEmpty(str))
            return false;
        int left = 0;
        int right = str.Length - 1;
        while (left < right)
        {
            if (char.ToLower(str[left]) != char.ToLower(str[right]))
                return false;
            left++;
            right--;
        }
        return true;
    }
}