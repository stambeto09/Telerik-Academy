using System;
using System.Linq;

namespace UsingLoopsConditionStates
{
    class Kitchen
    {
        public static void Cook(Vegetable vegetable)
        {

        }

        public static void VisitCell()
        {

        }
        static void Main()
        {
            Potato potato = new Potato();

            if (potato != null)
            {
                if (potato.IsPeeled && !potato.IsRotten)
                {
                    Cook(potato);
                }
            }
               
            int currentRow = 0;
            int minRow = 0;
            int maxRow = 0;
            
            int currentCol = 0;
            int minCol = 0;
            int maxCol = 0;
            
            bool isCellVisited = false;

            bool isRowInRange = (currentRow >= minRow) && (currentRow <= maxRow);
            bool isColInRange = (currentCol >= minCol) && (currentCol <= maxCol);
            if (isRowInRange && isColInRange && isCellVisited)
            {
                 VisitCell();
            }

        }
        class Vegetable
        {
            private bool isCutted = false;
            private bool isPeeled = false;

            public bool IsPeeled
            {
                set
                {
                    this.isPeeled = value;
                }
            }

            public bool IsCutted
            {
                set
                {
                    this.isCutted = value;
                }
            }

        }
        class Potato : Vegetable
        {
            private bool isRotten = false;

            public bool IsRotten 
            {
                set
                {
                    this.isRotten = value;
                } 
            }
        }

        class Carrot : Vegetable
        {
           
        }

        class Bowl
        {
            public void Add(Vegetable vegetable)
            {

            }
        }

        public class Chef
        {
            private Carrot GetCarrot()
            {
                Carrot carrot = new Carrot();
                return carrot;
            }

            private Potato GetPotato()
            {
                Potato potato = new Potato();
                return potato;
            }

            private void Peel(Vegetable vegetable)
            {
                vegetable.IsPeeled = true;
            }

            private void Cut(Vegetable vegetable)
            {
                vegetable.IsCutted = true;
            }

            private Bowl GetBowl()
            {
                Bowl bowl = new Bowl();
                return bowl;
            }

            public void Cook()
            {
                Potato potato = GetPotato();
                Carrot carrot = GetCarrot();
                
                Peel(potato);
                Peel(carrot);

                Cut(potato);
                Cut(carrot);

                Bowl bowl = GetBowl();
                bowl.Add(carrot);
                bowl.Add(potato);
            }
            
        }

    }
}
