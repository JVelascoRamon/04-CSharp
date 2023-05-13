//Create a class Call to hold a call performed through a GSM. It should contain date, time, dialed phone number and duration (in seconds).
using System;
using System.Text;

public class Call
{
    // ---CAMPOS---
    private DateTime _dateTime;// new DateTime(2023, 5, 11, 12, 30, 0);
    private int _dialedPhoneNumber;
    private int _duration;

    // ---CONSTRUCTORES---
    public Call() //Valores por defecto
    {
        this._dateTime = new DateTime(1111, 1, 1, 1, 1, 1);
        this._dialedPhoneNumber = 0;
        this._duration = 0;
    }
    public Call(DateTime dateTime, int dialedPhoneNumber, int duration) //Valores con parámetros
    {
        this._dateTime = dateTime;
        this._dialedPhoneNumber = dialedPhoneNumber;
        this._duration = duration;
    }

    // ---PROPIEDADES---
    public DateTime DateTime
    {
        get { return _dateTime; }
        set { _dateTime = value; }
    }

    public int DialedPhoneNumber
    {
        get { return _dialedPhoneNumber; }
        set { _dialedPhoneNumber = value; }
    }

    public int Duration
    {
        get { return _duration; }
        set { _duration = value; }
    }

    public override string ToString() //Para sacar los datos del Call en formato string
    {
        StringBuilder info = new StringBuilder();
        info.AppendLine("-------- CALL INFORMATION --------");
        
        if (this.DateTime != new DateTime(1111, 1, 1, 1, 1, 1))
            info.AppendLine("Date: " + this.DateTime);
        else
            info.AppendLine("There are no calls");

        if (this.DialedPhoneNumber != 0)
            info.AppendLine("Number dialed: " + this.DialedPhoneNumber);

        if (this.Duration != 0)
            info.AppendLine("Duration: " + this.Duration + "\'");

        return info.ToString();
    }
}
