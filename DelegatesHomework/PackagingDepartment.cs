namespace DelegatesHomework;

public class PackagingDepartment
{
    public void PreparePackaging(Part part)
    {
        Console.WriteLine($"[Packaging] Prepared packaging for part #{part.Id}");
    }
}
