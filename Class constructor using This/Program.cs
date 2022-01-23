using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_constructor_using_This
{


    class box
    {
        // Declaring variables
        double length, heigth, breath;

        // Setting up a constructor which is done with the same name as our class
        // We will set the constructor using This
        public box(double length, double heigth, double breath)
        {

            // Setting up the values in the variables
            this.length = length;
            this.heigth = heigth;
            this.breath = breath;
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
            box box1 = new box(2.0, 4.0, 3.0);
            box box2 = new box(8.0, 3.0, 2.0);

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
