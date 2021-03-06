namespace Lecture.Farming
{
    /// <summary>
    /// A base farm animal class.
    /// </summary>
    public abstract class FarmAnimal : ISingable
    {
        /// <summary>
        /// The farm animal's name.
        /// </summary>
        public string Name { get; }

        private string sound;
        public virtual string Sound
        {
            get
            {
                if (IsAsleep)
                {
                    return "Zzzzzz";
                }
                else
                {
                    return sound;
                }
            }
            set
            {
                sound = value;
            }
        }
        public bool IsAsleep { get; private set; }

        public void Sleep(bool isAsleep)
        {
            IsAsleep = isAsleep;
        }

        

        public abstract string Eat();

        /// <summary>
        /// Creates a new farm animal.
        /// </summary>
        /// <param name="name">The name which the animal goes by.</param>
        /// <param name="sound">The sound that the animal makes.</param>
        public FarmAnimal(string name, string sound)
        {
            Name = name;
            Sound = sound;
        }
        public override string ToString()
        {
            return Name + " - " + Sound;
        }
    }
}
