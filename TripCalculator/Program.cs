
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

//Part 2

Console.WriteLine("How many people are going? ");
double peopleGoing = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("How many pizzas? ");
double pizza = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("How much does a pizza slice cost? ");
double pricePerSlice = Convert.ToDouble(Console.ReadLine());

//const double slices = 8;

double slices = pizza * 8;
double slicePerPerson = slices / peopleGoing;
double pizzaCost = pricePerSlice * slices;

System.Console.WriteLine("Total slices: " + slices);
System.Console.WriteLine("Slices per Person: " + slicePerPerson.ToString("F1"));
System.Console.WriteLine("Pizza Cost: " + pizzaCost.ToString("F2"));