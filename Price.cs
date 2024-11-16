internal class Price
{
    public void _price()
    {

    Console.WriteLine("Please enter number of products: ");
    var x = int.Parse(Console.ReadLine());
    int[] arr = new int[x];
    for (int i = 0; i < x; i++)
        {
        int m = i + 1;
        Console.WriteLine("Please enter price of product " + m + " : ");
        var price = decimal.Parse(Console.ReadLine());

        switch (price)
            {
                case >= 1000:
                        Console.WriteLine("Very Expensive");
                    break;
                case >= 900:
                        Console.WriteLine("Expensive");
                    break;
                case >= 700:
                        Console.WriteLine("Good");
                    break;
                case >= 600:
                        Console.WriteLine("Very Good");
                    break;
                case >= 500:
                        Console.WriteLine("Cheep");
                    break;
                case < 500:
                        Console.WriteLine("Very Cheep");
                    break;
            }
            
        }
    }
}