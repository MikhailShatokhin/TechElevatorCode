namespace Exercises
{
    public partial class StringExercises
    {
        /*
        Given a string and an int n, return a string made of the first and last n chars from the string. The
        string length will be at least n.
        NTwice("Hello", 2) → "Helo"
        NTwice("Chocolate", 3) → "Choate"
        NTwice("Chocolate", 1) → "Ce"
        */
        public string NTwice(string str, int n)
        {
            int length = str.Length-n;

            string first3 = str.Substring(0, n);
            string last3 = str.Substring(length, n);
            string result = first3 + last3;
            return result;
        }
    }
}
