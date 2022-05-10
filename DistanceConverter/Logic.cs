

// ReSharper disable All

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;

namespace DistanceConverter
{
    public class Logic
    {
        private int UT { get; }
        private int UF { get; }
        
        private int value { get; set; }

        public Logic(int unitTo, int unitFrom, int num)
        {
            UT = unitTo;
            UF = unitFrom;
            value = num;
        }

        private bool prelimCheck()
        {
            bool success;
            bool part1 = false;
            bool part2 = false;
            
            if (this.UT is > 0 and < 5 )
            {
                part1 = true;
            }

            if (this.UF is > 0 and < 5)
            {
                part2 = true;
            }
            //range checks to make sure that the value entered is one on the menu in Menus

            success = part1 && part2;

            return success;
        }

        
        
        
        public double selectorBot()
        {
            Conversion Robot = new Conversion();
            double result = 0;
            bool validSelections = prelimCheck();
            if (validSelections)
            {
                switch (this.UF, this.UT) //Compares both the UnitFrom UF and UnitTo UT and selects the appropriate conversion function.
                {
                    case ((1,2) or (2,1)):// if user selects miles and feet either way
                    {
                        bool calcDirection = (this.UF == 1) ? false : true;
                        result = Robot.milesAndFeet(this.value, calcDirection);
                        break;

                    }
                    
                    case ((2, 3) or (3, 2)): //miles + meters either way
                    {
                        bool calcDirection = (this.UF == 2) ? false : true;
                        result = Robot.milesMetres(this.value, calcDirection);
                        break;
                    }
                    
                    case ((3, 4) or (4, 3)):// m/km either way
                    {
                        bool calcDirection = (this.UF == 3) ? false : true;
                        result = Robot.kilometresMetre(this.value, calcDirection);
                        break;
                    }
                    
                    case ((3, 1) or (1, 3)): // feet and meters
                    {
                        bool calcDirection = (this.UF == 3) ? false : true;
                        result = Robot.metresFeet(this.value, calcDirection);
                        break;
                    }
                    
                    case ((4,1) or (1,4)): // kilometers feet
                    {
                        bool calcDirection = (this.UF == 4) ? false : true;
                        result = Robot.kilometresFeet(this.value, calcDirection);
                        break;
                    }
                    
                    case ((4, 2) or (2, 4)): //miles kilometers
                    {
                        bool calcDirection = (this.UF == 4) ? false : true;
                        result = Robot.milesKilometres(this.value, calcDirection);
                        break;

                    }
                    
                    default:
                    {
                        Console.Write("You've done something terribly wrong to get this.");
                        break;
                    }
                } 
            }
            else // user has entered a number that is not in the range, so default the result to zero and check for an error on the user side
            {
                result = 0;
            }

            return result;
        }
        

    }
}



/* copy/paste block
                        bool calcDirection = (this.UF == ##) ? false : true;
                        result = Cbot.##(this.value, calcDirection);
                        return result;
 */



