using System.Reflection.Metadata.Ecma335;
using Spectre.Console;
namespace MathGame;

public class Randomize
{
    private static Random rNum = new Random();
    public static (int, int) GenerateNumbers()
    {
        int num1 = rNum.Next(0, 1000);
        int num2 = rNum.Next(0, 1000);
        return (num1, num2);
    }

    public static (int, int) GenerateDivisionNumbers()
{
    int dividend = rNum.Next(0, 101);

    if (dividend == 0)
    {
        int divisorForZero = rNum.Next(1, 101);
        return (0, divisorForZero);
    }

    List<int> divisors = new List<int>();
    for (int i = 1; i <= dividend; i++)
    {
        if (dividend % i == 0)
            divisors.Add(i);
    }

    int divisor = divisors[rNum.Next(divisors.Count)];
    return (dividend, divisor);
}

}