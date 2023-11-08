// See https://aka.ms/new-console-template for more information

SmartLight smartLight = new SmartLight();
SmartHeater smartHeater = new SmartHeater();
SmartTV smartTV = new SmartTV();

Console.WriteLine(smartLight.GetName());

Console.WriteLine(smartLight.GetIsOn());
smartLight.TurnOn();
Console.WriteLine(smartLight.GetIsOn());

Thread.Sleep(5000);
Console.WriteLine(smartLight.GetHowLongOn());
smartLight.TurnOff();
Console.WriteLine(smartLight.GetHowLongOn());

House house = new House();
Room room = new Room();
room.AddDevice(smartLight);
room.AddDevice(smartHeater);
room.AddDevice(smartTV);
house.AddRoom(room);

room.TurnOnAllLights();
Console.WriteLine(smartLight.GetIsOn());
room.TurnOffAllLights();
Console.WriteLine(smartLight.GetIsOn());

Console.WriteLine(smartTV.GetIsOn());
room.TurnOnDevice(smartTV);
Console.WriteLine(smartTV.GetIsOn());

room.ReportAllDevices();

room.ReportOnDevices();
room.TurnOnAllDevices();
room.ReportOnDevices();

room.ReportLongestOnDevice();

room.TurnOffAllDevices();
room.ReportOnDevices();