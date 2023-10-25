Elevator elevator1 = new Elevator(1, 30);
Elevator elevator2 = new Elevator(1, 30);
VipElevator vipElevator = new VipElevator(1, 31, "rightpassword");

Console.WriteLine(elevator1.DisplayFloor());
Console.WriteLine(elevator2.DisplayFloor());
Console.WriteLine(vipElevator.DisplayFloor());


elevator1.ChangeFloor(5);
elevator2.ChangeFloor(50);
elevator2.ChangeFloor(-10);
vipElevator.ChangeFloor(8, "wrongpassword");


Console.WriteLine(elevator1.DisplayFloor());
Console.WriteLine(elevator2.DisplayFloor());
Console.WriteLine(vipElevator.DisplayFloor());


vipElevator.ChangeFloor(8, "rightpassword");


Console.WriteLine(vipElevator.DisplayFloor());