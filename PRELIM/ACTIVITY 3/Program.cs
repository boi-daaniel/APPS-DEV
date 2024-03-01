double discountRate = 0.10;

Console.Write("Enter value for price: ");
double price = Convert.ToInt32(Console.ReadLine());

if (price > discountRate)
{
    double discount = price * discountRate;
    Console.WriteLine("Discount is: " + discount.ToString("N2"));
}
else 
{
    Console.WriteLine("No discount");
} 
