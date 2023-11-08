using System.Runtime.InteropServices;

public class Room
{
    List<SmartDevice> _smartDevices = new List<SmartDevice>();


    public void AddDevice(SmartDevice smartDevice)
    {
        _smartDevices.Add(smartDevice);
    }
    
    public void TurnOnAllLights()
    {
        foreach (SmartDevice smartDevice in _smartDevices)
        {
            if (smartDevice.IsLight())
            {
                smartDevice.TurnOn();
            }
        }
    }

    public void TurnOffAllLights()
    {
        foreach (SmartDevice smartDevice in _smartDevices)
        {
            if (smartDevice.IsLight())
            {
                smartDevice.TurnOff();
            }
        }
    }

    public void TurnOnDevice(SmartDevice smartDevice)
    {
        if (_smartDevices.Contains(smartDevice))
        {
            smartDevice.TurnOn();
        }
        else
        {
            Console.WriteLine("Smart device is not in room");
        }
    }

    public void TurnOnAllDevices()
    {
        foreach (SmartDevice smartDevice in _smartDevices)
        {
            smartDevice.TurnOn();
        }
    }

    public void TurnOffAllDevices()
    {
        foreach (SmartDevice smartDevice in _smartDevices)
        {
            smartDevice.TurnOff();
        }
    }

    public void ReportAllDevices()
    {
        foreach (SmartDevice smartDevice in _smartDevices)
        {
            Console.Write(smartDevice.GetName());
            if (smartDevice.GetIsOn())
            {
                Console.WriteLine(" is on");
            }
            else
            {
                Console.WriteLine(" is off");
            }
        }
    }

    public void ReportOnDevices()
    {
        foreach (SmartDevice smartDevice in _smartDevices)
        {
            if (smartDevice.GetIsOn())
            {
                Console.WriteLine(smartDevice.GetName() + " is on");
            }
        }
    }

    public void ReportLongestOnDevice()
    {
        SmartDevice longestOnDevice = _smartDevices[0];
        foreach (SmartDevice smartDevice in _smartDevices.Skip(1))
        {
            if (smartDevice.GetHowLongOn() > longestOnDevice.GetHowLongOn())
            {
                longestOnDevice = smartDevice;
            }
        }
        Console.WriteLine($"The device that's been on the longest is {longestOnDevice.GetName()}");
    }
}