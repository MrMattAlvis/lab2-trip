Console.WriteLine("How many miles for your trip? ");
double tripMiles = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("How many miles per gallon can you go? ");
double milePerGallon = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("How much did you pay for gas? ");
double pricePerGallon = Convert.ToDouble(Console.ReadLine());



//Calculations for Part 1

double gallonsNeeded = tripMiles / milePerGallon;
double fuelCost = gallonsNeeded * pricePerGallon;

//Print the calculations
System.Console.WriteLine("Gallons needed: " + gallonsNeeded.ToString("F2"));
System.Console.WriteLine("Fuel Cost: " + fuelCost.ToString("C"));