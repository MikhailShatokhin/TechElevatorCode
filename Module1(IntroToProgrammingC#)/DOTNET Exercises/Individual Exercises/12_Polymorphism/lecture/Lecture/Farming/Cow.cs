namespace Lecture.Farming
{
    public class Cow : FarmAnimal, ISingable, ISellable
    {
        //Constructors
        public Cow() : base("Cow", "moo")
        {
        }

        //Properties
        public decimal Price { get; } = 500.00M;
    }
}
