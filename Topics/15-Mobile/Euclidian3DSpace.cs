public struct Euclidean3D
{
	public double _xCoord { get; set; } //Defino los campos y las propiedades automáticamente
	public double _yCoord { get; set; }
	public double _zCoord { get; set; }
    private static readonly Euclidean3D s_origin = new Euclidean3D (0, 0, 0); //Establezco el punto de origen como privado con las coordenadas (0, 0, 0)

    public Euclidean3D(double xCoord, double yCoord, double zCoord) //Valores para los parámetros
	{
		this._xCoord = xCoord;
		this._yCoord = yCoord;
        this._zCoord = zCoord;
	}

    public static Euclidean3D Origin //Aquí creo la static property para devolver el punto O.
    {
        get { return s_origin; }
    }

    public override string ToString() //Esto es un método
	{
		string coordenates = string.Format(
            "point Euclidean 3D coordenates: ({0},{1},{2})",
			this._xCoord, this._yCoord, this._zCoord); //Utilizo el string.Format para sacar por pantalla correctamente
		return coordenates;
	}
}