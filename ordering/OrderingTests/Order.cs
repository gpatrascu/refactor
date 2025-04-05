namespace OrderingTests;

class Order
{
    public int OrderId { get; set; }
    public List<OrderItem> Items { get; set; }
    public string DiscountCode { get; set; }
    public PaymentDetails PaymentDetails { get; set; }
    public string CustomerEmail { get; set; }
}
