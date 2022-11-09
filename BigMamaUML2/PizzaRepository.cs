using static System.Reflection.Metadata.BlobBuilder;

public class PizzaRepository
{
    #region Instance fields
    private Dictionary<string, Pizza> _pizzas;
    #endregion

    #region Constructor
    public PizzaRepository()
    {
        _pizzas = new Dictionary<string, Pizza>();
    }
    #endregion


    #region Methods
    
    /// <summary>
    /// This method adds a single pizza object 
    /// </summary>
    /// <param name="aPizza"></param>
    public void AddPizza(Pizza aPizza)
    {
        _pizzas.Add(aPizza.PizzaName, aPizza);
    }

    public void UpdatePizza(Pizza aPizza)
    {
        if (_pizzas.ContainsKey(aPizza.PizzaName))
        {
            _pizzas.Add(aPizza.PizzaName, aPizza);
        }
    }

    public Pizza ReadPizzaName(string pizzaName)
    {
        if (_pizzas.ContainsKey(pizzaName))
        {
            Console.WriteLine(_pizzas[pizzaName]);
        }
        return
            null;
    }

 
    public Pizza SearchPizzaName(string pizzaName)
    {
        if (_pizzas.ContainsKey(pizzaName))
        {
            return _pizzas[pizzaName];
        }
        else
            return null;
    }



    /// <summary>
    /// This method deletes a Pizza object from the dictonary
    /// If no such object exists, no object is deleted.
    /// </summary>
    public void DeletePizza(string pizzaName)
    {
        _pizzas.Remove(pizzaName);
    }


    /// <summary>
    /// This method returns a Pizza object (if any) from
    /// the dictonary of books, which has a matching pizza name.
    /// If no such object exists, the method returns null.
    /// </summary>
 

    public void PrintMenu()
    {

        foreach (Pizza pizzaName in _pizzas.Values)
        {
            Console.WriteLine("\n Menu:" + Environment.NewLine + pizzaName._pizzaID + ". " + pizzaName._pizzaName + " " + pizzaName._pizzaPrice + ",- kr. " + 
                              Environment.NewLine + pizzaName._pizzaDescription + Environment.NewLine);    
        }
    }
    #endregion

    public bool pizzaMenuExist()
    {
        if (_pizzas.Count == 0)
        {
            return false;
        }
        else
            return true;
    }
}