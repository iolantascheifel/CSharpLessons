namespace OOPPrinciple.Polymorphism;

public class DeliveryCalculator
{
    public decimal Calculate(double weight)
    {
        return (decimal)(weight * 10);
    }
    
    public decimal Calculate(double weight, double distance)
    {
        return (decimal)(weight * 10 + distance * 2);
    }
    
    public decimal Calculate(double weight, double distance, bool express)
    {
        decimal cost = (decimal)(weight * 10 + distance * 2);
        if (express)
        {
            cost += 100;
        }
        return cost;
    }
}