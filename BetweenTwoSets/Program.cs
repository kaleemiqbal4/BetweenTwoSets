namespace BetweenTwoSets;
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter First Set number of elements");
        int numberofFirstSet = Convert.ToInt32(Console.ReadLine());
        int[] setOne = new int[numberofFirstSet];
        for (int i = 0; i < numberofFirstSet; i++)
        {
            Console.WriteLine($"Enter First Set index {i} elements");
            setOne[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Enter Second Set number of elements");
        int numberofSecondSet = Convert.ToInt32(Console.ReadLine());
        int[] setTwo = new int[numberofSecondSet];
        for (int i = 0; i < numberofSecondSet; i++)
        {
            Console.WriteLine($"Enter Second Set index {i} elements");
            setTwo[i] = Convert.ToInt32(Console.ReadLine());
        }

        int result = getTotalX(setOne, setTwo);
        Console.WriteLine("---------------------");
        Console.WriteLine($" Output of two sets is {result}");
        Console.WriteLine("---------------------");
    }

    public static int getTotalX(int[] a, int[] b)
    {
        // Find the maximum value of a and minimum value of b
        int maxA = a.Max();
        int minB = b.Min();

        int count = 0;

        // Check each number in the range from maxA to minB
        for (int i = maxA; i <= minB; i += maxA)
        {
            bool isFactorOfAllB = b.All(x => x % i == 0);
            bool isDivisibleByAllA = a.All(x => i % x == 0);

            if (isFactorOfAllB && isDivisibleByAllA)
            {
                count++;
            }
        }

        return count;
    }
}
