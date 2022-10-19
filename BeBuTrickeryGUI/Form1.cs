using BeBuTrickery_lib.Participant;
using BeBuTrickery_lib.Gamefield;
namespace BeBuTrickeryGUI
{
    public partial class Form1 : Form
    {
        private Gamefield _gamefield;
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
            _gamefield.GenerateDiceNumbers();
        }
    }
}