namespace Exercises
{
    public partial class StringExercises
    {
        /*
        Given a string, return a string length 1 from its front, unless front is false, in which case
        return a string length 1 from its back. The string will be non-empty.
        TheEnd("Hello", true) → "H"
        TheEnd("Hello", false) → "o"
        TheEnd("oh", true) → "o"
        */
        public string TheEnd(string str, bool front)
        {
            int length = str.Length-1;
            

            if(front)
            {
                string result = str.Substring(0, 1);
                return result;
            }
            else
            {
                string result = str.Substring(length, 1);
                return result;
            }

            
        }
    }
}
