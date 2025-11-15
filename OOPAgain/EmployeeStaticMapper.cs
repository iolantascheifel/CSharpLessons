namespace OOPAgain;

public class EmployeeStaticMapper
{
    public static TNextEmployee Map<TPrevEmployee, TNextEmployee>(TPrevEmployee source) where TPrevEmployee : IEmployee where TNextEmployee : IEmployee, new()
    {
        TNextEmployee nextEmployee = new TNextEmployee();
        nextEmployee.Name = source.Name;
        nextEmployee.CompanyName = source.CompanyName;
        return nextEmployee;
    }
}