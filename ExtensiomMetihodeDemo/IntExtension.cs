namespace ExtensiomMetihodeDemo;

public static class IntExtension
{
    public static int Pow(this int num, int exp)
    {
        return (int)Math.Pow(num, exp);
    }

    public static string ConcatTwoNumsToToStr(this int num1, int num2, string str)
    {
        return $"{num2} - {str} - {num1}";
    }
}
