using System.Text.RegularExpressions;

namespace DistanceConverter
{
    public class conversion
    {
        public const int FEET_IN_MILES = 5280;
        public const double FEET_IN_METRES = 3.28084;
        public const double METRES_IN_MILES = 1609.34;
        public const double METRES_IN_KILOMETRES = 1000;
        public const double KILOMETRES_IN_MILES = 1.60934;
        public const double FEET_IN_KILOMETRES = 3280.84;


        private double milesAndFeet(double value, string calcDirection)
        {
            switch (calcDirection)
            {
                case "0": // just converts value in ft to mi
                {
                    value *= FEET_IN_MILES;
                    break;
                }

                case "1": // reverse direction, value in miles to convert to feet
                {
                    value /= FEET_IN_MILES;
                    break;
                }
            }
            return value;
        }

        
        private double milesMetres(double value, string calcDirection)
        {
            switch (calcDirection)
            {
                case "0":
                {
                    value *= METRES_IN_MILES;
                    break;
                }
                case "1":
                {
                    value /= METRES_IN_MILES;
                    break;
                }
            }
            return value;
        }


        private double milesKilometres(double value, string calcDirection)
        {
            switch (calcDirection)
            {
                case "0": // km to mi
                {
                    value *= KILOMETRES_IN_MILES;
                    break;
                }
                case "1": // mi to km
                {
                    value /= KILOMETRES_IN_MILES;
                    break;
                }

            }

            return value;
        }

        private double metresFeet(double value, string calcDirection)
        {
            {
                switch (calcDirection)
                {
                    case "0": // metres to ft
                    {
                        value *= FEET_IN_METRES ;
                        break;
                    }
                    case "1": // ft to metres
                    {
                        value /= FEET_IN_METRES;
                        break;
                    }

                }
                return value;
            }
        }

        private double kilometresFeet (double value, string calcDirection)
        {
            {
                switch (calcDirection)
                {
                    case "0": // 
                    {
                        value *= // ;
                        break;
                    }
                    case "1":
                    {
                        value /= //;
                        break;
                    }

                }
                return value;
            }
        }

        private double kilometresMetre(double value, string calcDirection)
        {
            {
                switch (calcDirection)
                {
                    case "0": // km to m
                    {
                        value *= METRES_IN_KILOMETRES;
                        break;
                    }
                    case "1": // m to km
                    {
                        value /= METRES_IN_KILOMETRES;
                        break;
                    }

                }
                return value;
            }
        }














    }




}



/*  FUNCTION FORMAT
{
    switch (calcDirection)
    {
        case "0": // 
        {
            value *= //;
            break;
        }
        case "1":
        {
            value /= //;
            break;
        }

    }
    return value;
}


*/