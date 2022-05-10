using System;
using System.Linq;

namespace DistanceConverter
{
    public class Menus
    {
        private int UnitFrom { get; set; }
        private int UnitTo { get; set; }
        private double ValueIn { get; set; }
        
        


        public Menus(int unitTo, int unitFrom)
        {
            UnitTo = unitTo;
            UnitFrom = unitFrom;

        }



        public void run()
        {

            
        }

        private void inputUnitFrom(){
            Console.WriteLine("Hello, Welcome to the distance converter" +
                              "Please select a unit to convert FROM from the menu by typing it's associated number" +
                              "(eg, for metres press 3.)" +
                              "----------------------------------" +
                              "1. Feet" +
                              "2. Miles" +
                              "3. Metres" +
                              "4. Kilometers");
            this.UnitFrom = Convert.ToInt32(Console.ReadLine());
        }
        
        private void inputUnitTo(){
            Console.WriteLine("Now, please select a unit to convert to." +
                              "----------------------------------" +
                              "1. Feet" +
                              "2. Miles" +
                              "3. Metres" +
                              "4. Kilometers");
            this.UnitTo = Convert.ToInt32(Console.ReadLine());
        }



        
        private void output()
        {
            // print to console
        }
    }
}