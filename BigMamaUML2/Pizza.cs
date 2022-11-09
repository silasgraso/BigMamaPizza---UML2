public class Pizza
{
    public int _pizzaID;
    public string _pizzaName;
    public double _pizzaPrice;
    public string _pizzaDescription;
    public Pizza(int pizzaID, string pizzaName, double pizzaPrice, string pizzaDescription)
    {
        _pizzaID = pizzaID;
        _pizzaName = pizzaName;
        _pizzaPrice = pizzaPrice;
        _pizzaDescription = pizzaDescription;
    }

    public override string ToString()
    {
        return _pizzaID + ". " + _pizzaName + " " + _pizzaPrice + ",- kr. " + Environment.NewLine + _pizzaDescription + Environment.NewLine; 
    }

    public int PizzaID
    {
        get { return _pizzaID; }
        set { _pizzaID = value; }
    }

    public string PizzaName
    {
        get { return _pizzaName; }
        set { _pizzaName = value; }
    }

    public double PizzaPrice
    {
        get { return _pizzaPrice; }
        set { _pizzaPrice = value; }
    }

    public string PizzaDescription
    {
        get { return _pizzaDescription; }
        set { _pizzaDescription = value; }   
    }

}

