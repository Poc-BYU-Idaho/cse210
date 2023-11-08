using System.Diagnostics;

public abstract class SmartDevice
{
   private string _name;
   private bool _isOn = false;
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

    public bool IsOn()
    {
        return _isOn;
    }

    public TimeSpan HowLongOn()
    {
        return _stopwatch.Elapsed;
    }
}