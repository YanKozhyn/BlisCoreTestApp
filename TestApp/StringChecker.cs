namespace TestApp;
public static class StringChecker
{
    public static string CheckString(string s, string t)
    {
        if (s == t)
            return "Equal";
        if (s.Length == t.Length)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == t[i]) { continue; }
                var replacedLetters = (s: s[i], t: t[i]);
                if (s.Replace(replacedLetters.s, replacedLetters.t) == t)
                    return $"Replace {replacedLetters.s} {replacedLetters.t}";
                var swapLetters = (s1: s[i], s2: s[i + 1]);
                var swappedString = s[..i] + swapLetters.s2 + swapLetters.s1 + 
                                   new string(s.Skip(i + 2).ToArray());
                if (swappedString == t)
                    return $"Swap {swapLetters.s1} {swapLetters.s2}";
            }
        }
        if (s.Length + 1 == t.Length)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == t[i])
                    continue;
                var insertLetter = t[i];
                if (string.CompareOrdinal(s[i..], t[(i + 1)..]) == 0)
                    return $"Insert {insertLetter}";
            }
        }
        return "Impossible";
    }
}