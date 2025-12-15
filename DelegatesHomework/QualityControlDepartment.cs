namespace DelegatesHomework;

public class QualityControlDepartment
{
    public void Inspect(Part part)
    {
        Console.WriteLine($"[Quality Control] Inspected part #{part.Id}");
    }
}
