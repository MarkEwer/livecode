# Welcome to the backend coding challenge

The objective of this challenge is to evaluate your ability to design scalable backend c# code. Prioritize the scalable design of the code over the time it takes you to implement your solution. 

## Prompt

Contained within the project are two entities - Employees and EarningsInvoices. They are your core entities and are not to be changed. In the `Program.cs` we instantiate a collection of employees and invoices. Your job is to implement a report that aggregates both of these data stores found in `OperationsReport.cs`. The requirements of the report are found in the comments of the file. You are only allowed to add new files and folders to this project and modify the section of `Program.cs` denoted by the comments. Modifying any other part of this project or its files is prohibited.

## To Run

* install the project with `git clone [INSERT PUBLIC REPO URL]`
* Download dotnet 6 or later
* run from CLI with `dotnet run -- [employeeCount] [invoicesPerEmployeeCount]`