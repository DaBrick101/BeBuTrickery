using System.Runtime.InteropServices;
using BeBuTrickery_lib.Participant;
using BeBuTrickery_lib.Gamefield;
namespace BeBuTrickeryGUI
{
    public partial class Form1 : Form
    {
        private Gamefield _gamefield;
        private int[] diceNumbersPlayer1;
        private int[] diceNumbersPlayer2;
        private int turn;
        public Form1(Gamefield gamefield)
        {
            InitializeComponent();
            _gamefield = gamefield;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //diceNumbersPlayer1.GenerateDiceNumbers();
            turn++;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}