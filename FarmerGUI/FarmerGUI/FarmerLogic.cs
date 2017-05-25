using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//by nick wasik

namespace FarmerGUI
{
    class FarmerLogic
    {
        public enum Direction { North, South }

        List<string> northBank = new List<string>();
        List<string> southBank = new List<string>();
        Direction farmer;



        public FarmerLogic()
        {
            northBank.Add("CHICKEN");
            northBank.Add("FOX");
            northBank.Add("GRAIN");

            farmer = Direction.North;

            southBank.Clear();
        }

        //Properties
        public Direction Farmer
        {
            get { return farmer; }
        }
        public List<string> NorthBank
        {
            get { return northBank; }
        }

        public List<string> SouthBank
        {
            get { return southBank; }
        }
        public void Move(string choice)
        {
            bool check;
            if (farmer == Direction.North) //going south
            {
                check = northBank.Remove(choice);
                if (check == true)
                    southBank.Add(choice);

                farmer = Direction.South;
            }

            else
            {
                check = southBank.Remove(choice);
                if (check == true)
                    northBank.Add(choice);

                farmer = Direction.North;

            }
        }

        public Boolean AnimalAteFood()
        {
            bool flag = false;
            if (northBank.Contains("GRAIN") && (northBank.Contains("CHICKEN")) && (farmer == Direction.South) || (southBank.Contains("GRAIN") && (southBank.Contains("CHICKEN")) && (farmer == Direction.North)))
            {
                flag = true;
            }
            return flag;
        }

        public Boolean GameOver()
        {
            if (northBank.Contains("FOX") && (northBank.Contains("CHICKEN")) && (farmer == Direction.South) || (southBank.Contains("CHICKEN") && (southBank.Contains("FOX")) && (farmer == Direction.North)))

                return true;

            else

                return false;






        }

        public Boolean DetermineWin()
        {
            if (southBank.Contains("FOX") && (southBank.Contains("CHICKEN")) && (southBank.Contains("GRAIN")))
                return true;
            else
                return false;
        }

    }
}
