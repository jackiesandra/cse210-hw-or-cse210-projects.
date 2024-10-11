using System.Collections.Generic;

public class Order
{
    private List<Product> products;
    private Customer customer;
    private const decimal ShippingCostUSA = 5.00m;
    private const decimal ShippingCostInternational = 35.00m;

    public Order(Customer customer)
    {
        products = new List<Product>();
        this.customer = customer;
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public decimal CalculateTotalCost()
    {
        decimal totalCost = 0;
        foreach (var product in products)
        {
            totalCost += product.GetTotalCost();
        }

        totalCost += customer.LivesInUSA() ? ShippingCostUSA : ShippingCostInternational;
        return totalCost;
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var product in products)
        {
            label += product.GetProductInfo() + "\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return "Shipping Label:\n" + customer.GetCustomerInfo();
    }
}
