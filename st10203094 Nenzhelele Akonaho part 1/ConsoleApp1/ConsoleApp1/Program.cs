// See https://aka.ms/new-console-template for more information
using ConsoleApp1;
using ConsoleApp1.NewFolder;








Console.WriteLine("How many ingridients for the food ?");
int numIngridients = Convert.ToInt32(Console.ReadLine());

Recipe recipe = new Recipe(numIngridients);

recipe.enterIngridients();
Console.WriteLine("Menu \n1-Add recipe\n2-Display recipe\n3-Update Quantity\n4-Update measurement\n5-Reset" +
    " Quatnity\nClear recipe\n0-Exit");
int option = Convert.ToInt32(Console.ReadLine());


while (option != 0) {

    Console.WriteLine("###########################################################################################");

    switch (option)
    {

        case 1:

            recipe.enterIngridients();
            break;
        case 2:
            if (recipe.getNumIngrdient() > 0)
            {
                recipe.displayIngridients();
            }
            else { Console.WriteLine("Could not display ingridients and descriptions because there are no detail"); }
            break;
        case 3:
            if (recipe.getNumIngrdient() > 0)
            {
                recipe.updateQuantity();
            }
            else { Console.WriteLine("Could not update quantity because there are no detail"); }
            break;
        case 4:
            if (recipe.getNumIngrdient() > 0)
            {
                recipe.resetQuantities();
            }
            else { Console.WriteLine("Could not reset quantity(s) because there are no details"); }
            break;
        case 5:
            if (recipe.getNumIngrdient() > 0)
            {
                recipe.clearRecipe();
            }
            else { Console.WriteLine("Could not clear recipe because there no ingridients");
                Console.WriteLine("###########################################################################################");
            }
            break;
        case 0:
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Please enter a value from 0-5");
            break;

        
    }
    
    Console.WriteLine("Menu \n1-Add recipe\n2-Display recipe\n3-Update Quantity\n4-Reset\n5-Clear recipe" +
   " Quatnity\nClear recipe\n0-Exit");
    option = Convert.ToInt32(Console.ReadLine());
}






