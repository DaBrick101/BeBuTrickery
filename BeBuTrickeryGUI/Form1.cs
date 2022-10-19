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
        private Player currentPlayer;
        private int[] diceNumbersPlayer;
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

        private void button1_Click(object sender, EventArgs e)
        {
            turn++;
            CheckTurn();
            diceNumbersPlayer = _gamefield.GenerateDiceNumbers();
            seedNumber = _gamefield.GenerateSeedNumber();
        }

        private void CheckTurn()
        {
            if (turn % 2 == 0)
            {
                currentPlayer = _player1;
            }
            else
            {
                currentPlayer = _player2;
            }
        }

        private int CalcPoints()
        {
            foreach (var number in diceNumbersPlayer)
            {
                bool exists = Array.Exists(diceNumbersPlayer, element => element == searchElement);
            }
            return _points;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}