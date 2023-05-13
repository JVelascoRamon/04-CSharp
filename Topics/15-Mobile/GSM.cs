using System;
using System.Text;

public class GSM
{
    // ---CAMPOS---
    private string _phoneModel;
    private string _manufacturer;
    private int _price;
    private string _owner;
    private Battery _battery;
    private Display _display;
    private static readonly GSM s_iPhone4s = new GSM ("iPhone 4s", "Apple", 349, "Steve Jobs",new Call(new DateTime(2023, 5, 13, 13, 18, 0), 555879657, 27), new Battery ("500mAh", 40, 15, BatteryType.NiCd), new Display (4, 128)); //Establezco los datos del iPhone 4s
    private Call _call;
    
    // ---CONSTRUCTOR---
    public GSM(string phoneModel, string manufacturer, int price = 0, string owner = "null",Call call = null, Battery battery = null, Display display = null) //Pongo los dos últimos a null por si acaso no los utilizo
    {
        this._phoneModel = phoneModel;
        this._manufacturer = manufacturer;
        this._price = price;
        this._owner = owner;
        this._call = call ?? new Call();
        this._battery = battery ?? new Battery(null, null, null, null); //Si existen, me voy a battery. Si Battery es null, me voy a new Battery sin parámetros, que me da los argumentos por defecto
        this._display = display ?? new Display();
    }

    // ---PROPIEDADES---
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

    public Call Call
    {
        get { return _call; }
        set { _call = value; }
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

    public static GSM IPhone4s
    {
        get {return s_iPhone4s;}
    }

    // Para devolver información en forma de string. Es muy útil
    public override string ToString()
    {
        StringBuilder info = new StringBuilder();
        info.AppendLine("-------- MOBILE INFORMATION --------");
        info.AppendLine($"Phone model: {this.PhoneModel}");
        info.AppendLine($"Manufacturer: {this.Manufacturer}");
        
        if (this.Price != 0)
            info.AppendLine(string.Format("Price: {0}$", this.Price));
        
        if (this.Owner != "null")
            info.AppendLine("Owner: " + this.Owner);
        
        if (this.Battery != null)
            info.AppendLine((Battery != null ? "" : Environment.NewLine) + Battery.ToString());

        if (this.Display != null)
            info.AppendLine(Display.ToString());
            
        if (this.Call != null)
            info.AppendLine((Call != null ? "" : Environment.NewLine) + Call.ToString());

        info.AppendLine("-------- ++++++++++++++++++ --------");

        return info.ToString(); 

    }
}