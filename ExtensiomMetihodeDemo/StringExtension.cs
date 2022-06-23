namespace ExtensiomMetihodeDemo;
internal static class StringExtension
{
    public static string AddNameToStart(this string str, string name)
    {
        return $"{name}{str}";
    }
}
