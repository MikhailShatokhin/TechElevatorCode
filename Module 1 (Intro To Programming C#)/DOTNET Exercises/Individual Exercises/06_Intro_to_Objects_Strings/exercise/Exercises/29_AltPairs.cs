namespace Exercises
{
    public partial class StringExercises
    {
        /*
        Given a string, return a string made of the chars at indexes 0,1, 4,5, 8,9 ... so "kittens" yields "kien".
        AltPairs("kitten") → "kien"
        AltPairs("Chocolate") → "Chole"
        AltPairs("CodingHorror") → "Congrr"
        */
        public string AltPairs(string str)
        {

            string result = "";
           
            for(int i=0; i<str.Length; i+=4)
            {
                result += str.Substring(i, 1);
                if(i+1<str.Length)
                {
                    result += str.Substring(i + 1, 1);
                }
            }
            return result;
        }
    }
}
