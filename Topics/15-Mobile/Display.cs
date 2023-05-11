public class Display
{
    private int _size;
    private int _numberOfColours;

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

    public Display() //Valores por defecto
    {
        this._size = 0;
        this._numberOfColours = 0;
    }
    public Display(int size, int numberOfColours)
    {
        this._size = size;
        this._numberOfColours = numberOfColours;
    }
}
