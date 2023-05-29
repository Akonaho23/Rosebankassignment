// See https://aka.ms/new-console-template for more information
using ConsoleApp1;
using ConsoleApp1.NewFolder;
using System.Numerics;

//variables 
int mainOption = 0;
List<Recipe> recipes;//list of recipes objects

/*
 * a function to input a number
 */
int enterNumber() {
    bool isNumber = false;
    int num = 0;
    String readNumber = "";
    while (!isNumber) {
        readNumber = Console.ReadLine() ?? "";
        try { 
           num = int.Parse(readNumber);
           isNumber= true;
        } catch
        {
            Console.WriteLine(readNumber + " is not a number, please enter a valid number ");
            isNumber= false;
        }
        

    }

    return num;
}

/*
 a function to enter recipes
 */
List<Recipe> enterRecipes( int size) { 

    for(int i = 0;i < size; i++) {
        Console.WriteLine("What is the name of recipe " + (i+1) + "? ");
        String recipeName = Convert.ToString(Console.ReadLine()) ?? "";

        Console.WriteLine("How many ingridients of recipe " + recipeName + "? ");
        int numIngridients = enterNumber();

        Recipe obRecip = new Recipe(numIngridients, recipeName);

        

        obRecip.enterIngridients();

        recipes.Add(obRecip);
    }

    List<Recipe> recipeslist =  recipes.OrderBy(o=>o.GetRecipeName()).ToList();


    return recipeslist;
}

/*
 function to display each recipe details
 */
void displayRecipe(int index) {

    int option = -1;

    while (option != 0)
    {

        Console.WriteLine("###########################################################################################");

        recipes.ElementAt(index).displayIngridients();

        switch (option)
        {

            case 1:

                recipes.ElementAt(index).enterIngridients();
                break;
            case 2:
                if (recipes.ElementAt(index).getNumIngrdient() > 0)
                {
                    recipes.ElementAt(index).displayIngridients();
                }
                else { Console.WriteLine("Could not display ingridients and descriptions because there are no detail"); }
                
                break;
            case 3:
                if (recipes.ElementAt(index).getNumIngrdient() > 0)
                {
                    recipes.ElementAt(index).updateQuantity();
                }
                else { Console.WriteLine("Could not update quantity because there are no detail"); }
                
                break;
            case 4:
                if (recipes.ElementAt(index).getNumIngrdient() > 0)
                {
                    recipes.ElementAt(index).resetQuantities();
                }
                else { Console.WriteLine("Could not reset quantity(s) because there are no details"); }
               
                break;
            case 5:
                if (recipes.ElementAt(index).getNumIngrdient() > 0)
                {
                    recipes.ElementAt(index).clearRecipe();
                }
                else { Console.WriteLine("Could not clear recipe because there no ingridients");
                    Console.WriteLine("###########################################################################################");
                }
                break;
            case 6:
                mainOption = -1;
                return;
                break;
            case 0:
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Please enter a value from 0-5");
                break;


        }
        
        Console.WriteLine("Menu \n1-Add recipe\n2-Display recipe\n3-Update Quantity\n4-Reset\n5-Clear recipe" +
       " Quatnity\nClear \n6-Go to Main Menu recipe\n0-Exit");
        option = enterNumber();
    }

}

/*
 function to display all recipes
 */
void displayRecipes(List<Recipe> recipes) {
    Console.Clear();    
    Console.WriteLine("Recipe List:");
    for (int i = 0; i<recipes.Count; i++)
    {
        
        Console.WriteLine ((i+1)+ "." + recipes.ElementAt(i).GetRecipeName());
    }
    Console.WriteLine();


}



//asking the user how many recipes
Console.WriteLine("How many recipes ?");

int numRecipes =enterNumber();

recipes = new List<Recipe>();

recipes = enterRecipes(numRecipes);

displayRecipes(recipes);

//asking the user to choose which recipe details to display.
Console.WriteLine("Enter the number of recipe you want to display or 0 to exit");
int selectRecipe=enterNumber();



while (selectRecipe < 0 || selectRecipe > (numRecipes+1))
{
    Console.WriteLine("Please enter the value from " + 1 + " to " + numRecipes);
    selectRecipe = enterNumber();
}
Console.Clear();
mainOption = -2;

while (mainOption != 0)
{

    switch (mainOption)
    {
        case -1:
            Console.Clear();
            displayRecipes(recipes);
            Console.WriteLine("Enter the number of recipe you want to display 0 to exit");
            selectRecipe = enterNumber();
            while (selectRecipe < 0 || selectRecipe > (numRecipes+1))
            {
                Console.WriteLine("Please enter the value from " + 1 + " to " + numRecipes);
                selectRecipe = enterNumber();
            }
            Console.Clear();
            mainOption = -2;
            break;
        case -2:
            Console.Clear();
            displayRecipe(selectRecipe-1);

            break;

    }
}








