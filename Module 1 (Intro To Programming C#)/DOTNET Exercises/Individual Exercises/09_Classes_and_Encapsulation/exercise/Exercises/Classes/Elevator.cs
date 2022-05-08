namespace Exercises.Classes
{
    public class Elevator
    {
        //properties
        public int CurrentLevel { get; private set; }
        public int NumberOfLevels { get; private set; }
        public bool DoorIsOpen { get; private set; }

        //constructor
        public Elevator(int numberOfLevels)
        {
            NumberOfLevels = numberOfLevels;
        }

        //methods
        public void OpenDoor()
        {
            DoorIsOpen = true;
        }
        public void CloseDoor()
        {
            DoorIsOpen = false;
        }
        public void GoUp(int desiredFloor)
        {
            if (DoorIsOpen == false)
            {
                if (desiredFloor <= NumberOfLevels)
                {
                    if (desiredFloor > CurrentLevel)
                    {
                        CurrentLevel = desiredFloor;
                    }
                }
            }
        }
        public void GoDown(int desiredFloor)
        {
            if (DoorIsOpen == false)
            {
                if (desiredFloor > 0)
                {
                    if (desiredFloor < CurrentLevel)
                    {
                        CurrentLevel = desiredFloor;
                    }
                }
            }
        }
    }
}
