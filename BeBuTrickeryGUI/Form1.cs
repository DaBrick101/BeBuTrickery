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
                if (number == seedNumber)
                {
                   _points += seedNumber;
                }
            }
            return _points;
        }

        private void SetTxtBoxRandomNumbers()
        {
            #region MyRegion

            if (diceNumbersPlayer[0] == seedNumber)
            {
                txt_Zahl1.BackColor = Color.Green;
            }
            if (diceNumbersPlayer[1] == seedNumber)
            {
                txt_Zahl2.BackColor = Color.Green;

            }
            if (diceNumbersPlayer[2] == seedNumber)
            {
                txt_Zahl3.BackColor = Color.Green;

            }
            if (diceNumbersPlayer[3] == seedNumber)
            {
                txt_Zahl4.BackColor = Color.Green;

            }
            if (diceNumbersPlayer[4] == seedNumber)
            {
                txt_Zahl5.BackColor = Color.Green;

            }

            #endregion

            txt_Zahl1.Text = diceNumbersPlayer[0].ToString();
            txt_Zahl2.Text = diceNumbersPlayer[1].ToString();
            txt_Zahl3.Text = diceNumbersPlayer[2].ToString();
            txt_Zahl4.Text = diceNumbersPlayer[3].ToString();
            txt_Zahl5.Text = diceNumbersPlayer[4].ToString();
        }

        private void btn_Anfangszahl_Click(object sender, EventArgs e)
        {
            StopGame();
            CheckTurn();
            seedNumber = _gamefield.GenerateSeedNumber();
            SetSeedNumbertxt();
            btn_Start.Enabled = true;
            btn_Anfangszahl.Enabled = false;
            txt_Zahl1.BackColor = Color.Red;
            txt_Zahl2.BackColor = Color.Red;
            txt_Zahl3.BackColor = Color.Red;
            txt_Zahl4.BackColor = Color.Red;
            txt_Zahl5.BackColor = Color.Red;
        }

        private void SetSeedNumbertxt()
        {
            txt_Anfangszahl.Text = seedNumber.ToString();
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            turn++;
            diceNumbersPlayer = _gamefield.GenerateDiceNumbers();
            SetTxtBoxRandomNumbers();
            CalcPoints();
            _currentPlayer.SetPoints(_points);
            SetPlayerScore();
            _points = 0;
            btn_Anfangszahl.Enabled = true;
            btn_Start.Enabled = false;
        }

        private void SetPlayerScore()
        {
            txt_Player1.Text  = _player1.GetPoints().ToString();
            txt_Player2.Text  = _player2.GetPoints().ToString();
        }

        private void StopGame()
        {
            if (turn == 20)
            {
                if (_player1.GetPoints() > _player2.GetPoints())
                {
                    txt_Player1.ForeColor = Color.Green;
                    txt_Player1.Text = "Du hast gebonnen";
                    txt_Player2.ForeColor = Color.Red;
                    txt_Player2.Text = "Du hat Veloden";
                }
                else if (_player2.GetPoints() > _player1.GetPoints())
                {
                    txt_Player2.ForeColor = Color.Green;
                    txt_Player2.Text = "Du hast gebonnen";
                    txt_Player1.ForeColor = Color.Red;
                    txt_Player1.Text = "Du hat Veloden";
                }
            }
        }
    }
}