using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Enter student marks(0 to 100): ");
            int marks = int.Parse(Console.ReadLine());

            if (marks < 0 || marks > 100)
            {
                throw new ArgumentOutOfRangeException("Marks should be between 0 and 100.");
            }
            Console.WriteLine("Valid marks entered: " + marks);

        }
        catch (FormatException ex)
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An unexpected error occurred: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Execution completed.");
        }
    }
}