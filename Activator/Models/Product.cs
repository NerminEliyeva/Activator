namespace Activator.Models;

public class Product
{
    //    Product,Chai,10 boxes x 20 bags,18
    public string ProductName { get; set; }
    public string QuantityPerUnit { get; set; }
    public string UnitPrice { get; set; }

    public override string ToString()
    {
        return $"ProductName: {ProductName}, QuantityPerUnit: {QuantityPerUnit}, UnitPrice: {UnitPrice}";
    }
}