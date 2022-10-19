using System.Runtime.InteropServices;
using BeBuTrickery_lib.Participant;
using BeBuTrickery_lib.Gamefield;
namespace BeBuTrickeryGUI
{
    public partial class Form1 : Form
    {
        private Gamefield _gamefield;
        private Player _player1;
        private Player _player2;
        private Player _currentPlayer;
        private int[] diceNumbersPlayer = new int[5];
        private int seedNumber;
        private int _points;
        private int turn;
        
        public Form1(Gamefield gamefield, Player player)
        {
            InitializeComponent();
            _gamefield = gamefield;
            _player1 = new Player();
            _player2 = new Player();
        }

        public Form1()
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CheckTurn()
        {
            if (turn % 2 == 0)
            {
                _currentPlayer = _player1;
            }
            else
            {
                _currentPlayer = _player2;
            }
        }

        private int CalcPoints()
        {
            foreach (var number in diceNumbersPlayer)
            {
                bool exists = Array.Exists(diceNumbersPlayer, number => number == seedNumber);
                if (exists)
                {
                    _points += seedNumber;
                }
            }
            return _points;
        }

        private void SetTxtBoxRandomNumbers()
        {
            txt_Zahl1.Text = diceNumbersPlayer[0].ToString();
            txt_Zahl2.Text = diceNumbersPlayer[1].ToString();
            txt_Zahl3.Text = diceNumbersPlayer[2].ToString();
            txt_Zahl4.Text = diceNumbersPlayer[3].ToString();
            txt_Zahl5.Text = diceNumbersPlayer[4].ToString();
        }

        private void btn_Anfangszahl_Click(object sender, EventArgs e)
        {
            seedNumber = _gamefield.GenerateSeedNumber();
            SetSeedNumbertxt();
            btn_Start.Enabled = true;
            btn_Anfangszahl.Enabled = false;

        }

        private void SetSeedNumbertxt()
        {
            txt_Anfangszahl.Text = seedNumber.ToString();
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            turn++;
            CheckTurn();
            diceNumbersPlayer = _gamefield.GenerateDiceNumbers();
            seedNumber = _gamefield.GenerateSeedNumber();
            SetTxtBoxRandomNumbers();
            CalcPoints();
            _currentPlayer.SetPoints(_points);
            _points = 0;
            SetPlayerScore();
            btn_Anfangszahl.Enabled = true;
            btn_Start.Enabled = false;
        }

        private void SetPlayerScore()
        {
            txt_Player1.Text  = _player1.GetPoints().ToString();
            txt_Player2.Text  = _player2.GetPoints().ToString();
        }
    }
}