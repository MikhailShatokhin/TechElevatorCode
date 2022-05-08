namespace Exercises
{
    public partial class StringExercises
    {
        /*
        Given 2 strings, return their concatenation, except omit the first char of each. The strings will
        be at least length 1.
        NonStart("Hello", "There") → "ellohere"
        NonStart("java", "code") → "avaode"
        NonStart("shotl", "java") → "hotlava"
        */
        public string NonStart(string a, string b)
        {
            int aLength = a.Length-1;
            int bLength = b.Length-1;

            string aResult = a.Substring(1, aLength);
            string bResult = b.Substring(1, bLength);

            string result = aResult + bResult;

            return result;
        }
    }
}
