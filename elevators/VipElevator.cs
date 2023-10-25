public class VipElevator : Elevator
{
    private string _password;


    public VipElevator(int bottomFloor, int topFloor, string password) : base(bottomFloor, topFloor)
    {
        _password = password;
    }

    public bool EnterPassword(string password)
    {
        if (password == _password)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void ChangeFloor(int floor, string password)
    {
        bool correctPassword = EnterPassword(password);
        if (correctPassword)
        {
            OpenDoors();
            base.ChangeFloor(floor);
        }
        else
        {
            Console.WriteLine("Incorrect password");
        }
    }
}