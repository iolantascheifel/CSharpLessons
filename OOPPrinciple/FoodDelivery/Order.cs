namespace OOPPrinciple.Доставка_еды;

public abstract class Order: ITrackable, ICostCalculable
{
    protected string[] itemNames;
    protected decimal baseCost;

    protected Order(string[] itemNames, decimal baseCost)
    {
        this.itemNames = itemNames;
        this.baseCost = baseCost;
    }

    public abstract decimal CalculateTotalCost();

    public virtual string GetStatus()
    {
        return "Создан";
    }
}