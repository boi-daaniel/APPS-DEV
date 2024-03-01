int TotalBags = 52;
double bagPrice = 5.50;
double largePrice = 3.00;
double mediumPrice = 2.50;
double smallPrice = 2.00;
int[] amount = {2, 1, 1};

double result = TotalBags * bagPrice;
double totalResult = result + (largePrice * amount[0]) + (mediumPrice * amount[1]) + (smallPrice * amount[2]);


Console.WriteLine("Number of Bags Ordered: " + TotalBags);
Console.WriteLine("Boxes Used: ");
Console.WriteLine("Large - " + amount[0]);
Console.WriteLine("Medium - " + amount[1]);
Console.WriteLine("Small - " + amount[2]);
Console.WriteLine("Your total cost is: $" + totalResult);
