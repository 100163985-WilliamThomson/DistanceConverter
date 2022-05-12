using System;


namespace DistanceConverter
{
    public class Menus
    {
        private int UnitFrom { get; set; }
        private string UnitFromString { get; set; }
        private int UnitTo { get; set; }
        private string UnitToString { get; set; }
        private double ValueIn { get; set; }
        private double ValueOut { get; set; }



        public void run()
        {
            ValueOut = 0;
            while (true)
            {
                dataCollect();
                Logic backend = new Logic(UnitFrom, UnitTo, ValueIn);
                ValueOut = backend.selectorBot();
                if (ValueOut == 0)
                {
                    Console.WriteLine("\nError, invalid selection(s) for units or values. Please try again.\n");
                }
                else
                {
                    output();
                    break;
                }
            }


        }

        private void inputUnitFrom(){
            Console.Write("Hello, Welcome to the distance converter \n" +
                              "Please select a unit to convert FROM from the menu by typing it's associated number\n" +
                              "(eg, for metres press 3.)\n" +
                              "----------------------------------\n" +
                              "1. Feet\n" +
                              "2. Miles\n" +
                              "3. Metres\n" +
                              "4. Kilometers\n");
            UnitFrom = Convert.ToInt32(Console.ReadLine());
            UnitFromString = unitSelector(UnitFrom);
        }
        
        private void inputUnitTo(){
            Console.WriteLine("Now, please select a unit to convert to.\n" +
                              "----------------------------------\n" +
                              "1. Feet\n" +
                              "2. Miles\n" +
                              "3. Metres\n" +
                              "4. Kilometers\n");
            UnitTo = Convert.ToInt32(Console.ReadLine());
            UnitToString = unitSelector(UnitTo);
        }

        private void inputValueIn()
        {
            Console.WriteLine("Now, please select the value that you would to convert.");
            ValueIn = Convert.ToInt32(Console.ReadLine());
        }

        private void dataCollect()// consolidates all of the input functions into one, for cleanliness
        {
            inputUnitFrom();
            inputUnitTo();
            inputValueIn();
        }

        private string unitSelector(int unit) //Takes the menu inputs and creates an accompanying string, for use in output
        {
            string unitString;
            switch (unit)
            {
                case 1:
                {
                    unitString = "Feet";
                    break;
                }
                case 2:
                    unitString = "Miles";
                    break;

                case 3:
                {
                    unitString = "Metres";
                    break;
                    
                }
                case 4:
                {
                    unitString = "Kilometres";
                    break;
                }
                default:
                {
                    unitString = "INACCESSABLE";
                    break;
                }
            }

            return unitString;
        }

        
        
        private void output()
        {
            Console.WriteLine($"There are {ValueOut} {UnitToString} in {ValueIn} {UnitFromString}.");
        }
    }
}