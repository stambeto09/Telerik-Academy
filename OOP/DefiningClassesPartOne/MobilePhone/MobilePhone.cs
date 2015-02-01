using System;
using System.Text;
using System.Collections.Generic;

namespace Phone
{
    public class MobilePhone
    {
        //Fields
        private string model;
        private string manufacturer;
        private decimal price;
        private string nameOwner;
        private static MobilePhone Iphone4S;
        private List<Call> CallHistory;
        
        public string Model
        {
            get { return this.model; }
            set
            {
                if (value.Length<2)
                {
                    throw new FormatException("The name is too short!");
                }
                else
                {
                    this.model = value;
                }
            }
        }
        public string Manufacturer
        {
            get { return this.manufacturer; }
            set
            {
                if (value.Length<=1)
                {
                    throw new FormatException("The name of the manufacturer is too short!");
                }
                else
                {
                    this.manufacturer = value;
                }
            }
        }
        public string Name
        {
            get { return this.nameOwner; }

            set 
            {
                if (value.Length <= 1)
                {
                    throw new FormatException("The name of the owner is too short!");
                }
                else
                {
                    this.nameOwner = value;
                }
                
            }
        }
        public decimal Price
        {
            get
            {
                { return this.price; }
            }
            set
            {
                if (value < 0)
                {
                    throw new FormatException("The price should be positive!");
                }
                else
                {
                    this.price = value;
                }

            }
        }

        //Constructors
        public MobilePhone(string model, string manufacturer)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            price = 0.0m;
            nameOwner = null;
        }

        public MobilePhone(string model, string manufacturer, decimal price)
            : this(model, manufacturer)
        {
            this.Price = price;
        }

        public MobilePhone(string model, string manufacturer, decimal price, string nameOwner)
            : this(model, manufacturer, price)
        {
            this.Name = nameOwner;
        }
        static MobilePhone()
        {
            Iphone4S = new MobilePhone("Iphone4S", "USA");
        }
        public static MobilePhone Iphone4s
        {
            get { return Iphone4S; }
        }
        //Methods
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Model:" + this.model);
            sb.Append("\nManufacturer:" + this.manufacturer);
            sb.Append("\nPrice:" + this.price);
            sb.Append("\nOwner:" + this.nameOwner);
            string testStr = sb.ToString();
            
            return testStr;
        }

        public void MakeCall(DateTime dateCallIsMade, string dialedNumber, uint duration)
        {
            if (dialedNumber.Length < 10)
            {
                throw new ArgumentException("Dialed number is wrong!");
            }
            Call newItem = new Call(DateTime.Now, dialedNumber, duration);
            CallHistory.Add(newItem);
        }
       
        
        public void ClearCallHistory()
        {
            CallHistory.Clear();
        }

        public void DeleteCall(int number)
        {
            CallHistory.Remove(CallHistory[number]);
        }

        public void CalculateTotalSum(decimal callHistoryLength)
        {
            decimal priceOfCalls = 0;
            priceOfCalls = callHistoryLength * 0.37m;
            Console.WriteLine("The price of the calls is: {0}", priceOfCalls);
        }

    }
}

