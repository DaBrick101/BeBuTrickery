namespace BeBuTrickery_lib.Participant;

public class Player
{
    private int _points;

    public int GetPoints()
    {
        return _points;
    }

    public void SetPoints(int points)
    {
        _points = points + _points;
    }
}