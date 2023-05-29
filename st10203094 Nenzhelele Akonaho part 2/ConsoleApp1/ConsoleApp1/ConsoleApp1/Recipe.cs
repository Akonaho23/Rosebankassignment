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
        List<Ingridient> ingridients;
        int numSteps;
        List<String> stepDescription;
        String recipeName;
        decimal totalCalories; 

        public Recipe(int numIngrdient, String recipeName) { 
            this.numIngrdient = numIngrdient;
            ingridients = new List<Ingridient>();
            this.recipeName= recipeName;
            stepDescription = new List<string>();
        }

        public int getNumIngrdient() { return numIngrdient; }
        public List<Ingridient> GetIngridients() { return ingridients; }

        public int getNumSteps() { return numSteps;}

        public String GetRecipeName() { return recipeName; }
        /*
        * a function to input a number
        */
        int enterNumber()
        {
            bool isNumber = false;
            int num = 0;
            String readNumber = "";
            while (!isNumber)
            {
                readNumber = Console.ReadLine() ?? "";
                try
                {
                    num = int.Parse(readNumber);
                    isNumber = true;
                }
                catch
                {
                    Console.WriteLine(readNumber + " is not a number, please enter a valid number ");
                    isNumber = false;
                }


            }

            return num;
        }

        decimal enterDecimal() {
            bool isNumber = false;
            decimal num = 0;
            String readNumber = "";
            while (!isNumber)
            {
                readNumber = Console.ReadLine() ?? "";
                try
                {
                    num = decimal.Parse(readNumber);
                    isNumber = true;
                }
                catch
                {
                    Console.WriteLine(readNumber + " is not a number, please enter a valid number ");
                    isNumber = false;
                }


            }

            return num;
        }

        /*
         * this is a function to enter details for each ingridient
         */
        public void enterIngridients() { 


            for(int i=0; i<numIngrdient; i++)
            {
                Console.WriteLine("What is the name of ingridient " + (i+1) + "?");
                String name = Console.ReadLine() ?? "";

                Console.WriteLine("What is the quantity of ingridient " + name + "?");
                int Quantity = enterNumber();

                Console.WriteLine("What is the measure of ingridient " + name +"?");
                decimal measure = enterDecimal();

                Console.WriteLine("What is the total calories of " + name + "?");
                decimal totalCalories = enterDecimal();

                Console.WriteLine("What is the food group " + name + "?");
                String foodGroup = Console.ReadLine() ?? "";



                Ingridient objing = new Ingridient(name, Quantity, measure, totalCalories, foodGroup);
                ingridients.Add(objing);
                this.totalCalories = this.totalCalories + totalCalories;
            }
            if(this.totalCalories > 300)
            {
                Console.WriteLine("Calories are more than 300");
            }
            Console.WriteLine("How many Steps for " + recipeName + "?");

            int numStepss = enterNumber();
            enterSteps(numStepss);
            Console.WriteLine("###########################################################################################");
        }
        /*
         * this is a function to enter the descriptions
         * numsteps - it is a value to give the size of step descriptions
         */
        public void enterSteps(int numSteps) { 
            this.numSteps = numSteps;   
            

            for (int i = 0; i < numSteps; i++) {
                Console.WriteLine("What is the description of step " + (i + 1) + "?");
                stepDescription.Add(Console.ReadLine() ?? "");
            }
        }

        /*
         * this is a function to display recipe details and steps descriptions
         */
        public void displayIngridients() {

            Console.WriteLine("\nThere are " + numIngrdient + " ingridients for " + recipeName + " recipe.");
            Console.WriteLine("Ingridients for "+ recipeName + " are as follows: ");

            for (int i = 0; i < numIngrdient; i++) {
                Console.WriteLine((i+1) + ". Name: " + ingridients.ElementAt(i).getName + ".");
                Console.WriteLine("  Quantity: " + ingridients.ElementAt(i).getQuantity + ".");
                Console.WriteLine("  Measurement: " + ingridients.ElementAt(i).getMeasurement() + ".");
                Console.WriteLine("  Food Group: " + ingridients.ElementAt(i).getfoodGroup + ".");
                Console.WriteLine("  Food Calories: " + ingridients.ElementAt(i).getnumCalories + ".");

            }

            Console.WriteLine("Total calories for " + recipeName + ": " + this.totalCalories    );

            Console.WriteLine("\nDescription for each Steps for " + recipeName + " are as follows: ");
            for (int i = 0; i < numSteps; i++)
            {

                Console.WriteLine("Step " + (i + 1) + ": " + stepDescription.ElementAt(i) + ".");
            }

            Console.WriteLine("###########################################################################################");


        }

        public bool updateQuantity()
        {
            Console.WriteLine("What is the factor?");

            int factor = enterNumber();

            while ((factor) < 0) {
                Console.WriteLine("Pleae enter a valid factor, it can't be negative");
                factor = enterNumber();
            }
            for (int i = 0; i < numIngrdient; i++) {
                int current = ingridients.ElementAt(i).getQuantity;
                ingridients.ElementAt(i).setQuantity(current * factor);
            }
            Console.WriteLine("###########################################################################################");

            return false;

        }

        public void resetQuantities() {
            for(int i=0; i<numIngrdient; i++)
            {
                ingridients.ElementAt(i).setQuantity(ingridients.ElementAt(i).getOriginalQuantity);
            }
            Console.WriteLine("###########################################################################################");

        }

        public bool clearRecipe() { 
            numIngrdient= 0;
            ingridients.Clear();

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
