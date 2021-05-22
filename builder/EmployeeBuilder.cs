public class EmployeeBuilder
{
    private Employee employee = new Employee();

    public EmployeeBuilder setId(int id)
    {
        this.employee.id = id;
        return this;
    }
    public EmployeeBuilder setName(string name)
    {
        this.employee.name = name;
        return this;
    }
    public EmployeeBuilder setSurname(string surname)
    {
        this.employee.surname = surname;
        return this;
    }
    public EmployeeBuilder setDepartment(string department)
    {
        this.employee.department = department;
        return this;
    }
    public EmployeeBuilder setSalary(double salary)
    {
        this.employee.salary = salary;
        return this;
    }
    public Employee build()
    {
        return this.employee;
    }
}