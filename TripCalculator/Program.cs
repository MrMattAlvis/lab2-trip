/*
* Name: Matthew Alan Alvis
* Course: CSCI 1250, Section 201
* Assignment: Lab 02, Trip Calculator
* Date: September 27, 2026
* Description: Calculates the fuel, food, and work hours behind one road trip.
*/
System.Console.WriteLine(" ");
System.Console.WriteLine("=== Part 1: Road Trip ===");

Console.Write("Round trip miles: "); 
double tripMiles = Convert.ToDouble(Console.ReadLine());

Console.Write("Miles per gallon: ");
double milePerGallon = Convert.ToDouble(Console.ReadLine());

Console.Write("Price per gallon: ");
double pricePerGallon = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine(" ");

//Calculations for Part 1

double gallonsNeeded = tripMiles / milePerGallon;
double fuelCost = gallonsNeeded * pricePerGallon;

//Print the calculations
System.Console.WriteLine("Gallons needed: " + gallonsNeeded.ToString("F2"));
System.Console.WriteLine("Fuel Cost: " + fuelCost.ToString("C"));
System.Console.WriteLine(" ");

//Part 2

System.Console.WriteLine("=== Part 2: Pizza Party ===");

Console.Write("How many people are going: ");
double peopleGoing = Convert.ToDouble(Console.ReadLine());

Console.Write("How many pizzas: ");
double pizza = Convert.ToDouble(Console.ReadLine());

Console.Write("Price per pizza: ");
double pricePerPizza = Convert.ToDouble(Console.ReadLine());

const double slices = 8;
double totalPizzaSlices = slices * pizza;
double slicePerPerson = totalPizzaSlices / peopleGoing;
double pizzaCost = pricePerPizza * pizza;

System.Console.WriteLine(" ");
System.Console.WriteLine("Total slices: " + totalPizzaSlices);
System.Console.WriteLine("Slices per Person: " + slicePerPerson.ToString("F1"));
System.Console.WriteLine("Pizza Cost: " + pizzaCost.ToString("C"));
System.Console.WriteLine(" ");

//Part 3

System.Console.WriteLine("=== Part 3: Paycheck ===");

System.Console.Write("Hours worked this week: ");
double hoursWorked = Convert.ToDouble(Console.ReadLine());

System.Console.Write("Hourly rate: ");
double payRate = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine(" ");

const double taxRate = .18;

double grossPay = hoursWorked * payRate;
double taxWithheld = grossPay * taxRate;
double takeHomePay = grossPay - taxWithheld;

System.Console.WriteLine("Gross pay: " + grossPay.ToString("C"));
System.Console.WriteLine("Tax withheld: " + taxWithheld.ToString("C"));
System.Console.WriteLine("Take home pay: " + takeHomePay.ToString("C"));
System.Console.WriteLine(" ");

//Part 4

double tripTotal = fuelCost + pizzaCost;
double costPerPerson = tripTotal / peopleGoing;
double payPerHour = takeHomePay / hoursWorked;
double yourShare = costPerPerson / payPerHour;

System.Console.WriteLine("=== Part 4: The Whole Trip ===");
System.Console.WriteLine("Trip total: " + tripTotal.ToString("C"));
System.Console.WriteLine("Cost per person: " + costPerPerson.ToString("C"));
System.Console.WriteLine("Take home pay per hour: " + payPerHour.ToString("C"));
System.Console.WriteLine("Hours you must work to cover your share: " + yourShare.ToString("F2"));
System.Console.WriteLine(" ");