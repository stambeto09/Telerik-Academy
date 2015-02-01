using System;

namespace Phone
{
    public class Battery
    {
        //Fields
        private string modelOfBattery;
        private uint hoursIdle;
        private uint hoursTalk;

        public string ModelOfBattery
        {
            get
            { 
                return this.modelOfBattery;
            }
            set
            {
                if (value.Length <=2)
                {
                    throw new FormatException("Your name is too short!");
                }
                else
                {
                    this.modelOfBattery = value;
                }
            }
        }
        public uint HoursIdle
        {
            get { return this.hoursIdle; }
            set 
            {
                if (value>uint.MaxValue)
                {
                    throw new OverflowException("Value was either too large or too small for a idle hours.");
                }
                else if (value<0)
                {
                    throw new ArgumentException("The hours cannot be negative number.");
                }
                else
                {
                    this.hoursIdle = value; 
                }
                
            }
        }
        public uint HoursTalk
        {
            get { return this.hoursTalk; }

            set 
            {
                if (value > uint.MaxValue)
                {
                    throw new OverflowException("Value was either too large or too small for a idle hours.");
                }
                else if (value < 0)
                {
                    throw new ArgumentException("The hours cannot be negative number.");
                }
                else
                {
                    this.hoursTalk = value;
                }
                
            }
        }
        //Constructors
        public Battery(string modelOfBattery)
        {
            this.ModelOfBattery = modelOfBattery;
            hoursIdle = 0;
            hoursTalk = 0;
        }
        public Battery(string modelOfBattery, uint hoursIdle)
            : this(modelOfBattery)
        {
            this.HoursIdle = hoursIdle;
        }
        public Battery(string modelOfBattery, uint hoursIdle, uint hoursTalk)
            : this(modelOfBattery, hoursIdle)
        {
            this.HoursTalk = hoursTalk;
        }
        //Enums
        public enum BatteryType
        {
            LiIon, NiMH, NiCd
        }

        //BatteryType batteryType;

    }
}
