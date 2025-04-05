namespace OrderingTests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Order order = new Order
        {
            OrderId = 1,
            Items = new List<OrderItem>
            {
                new OrderItem { Name = "Item1", Price = 10, Quantity = 2 },
                new OrderItem { Name = "Item2", Price = 20, Quantity = 1 }
            },
            DiscountCode = "DISCOUNT10",
            PaymentDetails = new PaymentDetails
            {
                CardNumber = "1234567890123456",
                CardHolderName = "John Doe",
                ExpiryDate = new DateTime(2025, 12, 31)
            },
            CustomerEmail = "john.doe@example.com"
        };

        OrderProcessor processor = new OrderProcessor();
        processor.ProcessOrder(order);
    }
}
