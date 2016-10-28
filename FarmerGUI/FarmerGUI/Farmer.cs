using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmerGameApp
{
    class Farmer
    {
        ArrayList northBank = new ArrayList();
        ArrayList southBank = new ArrayList();
        Direction farmer;

        public Farmer()
        {
            northBank.Add("FOX");
            northBank.Add("CHICKEN");
            northBank.Add("GRAIN");

            farmer = Direction.North;

        }

        public enum Direction
        {
            North,
            South
        }

        public ArrayList NorthBank
        {
            get { return northBank; }
        }
        public ArrayList SouthBank
        {
            get { return southBank; }
        }

        public Direction TheFarmer
        {
            get { return farmer; }

        }


        public string Move(string item)
        {
            string result = "NO ERROR";

            switch (item)
            {
                case "CHICKEN":

                    if ((farmer == Direction.North) && northBank.Contains("CHICKEN"))
                    {
                        northBank.Remove("CHICKEN");
                        southBank.Add("CHICKEN");
                        farmer = Direction.South;

                    }
                    else if ((farmer == Direction.South) && southBank.Contains("CHICKEN"))
                    {
                        southBank.Remove("CHICKEN");
                        northBank.Add("CHICKEN");
                        farmer = Direction.North;

                    }
                    else
                        result = "ERROR";
                    break;

                case "FOX":
                    if ((farmer == Direction.North) && northBank.Contains("FOX"))
                    {
                        northBank.Remove("FOX");
                        southBank.Add("FOX");
                        farmer = Direction.South;

                    }
                    else if ((farmer == Direction.South) && southBank.Contains("FOX"))
                    {
                        southBank.Remove("FOX");
                        northBank.Add("FOX");
                        farmer = Direction.North;

                    }
                    else
                        result = "ERROR";
                    break;

                case "GRAIN":
                    if ((farmer == Direction.North) && northBank.Contains("GRAIN"))
                    {
                        northBank.Remove("GRAIN");
                        southBank.Add("GRAIN");
                        farmer = Direction.South;

                    }
                    else if ((farmer == Direction.South) && southBank.Contains("GRAIN"))
                    {
                        southBank.Remove("GRAIN");
                        northBank.Add("GRAIN");
                        farmer = Direction.North;

                    }
                    break;

                case "":
                    if (farmer == Direction.North)
                        farmer = Direction.South;
                    else
                        farmer = Direction.North;
                    break;

                default:
                    {
                        result = "ERROR";

                        break;
                    }
            }



            return result;

        }


        public string AnimalAteFood()
        {
            string eaten = "NOT EATEN ";

            if (farmer == Direction.North)
            {
                if (southBank.Contains("CHICKEN") && southBank.Contains("GRAIN"))
                    eaten = "EATEN2";
                else
                    if (southBank.Contains("CHICKEN") && southBank.Contains("FOX"))
                    eaten = "EATEN1";
            }
            else if (farmer == Direction.South)
            {
                if (northBank.Contains("CHICKEN") && northBank.Contains("FOX"))
                    eaten = "EATEN1";
                else
                    if (northBank.Contains("CHICKEN") && northBank.Contains("GRAIN"))
                    eaten = "EATEN2";
            }

            return eaten;
        }

        public bool DetermineWin()
        {
            bool result = false;

            if (southBank.Contains("CHICKEN") && southBank.Contains("GRAIN") && southBank.Contains("FOX"))
                result = true;

            return result;
        }
    }
}
