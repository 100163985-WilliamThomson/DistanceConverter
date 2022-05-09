using System;

namespace DistanceConverter
{
    public class Menus
    {
        private string UnitFrom;
        private string UnitTo;
        
        
        private double miles;
        private double feet;
        private double metres;
        private double kilometres;

        public void run()
        {
            // make a thing that does a selection
            //
        }

        private string inputUnitFrom(){
            Console.WriteLine("Hello, Welcome to the distance converter" +
                              "Please select a unit to convert FROM from the menu by typing it's associated number" +
                              "(eg, for metres press 3.)" +
                              "----------------------------------" +
                              "1. Feet" +
                              "2. Miles" +
                              "3. Metres" +
                              "4. Kilometers");
            UnitFrom = Console.ReadLine();
            return UnitFrom;

        }
        private string inputUnitTo(){
            Console.WriteLine("Now, please select a unit to convert to." +
                              "----------------------------------" +
                              "1. Feet" +
                              "2. Miles" +
                              "3. Metres" +
                              "4. Kilometers");
            UnitFrom = Console.ReadLine();
            return UnitTo;

        }



        
        private void output()
        {
            // print to console
        }
    }
}