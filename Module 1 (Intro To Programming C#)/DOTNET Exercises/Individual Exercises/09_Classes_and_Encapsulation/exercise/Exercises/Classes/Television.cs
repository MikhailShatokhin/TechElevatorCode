namespace Exercises.Classes
{
    public class Television
    {
        //properties
        public bool IsOn { get; private set; } = false;
        public int CurrentChannel { get; private set; } = 3;
        public int CurrentVolume { get; private set; } = 2;

        //constructor

        //methods
        public void TurnOff()
        {
            IsOn = false;
        }
        public void TurnOn()
        {
            IsOn = true;
            CurrentChannel = 3;
            CurrentVolume = 2;
        }
        public void ChangeChannel(int newChannel)
        {
            if (IsOn)
            {
                if(CurrentChannel>=3 && CurrentChannel<=18)
                {
                    CurrentChannel = newChannel;
                }
            }
        }
        public void ChannelUp()
        {
            if(IsOn)
            {
                CurrentChannel += 1;
                if(CurrentChannel>18)
                {
                    CurrentChannel = 3;
                }
            }
        }
        public void ChannelDown()
        {
            if(IsOn)
            {
                CurrentChannel -= 1;
                if(CurrentChannel<3)
                {
                    CurrentChannel = 18;
                }
            }
        }
        public void RaiseVolume()
        {
            if(IsOn)
            {
                if (CurrentVolume<10)
                {
                    CurrentVolume += 1;
                }
            }
        }
        public void LowerVolume()
        {
            if (IsOn)
            {
                if (CurrentVolume > 0)
                {
                    CurrentVolume -= 1;
                }
            }
        }


    }
}
