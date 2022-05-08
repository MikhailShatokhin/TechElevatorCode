namespace Exercises
{
    public partial class StringExercises
    {
        /*
        Given a string, return a version where all the "x" have been removed. Except an "x" at the very start or end
        should not be removed.
        StringX("xxHxix") → "xHix"
        StringX("abxxxcd") → "abcd"
        StringX("xabxxxcdx") → "xabcdx"
        */
        public string StringX(string str)
        {
            int length = str.Length;
            string space = "";

            for (int i = 0; i < length; i++)
            {
                char result = str[i];
                if (!(i>0 && i<length-1 && result=='x'))
                {
                    space += result;
                }



                
            }
            return space;
        }
    }
}
