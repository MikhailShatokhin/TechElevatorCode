namespace Exercises.Classes
{
    public class Airplane
    {
        //Constructor-----------------------------------------------------------
        public Airplane(string planeNumber, int totalFirstClassSeats, int totalCoachSeats)
        {
            PlaneNumber = planeNumber;
            TotalFirstClassSeats = totalFirstClassSeats;
            TotalCoachSeats = totalCoachSeats;
        }

        //Properties------------------------------------------------------------
        public string PlaneNumber { get; private set; }
        public int TotalFirstClassSeats { get; private set; }
        public int BookedFirstClassSeats { get; private set; }
        public int AvailableFirstClassSeats 
        { 
            get
            {
                return TotalFirstClassSeats - BookedFirstClassSeats;
            }
        }
        public int TotalCoachSeats { get; private set; }
        public int BookedCoachSeats { get; private set; }
        public int AvailableCoachSeats 
        {
            get
            {
                return TotalCoachSeats - BookedCoachSeats;
            } 
        }

        //Methods-----------------------------------------------------------------------
        public bool ReserveSeats(bool forFirstClass, int totalNumberOfSeats)
        {
            if(forFirstClass==true)
            {
                if(TotalFirstClassSeats-BookedFirstClassSeats>=totalNumberOfSeats)
                {
                    BookedFirstClassSeats += totalNumberOfSeats;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (TotalCoachSeats - BookedCoachSeats >= totalNumberOfSeats)
                {
                    BookedCoachSeats += totalNumberOfSeats;
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        
    }
}
