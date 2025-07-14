namespace CoffeeMachineProject;

public interface ICoffeeIngredientStorage
{
    bool HasIngredients(CoffeeIngredient ingredient);
    void UseIngredients(CoffeeIngredient ingredient);
    void AddIngredients();
}