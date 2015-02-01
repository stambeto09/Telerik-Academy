using System;

namespace Phone
{
    public class Display
    {
        //Fields
        private ulong height;
        private ulong width;
        private uint numberOfColours;

        //Properties
        public ulong Height 
        { 
            get 
            { return this.height;}

            set
            {
                this.height = value;
            }
        }
        public ulong Width
        {
            get
            { return this.width; }

            set
            {
                this.width = value;
            }
        }
        public uint NumberOfColours
        {
            get
            { return this.numberOfColours; }

            set
            {
                this.numberOfColours = value;
            }
        }

        //Constructors
        public Display(ulong heightOfDisplay)
        {
            this.Height = heightOfDisplay;
            width = 0;
            numberOfColours = 0;
        }

        public Display(ulong heightOfDisplay, ulong widthOfDisplay)
            : this(heightOfDisplay)
        {
            this.Width = widthOfDisplay;
        }

        public Display(ulong heightOfDisplay, ulong widthOfDisplay, uint coloursNumber)
            : this(heightOfDisplay, widthOfDisplay)
        {
            this.NumberOfColours = coloursNumber;
        }
    }
}
