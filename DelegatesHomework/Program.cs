namespace DelegatesHomework;

class Program
{
    static void Main(string[] args)
    {
        Machine machine = new Machine();

        var warehouse = new WarehouseDepartment();
        var qc = new QualityControlDepartment();
        var packaging = new PackagingDepartment();

        machine.OnPartProduced += warehouse.Store;
        machine.OnPartProduced += qc.Inspect;
        machine.OnPartProduced += packaging.PreparePackaging;

        // Машина производит детали
        machine.Produce();
        machine.Produce();
        machine.Produce();

        // Можно убрать одного из подписчиков
        machine.OnPartProduced -= qc.Inspect;

        machine.Produce();
    }
}