using System;

public class GSM
{
    private string _phoneModel;
    private string _manufacturer;
    private int _price;
    private string _owner;
    private Battery _battery;
    private Display _display;

    public GSM(string phoneModel, string manufacturer, int price, string owner, Battery battery = null, Display display = null) //Pongo los dos últimos a null por si acaso no los utilizo
    {
        this._phoneModel = phoneModel;
        this._manufacturer = manufacturer;
        this._price = price;
        this._owner = owner;
        this._battery = battery ?? new Battery(); //Sei existen, me voy a battery, si no, new Battery
        this._display = display ?? new Display();
    }

    public string PhoneModel
    {
        get { return _phoneModel; }
        set { _phoneModel = value; }
    }

    public string Manufacturer
    {
        get { return _manufacturer; }
        set { _manufacturer = value; }
    }

    public int Price
    {
        get { return _price; }
        set { _price = value; }
    }

    public string Owner
    {
        get { return _owner; }
        set { _owner = value; }
    }

    public Battery Battery
    {
        get { return _battery; }
        set { _battery = value; }
    }

    public Display Display
    {
        get { return _display; }
        set { _display = value; }
    }
}