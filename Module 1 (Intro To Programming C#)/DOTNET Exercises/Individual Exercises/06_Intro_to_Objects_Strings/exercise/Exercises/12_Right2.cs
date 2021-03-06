namespace Exercises
{
    public partial class StringExercises
    {
        /*
        Given a string, return a "rotated right 2" version where the last 2 chars are moved to the start.
        The string length will be at least 2.
        Right2("Hello") → "loHel"
        Right2("java") → "vaja"
        Right2("Hi") → "Hi"
        */
        public string Right2(string str)
        {
            int length = str.Length - 2;

            string lastTwoChar = str.Substring(length, 2);
            string remainingChars = str.Substring(0, length);

            string result = lastTwoChar + remainingChars;

            return result;
            
        }
    }
}
