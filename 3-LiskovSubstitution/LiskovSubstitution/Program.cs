
using LiskovSubstitution;

CalculateSalaryMonthly(new List<Employee>
{
    new EmployeeFullTime ("Pepito Perez", 160, 10),
    new EmployeeContractor("Manuel Lopez", 180)
});

void CalculateSalaryMonthly(List<Employee> employees)
{
    foreach(var item in employees)
    {
        decimal salary = item.CalculateSalary();
        Console.WriteLine($"The {item.Fullname}'s salary us {salary}");
    }
}