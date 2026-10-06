int price, quantity, total, totalSummation = 0;
bool input;

Console.Write("Please Enter The Price : ");
price = Convert.ToInt32(Console.ReadLine());

Console.Write("Please Enter The Quantity : ");
quantity = Convert.ToInt32(Console.ReadLine());

total = price * quantity;
Console.WriteLine($"Total Price = {total}");

totalSummation = totalSummation + total;

Console.WriteLine("Would you like to add another product? Please Press 1 for Yes, 0 for No.");
input = (Console.ReadLine() == "1");


while (input)
{
    Console.Write("Please Enter The Price : ");
    price = Convert.ToInt32(Console.ReadLine());

    Console.Write("Please Enter The Quantity : ");
    quantity = Convert.ToInt32(Console.ReadLine());

    total = (price * quantity);

    Console.WriteLine($"Total Price = {total}");
    totalSummation = totalSummation + total;

    Console.WriteLine("Would you like to add another product? Please Press 1 for Yes, 0 for No.");
    input = (Console.ReadLine() == "1");

}
Console.WriteLine($"Total Summation = {totalSummation}");
Console.WriteLine("Thank you for shopping !");