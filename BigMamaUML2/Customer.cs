public class Customer
{
    public int _customerID;
    public string _name;
    public string _mail;
    public string _adress;
    public Customer(int customerID, string Name,string Mail, string Adress)
    {
        _customerID = customerID;
        _name = Name;
        _mail = Mail;
        _adress = Adress;    
    }

    public override string ToString()
    {
        return _customerID + ". " + _name + " " + _mail + " " + Environment.NewLine + _adress + Environment.NewLine;
    }

    public int CustomerID
    {
        get { return _customerID; }
        set { _customerID = value; }
    }

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public string Mail
    {
        get { return _mail; }
        set { _mail = value; }
    }

    public string Adress
    {
        get { return _adress; }
        set { _adress = value; }
    }

}


