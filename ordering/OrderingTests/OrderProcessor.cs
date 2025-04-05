namespace OrderingTests;

class OrderProcessor
{
    public void ProcessOrder(Order order)
    {
        // Validate order
        if (order == null)
        {
            throw new ArgumentNullException(nameof(order));
        }
        if (order.Items == null || order.Items.Count == 0)
        {
            throw new InvalidOperationException("Order must contain items.");
        }

        // Calculate total price
        double totalPrice = 0;
        foreach (var item in order.Items)
        {
            totalPrice += item.Price * item.Quantity;
        }

        // Apply discount
        if (order.DiscountCode != null)
        {
            totalPrice *= 0.9; // Apply 10% discount
        }

        // Process payment
        if (!ProcessPayment(order.PaymentDetails, totalPrice))
        {
            throw new InvalidOperationException("Payment processing failed.");
        }

        // Generate invoice
        Invoice invoice = GenerateInvoice(order, totalPrice);

        // Send confirmation email
        SendConfirmationEmail(order.CustomerEmail, invoice);

        Console.WriteLine("Order processed successfully.");
    }

    private bool ProcessPayment(PaymentDetails paymentDetails, double amount)
    {
        // Simulate payment processing
        return true;
    }

    private Invoice GenerateInvoice(Order order, double totalPrice)
    {
        // Simulate invoice generation
        return new Invoice { OrderId = order.OrderId, TotalPrice = totalPrice };
    }

    private void SendConfirmationEmail(string customerEmail, Invoice invoice)
    {
        // Simulate sending email
        Console.WriteLine($"Email sent to {customerEmail} with invoice details.");
    }
}
