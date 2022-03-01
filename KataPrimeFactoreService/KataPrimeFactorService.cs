namespace KataPrimeFactoreService;

/// <summary>
/// Write a class named “PrimeFactors” that has one static method: generate.
/// The generate method takes an integer argument and returns a List.That list contains the prime factors in numerical sequence.
/// For example:
/// 100 should return 2, 2, 5, 5
/// 2 should return 2
/// Smaller than 2 should return an empty list
/// </summary>
public class KataPrimeFactorService
{
    public static List<int> Generate(int number)
    {
        List<int> result = new List<int>();

        if (number < 2)
        {
            return new List<int>();
        }

        int i = 2;
        while(1 < number)
        {
            if (number % i == 0)
            {
                result.Add(i);
                number /= i;
            }
            else
            {
                i++;
            }
        }

        return result;

    }
}
