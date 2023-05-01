using src.entities;
using src.util;

var employeeCount = int.Parse(args[0]);
var invoiceCountPerEmployee = int.Parse(args[1]);
var employees = new List<Employee>();
var invoices = new List<EarningsInvoice>();

for (int i = 0; i < employeeCount; i++)
{
    employees.Add(RandomHelpers.GetRandomEmployee(i));
}

foreach (var employee in employees) 
{
    invoices.AddRange(RandomHelpers.GetRandomEarningsInvoice(
      employee.EmployeeId,
      invoiceCountPerEmployee));
}

//DONT MODIFY ANYTHING ABOVE THIS 
var operationsReport = new OperationsReport();
//DONT MODIFY ANYTHING BELOW THIS
Console.Write(operationsReport);
