using BeBuTrickery_lib.Participant;

namespace BeBuTrickery_lib.Gamefield;

public class Gamefield
{
    private Player _player;
    private int[] _numbers = new int[5];
    private int _seedNumber;
    private Random _rnd = new Random();

    public Gamefield()
    {
        _player = new Player();
    }
    public void SetPlayer(Player player)
    {
        _player = player;
    }

    public Player GetPlayer()
    {
        return _player;
    }

    public int[] GenerateDiceNumbers()
    {


        for (int j = 0; j < 5; j++)
        {
            _numbers[j] = _rnd.Next(1, 6);
        }
        return _numbers;
    }

    public int GenerateSeedNumber()
    {
        _seedNumber = _rnd.Next(1, 6);
        return _seedNumber;
    }
    public int[] GetDicesNumbers()
    {
        throw new NotImplementedException();
    }

}