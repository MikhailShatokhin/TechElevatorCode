namespace Exercises
{
    public partial class StringExercises
    {
        /*
        Given a string, return a version without the first and last char, so "Hello" yields "ell".
        The string length will be at least 2.
        WithoutEnd("Hello") → "ell"
        WithoutEnd("java") → "av"
        WithoutEnd("coding") → "odin"
        */
        public string WithoutEnd(string str)
        {
            int length = str.Length-2;
            string firstChar = str.Substring(1, length);
            
            string result = firstChar;
            return result;
        }
    }
}
