using System.Text;
public class Display
{
    private int _size;
    private int _numberOfColours;


    public Display() //Valores por defecto
    {
        this._size = 0;
        this._numberOfColours = 0;
    }
    public Display(int size, int numberOfColours) //Valores con parámetros
    {
        this._size = size;
        this._numberOfColours = numberOfColours;
    }


    public int Size
    {
        get { return _size; }
        set { _size = value; }
    }

    public int NumberOfColours
    {
        get { return _numberOfColours; }
        set { _numberOfColours = value; }
    }

    public override string ToString() //Para sacar los datos del display en formato string
    {
        StringBuilder info = new StringBuilder();
        info.AppendLine("-------- DISPLAY INFORMATION --------");
        
        if (this.Size != 0)
            info.AppendLine("Display size: " + this.Size + "\"");
        else
            info.AppendLine("There is no info about the display");

        if (this.NumberOfColours != 0)
            info.AppendLine("Display's number of colours: " + this.NumberOfColours);

        return info.ToString();
    }
}
