using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_Classes_Console
{

    class box
    {
        // Declaring variables
        double length, heigth, breath;

        // Setting the length using a Method that does not return a value
        public void setlength( double len)
        {
            length = len;
        }

        //setting the heigth using a Method that does not return a value
        public void setheigth(double hei)
        {
            heigth = hei;
        }

        //setting the breath using a Method that does not return a value
        public void setbreath(double bre)
        {
            breath = bre;
        }

        // performing the calculation using a Method that returns a value
        public double calculate()
        {
            return length * heigth * breath;
        }
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Declaring a variable that will hold the volume of the calculation
            double volume = 0;

            // Using the class box to create object of the class box1 and box2
            box box1 = new box();
            box box2 = new box();

            // Passing values to our object box1
            box1.setlength(2.0);
            box1.setheigth(4.0);
            box1.setbreath(3);

            // Passing values to our object box2 
            box2.setlength(8);
            box2.setheigth(3);
            box2.setbreath(2);

            // Performing the calculation for box1 volume
            volume = box1.calculate();
            Console.WriteLine(volume);


            // Performing the calculation for box2 volume
            volume = box2.calculate();
            Console.WriteLine(volume);
            Console.ReadLine();


        }
    }
}
