namespace Activator.Models;

public class Order
{
    public string OrderId { get; set; }
    public string CompanyName { get; set; }
    public override string ToString()
    {
        return $"OrderId: {OrderId}, CompanyName: {CompanyName}";
    }
}