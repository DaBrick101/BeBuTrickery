namespace BeBuTrickery_lib.Gamefield;

public class Gameboard : IGameboard
{
    private IPlayer _player;
    private int[] _numbers;
    private int _seedNumber;
    private Random _rnd = new Random();

    public Gameboard()
    {
        _player = new Player();
    }
    public void SetPlayer(IPlayer player)
    {
        _player = player;
    }

    public IPlayer GetPlayer()
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

    public void SetDiceNumbers(int[] diceNumbers)
    {
        throw new NotImplementedException();
    }
}