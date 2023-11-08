// See https://aka.ms/new-console-template for more information

TestDevice testDevice = new TestDevice("testdevice");

Console.WriteLine(testDevice.IsOn());
testDevice.TurnOn();
Console.WriteLine(testDevice.IsOn());

Thread.Sleep(5000);

Console.WriteLine(testDevice.HowLongOn());
testDevice.TurnOff();
Console.WriteLine(testDevice.HowLongOn());