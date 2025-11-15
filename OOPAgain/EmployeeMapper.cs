namespace OOPAgain;

public class EmployeeMapper<TPrevEmployee,TNextEmployee>: IMapper<TPrevEmployee,TNextEmployee> where TPrevEmployee : IEmployee where TNextEmployee : IEmployee, new()
{
    public TNextEmployee Map(TPrevEmployee source)
    {
        TNextEmployee nextEmployee = new TNextEmployee();
        nextEmployee.Name = source.Name;
        nextEmployee.CompanyName = source.CompanyName;
        return nextEmployee;
    }
}

