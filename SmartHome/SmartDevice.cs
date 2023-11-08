using System.Diagnostics;

public abstract class SmartDevice
{
   private string _name;
   private bool _isOn = false;
   protected bool _isLight;
   private Stopwatch _stopwatch = new Stopwatch();


   public SmartDevice(string name)
   {
        _name = name;
   }


    public void TurnOn()
    {
        _isOn = true;
        _stopwatch.Start();
    }

    public void TurnOff()
    {
        _isOn = false;
        _stopwatch.Reset();
    }

    public bool GetIsOn()
    {
        return _isOn;
    }

    public TimeSpan GetHowLongOn()
    {
        return _stopwatch.Elapsed;
    }

    public bool IsLight()
    {
        return _isLight;
    }

    public string GetName()
    {
        return _name;
    }
}