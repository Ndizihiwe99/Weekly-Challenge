// Shopping Cart Total


// You are implementing a small shopping cart. 
// Each time a customer adds a product, 
// the cart should update its contents and calculate the total price.

// 1. `AddItem` adds a product price to the cart.
// 2. A price must be greater than zero. Otherwise, throw an `ArgumentException`.
// 3. `GetTotal` returns the sum of all product prices.
// 4. `GetItemCount` returns the number of products in the cart.
// 5. An empty cart must have a total of `0` and an item count of `0`.

public class ShoppingCart
{
    private readonly List<decimal> _prices = new();

    public void AddItem(decimal price)
    {
        if(price <= 0)
        {
            throw new ArgumentException("price must be grater than 0");
        }

        _prices.Add(price);
        
    }

    public decimal GetTotal()
    {
        return _prices.Sum();
    }

    public int GetItemCount()
    {
        if(_prices.Count == 0)
        {
            return 0;
        }
        else
        return _prices.Count;
        
    }
}