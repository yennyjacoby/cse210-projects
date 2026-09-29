using System;

public class Customer
{
    private string _customerName;

    //create the _address variable by taking it from Address class
    private Address _address;

// CONSTRUCTOR
    public Customer(string customerName, Address address)
    {
        _customerName = customerName;
        _address = address;
    }

//bool is a data type, not a method
//use to know when a value is TRUE or FALSE
//If the country is "USA", the method returns true.
//If the country is "Colombia", it returns false.
public bool LiveInUsa() 
    {
        //Getting the value from the class Address
        return _address.InsideUsa();
    }

public string GetName()
    {
        return _customerName;
    }

public Address GetAddress()
    {
        //getting Address object
        return _address;
    }

}

