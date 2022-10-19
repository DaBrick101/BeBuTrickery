namespace BeBuTrickery_lib.Participant;

public class Player
{
    private string _name;
    private int _points;

    public int GetPoints()
    {
        return _points;
    }

    public void SetPoints(int points)
    {
        _points = points + _points;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public string GetName()
    {
        return _name;
    }
}