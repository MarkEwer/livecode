namespace src.entities;

public class EarningsInvoice
{
    public int InvoiceId { get; init; }
    public int EmployeeId { get; init; }
    public decimal Amount { get; init; }
    public DateOnly Date { get; init; }
}
