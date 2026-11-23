class Program
{
    static void Main(string[] args)
    {
        ShoppingCart shoppingCart = new ShoppingCart();

        shoppingCart.AddItem(12.00m);
        shoppingCart.AddItem(13.00m);
        shoppingCart.AddItem(14.00m);
        shoppingCart.AddItem(15.00m);
        shoppingCart.AddItem(16.00m);

        Console.WriteLine(shoppingCart.GetTotal());
        Console.WriteLine(shoppingCart.GetItemCount());
    }
    
}