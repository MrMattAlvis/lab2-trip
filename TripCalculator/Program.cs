/*
* Name: Matthew Alan Alvis
* Course: CSCI 1250, Section 201
* Assignment: Lab 02, Trip Calculator
* Date: September 27, 2026
* Description: Calculates the fuel, food, and work hours behind one road trip.
*/
Console.WriteLine("Round trip miles: "); 
double tripMiles = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Miles per gallon: ");
double milePerGallon = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Price per gallon: ");
double pricePerGallon = Convert.ToDouble(Console.ReadLine());

//Calculations for Part 1

double gallonsNeeded = tripMiles / milePerGallon;
double fuelCost = gallonsNeeded * pricePerGallon;

//Print the calculations
System.Console.WriteLine("Gallons needed: " + gallonsNeeded.ToString("F2"));
System.Console.WriteLine("Fuel Cost: " + fuelCost.ToString("C"));

//Part 2

Console.WriteLine("How many people are going: ");
double peopleGoing = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("How many pizzas: ");
double pizza = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Price per pizza: ");
double pricePerPizza = Convert.ToDouble(Console.ReadLine());

//const double slices = 8;

double slices = pizza * 8;
double slicePerPerson = slices / peopleGoing;
double pizzaCost = pricePerPizza * pizza;

System.Console.WriteLine("Total slices: " + slices);
System.Console.WriteLine("Slices per Person: " + slicePerPerson.ToString("F1"));
System.Console.WriteLine("Pizza Cost: " + pizzaCost.ToString("C"));

//Part 3

System.Console.WriteLine("Hours worked this week: ");
double hoursWorked = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine("Hourly rate: ");
double payRate = Convert.ToDouble(Console.ReadLine());

const double taxRate = .18;

double grossPay = hoursWorked * payRate;
double taxWithheld = grossPay * taxRate;
double takeHomePay = grossPay - taxWithheld;

System.Console.WriteLine("Gross pay: " + grossPay.ToString("C"));
System.Console.WriteLine("Tax withheld: " + taxWithheld.ToString("C"));
System.Console.WriteLine("Take home pay: " + takeHomePay.ToString("C"));

//In all honesty I didnt see the part that said to commit after evry part.
//once I got done with part 3 this is roughly what I had