
namespace DistanceConverter
{
    public class Conversion
    {
        private const int FEET_IN_MILES = 5280;
        private const double FEET_IN_METRES = 3.28084;
        private const double METRES_IN_MILES = 1609.34;
        private const double METRES_IN_KILOMETRES = 1000;
        private const double KILOMETRES_IN_MILES = 1.60934;
        private const double FEET_IN_KILOMETRES = 3280.84;


        public double milesAndFeet(double value, bool calcDirection)
        {
            switch (calcDirection)
            {
                case false: // just converts value in ft to mi
                {
                    value *= FEET_IN_MILES;
                    break;
                }

                case true: // reverse direction, value in miles to convert to feet
                {
                    value /= FEET_IN_MILES;
                    break;
                }
            }
            return value;
        }
        public double milesMetres(double value, bool calcDirection)
        {
            switch (calcDirection)
            {
                case false:
                {
                    value *= METRES_IN_MILES;
                    break;
                }
                case true:
                {
                    value /= METRES_IN_MILES;
                    break;
                }
            }
            return value;
        }
        public double kilometresMetre(double value, bool calcDirection)
        {
            {
                switch (calcDirection)
                {
                    case false: // km to m
                    {
                        value *= METRES_IN_KILOMETRES;
                        break;
                    }
                    case true: // m to km
                    {
                        value /= METRES_IN_KILOMETRES;
                        break;
                    }

                }
                return value;
            }
        }
        public double metresFeet(double value, bool calcDirection)
        {
            {
                switch (calcDirection)
                {
                    case false: // metres to ft
                    {
                        value *= FEET_IN_METRES ;
                        break;
                    }
                    case true: // ft to metres
                    {
                        value /= FEET_IN_METRES;
                        break;
                    }

                }
                return value;
            }
        }
        public double kilometresFeet (double value, bool calcDirection)
        {
            {
                switch (calcDirection)
                {
                    case false: // 
                    {
                        value *= FEET_IN_KILOMETRES ;
                        break;
                    }
                    case true:
                    {
                        value /= FEET_IN_KILOMETRES;
                        break;
                    }

                }
                return value;
            }
        }
        public double milesKilometres(double value, bool calcDirection)
        {
            switch (calcDirection)
            {
                case false: // km to mi
                {
                    value *= KILOMETRES_IN_MILES;
                    break;
                }
                case true: // mi to km
                {
                    value /= KILOMETRES_IN_MILES;
                    break;
                }

            }

            return value;
        }
        

    }




}


