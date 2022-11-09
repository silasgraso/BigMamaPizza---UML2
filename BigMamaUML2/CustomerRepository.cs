public class CustomerRepository
{
    #region Instance fields
    private Dictionary<string, Customer> _customers;
    #endregion

    #region Constructor
    public CustomerRepository()
    {
        _customers = new Dictionary<string, Customer>();
    }
    #endregion


    #region Methods
    
    /// <summary>
    /// This method adds a single pizza object 
    /// </summary>
    /// <param name="aCustomer"></param>
    public void AddCustomer(Customer aCustomer)
    {
        _customers.Add(aCustomer.Name, aCustomer);
    }

    public void UpdateCustomer(Customer aCustomer)
    {
        if (_customers.ContainsKey(aCustomer.Name))
        {
            _customers.Add(aCustomer.Name, aCustomer);
        }
    }

    public Customer ReadCustomer(string customerName)
    {
        if (_customers.ContainsKey(customerName))
        {
            Console.WriteLine(_customers[customerName]);
        }
        return
            null;
    }

    public Customer SearchCustomerName(string customerName)
    {
        if (_customers.ContainsKey(customerName))
        {
            return _customers[customerName];
        }
        else
            return null;
    }



    /// <summary>
    /// This method deletes a Pizza object from the dictonary
    /// If no such object exists, no object is deleted.
    /// </summary>
    public void DeleteCustomer(string customerName)
    {
        _customers.Remove(customerName);
    }


    /// <summary>
    /// This method returns a Pizza object (if any) from
    /// the dictonary of books, which has a matching pizza name.
    /// If no such object exists, the method returns null.
    /// </summary>
 

    public void PrintCustomer()
    {
        foreach (Customer customerName in _customers.Values)
        {
            Console.WriteLine(customerName._customerID + ". " + customerName._name + " " + customerName._adress + " " + 
                              Environment.NewLine + customerName._mail + Environment.NewLine);    
        }
    }
    #endregion




}