using src.entities;

namespace src.util;

public static class RandomHelpers
{
    private static readonly string[] _firstNames = new string[]{"Jed", "Ben", "Tom", "Raekwon", "Marcus", "Adam", "Sally", "Suzie", "Crystal", "Zeke"};
    private static readonly string[] _lastNames = new string[]{"Jones", "Jackson", "Ames", "Hunt", "Diggs", "Jordan", "Maxwell", "Tyler"};
    private static readonly string[] _costCenters = new string[]{"Benefits", "HR", "Tax", "Govt Relations", "Distribution"};
    private static readonly Random _random = new ();
    private static readonly string _chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

    public static Employee GetRandomEmployee(int id)
    {
        return new Employee
        {
            EmployeeId = id,
            FirstName = GetRandomFirstName(),
            LastName = GetRandomLastName(),
            Address1 = GetRandomString(16),
            Address2 = GetRandomString(8),
            Zip = GetRandomInt(10000, 99999),
            City = GetRandomString(8),
            State = GetRandomString(2),
            CostCenter = GetRandomCostCenter(),
            Salary = GetRandomDecimal(100000, 900000),
            Title = GetRandomString(6)
        };
    }

    public static List<EarningsInvoice> GetRandomEarningsInvoice(int employeeId, int invoiceCountPerEmployee)
    {
        return Enumerable
            .Range(1, invoiceCountPerEmployee)
            .Select(invoiceId => new EarningsInvoice
            {
                InvoiceId = invoiceId,
                EmployeeId = employeeId,
                Amount = GetRandomDecimal(1, 1000),
                Date = GetRandomDateOnly()
            })
            .ToList();
    }

    private static int GetRandomInt(int? min, int? max)
    {
        return _random.Next(min ?? 0, max ?? int.MaxValue);
    }

    private static decimal GetRandomDecimal(int? min, int? max)
    {
        return _random.Next(min ?? 0, max ?? int.MaxValue)
            + decimal.Round((decimal)_random.NextDouble(), 2);
    }

    private static string GetRandomFirstName()
    {
        return _firstNames[_random.Next(_firstNames.Length - 1)];
    }

    private static string GetRandomLastName()
    {
        return _lastNames[_random.Next(_lastNames.Length - 1)];
    }

    private static string GetRandomCostCenter()
    {
        return _costCenters[_random.Next(_costCenters.Length - 1)];
    }

    private static string GetRandomString(int length)
    {
        var stringChars = new char[length];
        for (int i = 0; i < stringChars.Length; i++)
        {
            stringChars[i] = _chars[_random.Next(_chars.Length)];
        }
        return new String(stringChars);
    }

    private static DateOnly GetRandomDateOnly()
    {
        return new DateOnly(GetRandomInt(2020, 2022), GetRandomInt(1, 12), GetRandomInt(1, 28));
    }
}
