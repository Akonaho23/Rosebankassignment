// See https://aka.ms/new-console-template for more information
using ConsoleApp1;
using ConsoleApp1.NewFolder;








Console.WriteLine("How many ingridients for the food ?");
int numIngridients = Convert.ToInt32(Console.ReadLine());

Recipe recipe = new Recipe(numIngridients);


Console.WriteLine("Menu \n1-Add recipe\n2-Display recipe\n3-Update Quantity\n4-Update measurement\n5-Reset" +
    " Quatnity\nClear recipe\n0-Exit");
int option = Convert.ToInt32(Console.ReadLine());







