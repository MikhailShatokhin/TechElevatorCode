namespace Exercises.Classes
{
    public class FruitTree
    {
        //Constructor
        public FruitTree(string typeOfFruit, int startingPiecesOfFruit)
        {
            TypeOfFruit = typeOfFruit;
            PiecesOfFruitLeft = startingPiecesOfFruit;
        }
        //Properties
        public string TypeOfFruit { get; private set; }
        public int PiecesOfFruitLeft { get; private set; }

        //Method
        public bool PickFruit(int numberOfPiecesToRemove)
        {
            if(PiecesOfFruitLeft >= numberOfPiecesToRemove)
            {
                PiecesOfFruitLeft -= numberOfPiecesToRemove;
                return true;
            }
            else
            {
                
                return false;
            }
        }
    }
}
