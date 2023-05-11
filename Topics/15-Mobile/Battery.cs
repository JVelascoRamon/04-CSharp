public class Battery
{
    //Esto son los campos
    private string _model;
    private int _hoursIdle;
    private int _hoursTalking;

    //Esto son las propiedades. Son reflejos de los campos. Sirve para acceder a ellos desde el Main, para no acceder a los campos directamente, que está feo por lo visto
    public string Model
    {
        get { return _model; }
        set { _model = value; }
    }

    public int HoursIdle
    {
        get { return _hoursIdle; }
        set { _hoursIdle = value; }
    }

    public int HoursTalking
    {
        get { return _hoursTalking; }
        set { _hoursTalking = value; }
    }

    public Battery() //Así pongo los valores por defecto
    {
        this._model = ("MODELO POR DEFECTO");
        this._hoursIdle = 0000;
        this._hoursTalking = 0000;
    }
    public Battery(string model, int hoursIdle, int hoursTalking)
    {
        this._model = model;
        this._hoursIdle = hoursIdle;
        this._hoursTalking = hoursTalking;
    }
}
