double price = 2000 ;
double discountRate = 0.10;


Console.WriteLine("Enter value for price: 2000");
if (price > discountRate)
{
    double discount = price * discountRate;
    Console.WriteLine("Discount is: " + discount);

}
else 
{
    Console.WriteLine("No discount");
} 