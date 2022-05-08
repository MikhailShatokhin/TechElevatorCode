namespace Exercises
{
    public partial class StringExercises
    {
        /*
        Given a string, return a version without both the first and last char of the string. The string
        may be any length, including 0.
        WithoutEnd2("Hello") → "ell"
        WithoutEnd2("abc") → "b"
        WithoutEnd2("ab") → ""
        */
        public string WithoutEnd2(string str)
        {

            int length = str.Length;
            int length2 = str.Length - 2;
            if(length<=2)
            {
                string result = "";
                return result;

            }
            else
            {
                string result = str.Substring(1, length2);
                return result;
            }

            
        }
    }
}
