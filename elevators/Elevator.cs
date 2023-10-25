public class Elevator
{
    private int _currentFloor = 0;
    private int _bottomFloor;
    private int _topFloor;
    private bool _doorsOpen = false;

    public Elevator(int bottomFloor, int topFloor)
    {
        _bottomFloor = bottomFloor;
        _topFloor = topFloor;
    }

    public void ChangeFloor(int floor)
    {
        if (_topFloor >= floor && _bottomFloor <= floor)
        {
            _currentFloor = floor;
        }
        else
        {
            Console.WriteLine("Invalid floor number");
        }
    }

    public void OpenDoors()
    {
        _doorsOpen = true;
    }

    public void CloseDoors()
    {
        _doorsOpen = false;
    }

    public string DisplayFloor()
    {
        return $"{_currentFloor}";
    }

    public string ListFloors()
    {
        return $"{_bottomFloor}-{_topFloor}";
    }

    public bool GetDoorsOpen()
    {
        return _doorsOpen;
    }
}