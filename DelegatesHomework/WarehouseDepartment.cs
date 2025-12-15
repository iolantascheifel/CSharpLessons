namespace DelegatesHomework;

public class WarehouseDepartment
{
    public void Store(Part part)
    {
        Console.WriteLine($"[Warehouse] Stored part #{part.Id}");
    }
}