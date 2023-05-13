using System;
using System.Text;
public enum BatteryType{LiIon, NiMH, NiCd} //Esto crea una enumeration. Es como un tipo de variable (BatteryType)

public class Battery
{
    // ---CAMPOS---
    private string _model;
    private int? _hoursIdle;
    private int? _hoursTalking;
    private BatteryType? _batteryType; // Creo el campo que proviene del enum
    
    // ---CONSTRUCTOR---
    public Battery(string model, int? hoursIdle = null, int? hoursTalking = null, BatteryType? batteryType = null) // Aquí pongo los valores al introducir los parámetros. Por defecto da null si no existen los argumentos
    {
        //this._batteryType = BatteryType; Ver la clase del 12/05/2023 a las 9:30.
        this._model = model;
        this._hoursIdle = hoursIdle;
        this._hoursTalking = hoursTalking;
        this._batteryType = batteryType;
    }

    // ---PROPIEDADES---
    //Esto son las propiedades. Son reflejos de los campos. Sirve para acceder a ellos desde el Main, para no acceder a los campos directamente, que está feo por lo visto
    public string Model
    {
        get { return _model; }
        set { _model = value; }
    }

    public int? HoursIdle
    {
        get { return _hoursIdle; }
        set { _hoursIdle = value.GetValueOrDefault(); } //Con el .GetValueOrDefault() consigo gestionar el problema de pasar un int? a int, ya que si el valor es nulo, devuelve el defoult, que es 0.
    }

    public int? HoursTalking
    {
        get { return _hoursTalking; }
        set { _hoursTalking = value.GetValueOrDefault();}
    }

    public BatteryType? BatteryType
    {
        get { return _batteryType; }
        set { _batteryType = value.GetValueOrDefault(); }
    }

    //Para sacar los datos de la batería en formato string
    public override string ToString() 
    {
        StringBuilder info = new StringBuilder();
        info.AppendLine("\n-------- BATTERY INFORMATION --------");

        if (this.BatteryType != null)
            info.AppendLine("Battery type: " + this.BatteryType);
        else
            info.AppendLine("There is no info about the battery");

        if (this.Model != null)
            info.AppendLine("Battery model: " + this.Model);
        
        if (this.HoursIdle != null)
            info.AppendLine("Standby hours: " + this.HoursIdle + "h");

        if (this.HoursTalking != null)
            info.AppendLine("Using hours: " + this.HoursTalking + "h");

        return info.ToString();
    }
}
    
