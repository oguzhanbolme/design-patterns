using System;

namespace builder
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeBuilder employeeBuilder = new EmployeeBuilder();
            employeeBuilder
                .setId(1)
                .setName("Oğuzhan")
                .setSurname("Bölme")
                .setDepartment("IT")
                .setSalary(1999.99);

            Employee employee = employeeBuilder.build();

            Console.WriteLine(employee.id);
            Console.WriteLine(employee.name);
            Console.WriteLine(employee.surname);
            Console.WriteLine(employee.department);
            Console.WriteLine(employee.salary);
        }
    }
}
