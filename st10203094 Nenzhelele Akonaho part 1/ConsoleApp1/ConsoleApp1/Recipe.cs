using ConsoleApp1.NewFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Recipe
    {
        int numIngrdient;
        Ingridient[] ingridients;
        int numSteps;
        String[] stepDescription;
        String food; 

        public Recipe(int numIngrdient) { 
            this.numIngrdient = numIngrdient;
            ingridients = new Ingridient[numIngrdient];
        }

        public int getNumIngrdient() { return numIngrdient; }
        public Ingridient[] GetIngridients() { return ingridients; }

        public int getNumSteps() { return numSteps;}

        /*
         * this is a function to enter details for each ingridient
         */
        public void enterIngridients() { 


            for(int i=0; i<ingridients.Length; i++)
            {
                Console.WriteLine("What is the name of ingridient " + (i+1) + "?");
                String name = Console.ReadLine() ?? "";

                Console.WriteLine("What is the quantity of ingridient " + name + "?");
                int Quantity = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("What is the measure of ingridient " + name +"?");
                decimal measure = Convert.ToDecimal(Console.ReadLine());

                ingridients[i] = new Ingridient(name, Quantity, measure);  
            }
            Console.WriteLine("How many Steps for " + food + "?");
            int numStepss = Convert.ToInt32(Console.ReadLine());
            enterSteps(numStepss);
            Console.WriteLine("###########################################################################################");
        }
        /*
         * this is a function to enter the descriptions
         * numsteps - it is a value to give the size of step descriptions
         */
        public void enterSteps(int numSteps) { 
            this.numSteps = numSteps;   
            stepDescription= new String[numSteps];

            for (int i = 0; i < numSteps; i++) {
                Console.WriteLine("What is the description of step " + (i + 1) + "?");
                stepDescription[i] = Console.ReadLine() ?? "";
            }
        }

        /*
         * this is a function to display recipe details and steps descriptions
         */
        public void displayIngridients() {

            Console.WriteLine("\nThere are " + numIngrdient + " ingridients for " + food + " recipe.");
            Console.WriteLine("Ingridients for "+food+" are as follows: ");

            for (int i = 0; i < numIngrdient; i++) {
                Console.WriteLine((i+1) + ". Name: " + ingridients[i].getName + ".");
                Console.WriteLine("  Quantity: " + ingridients[i].getQuantity + ".");
                Console.WriteLine("  Measurement: " + ingridients[i].getMeasurement + ".");

            }

            Console.WriteLine("\nDescription for each Steps for " + food + " are as follows: ");
            for (int i = 0; i < numSteps; i++)
            {

                Console.WriteLine("Step " + (i + 1) + ": " + stepDescription[i] + ".");
            }

            Console.WriteLine("###########################################################################################");


        }

        public bool updateQuantity()
        {
            Console.WriteLine("What is the factor?");

            int factor = Convert.ToInt32(Console.ReadLine());

            while ((factor) < 0) {
                Console.WriteLine("Pleae enter a valid factor, it can't be negative");
                factor = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < numIngrdient; i++) {
                int current = ingridients[i].getQuantity;
                ingridients[i].setQuantity(current * factor);
            }
            Console.WriteLine("###########################################################################################");

            return false;

        }

        public void resetQuantities() {
            for(int i=0; i<numIngrdient; i++)
            {
                ingridients[i].setQuantity(ingridients[i].getOriginalQuantity);
            }
            Console.WriteLine("###########################################################################################");

        }

        public bool clearRecipe() { 
            numIngrdient= 0;
            Array.Clear(ingridients);

            if(numIngrdient==0 && ingridients!=null)
            {
                return true;
            }
            Console.WriteLine("###########################################################################################");

            return false;

        }

        public void displaySteps() {
            
        }


    }
}
