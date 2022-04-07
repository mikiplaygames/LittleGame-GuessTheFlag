namespace GuessTheFlag
{
    public partial class Form1 : Form
    {
        List<string> flagsFileNames = new List<string>();
        List<string> flagsCountries = new List<string>();

        string[] txt = File.ReadAllLines("countries.txt");

        int pkt = 0;

        int currentQuestion;
        public Form1()
        {
            InitializeComponent();
            MakeLists();
            NextQuestion(RandomNumber());
        }

        private void MakeLists()
        {
            for (int i = 0; i < txt.Length; i++)
            {
                string[] vs = txt[i].Split(':');
                flagsFileNames.Add(vs[0]);
                flagsCountries.Add(vs[1]);
            }
        }
        public void nextButton_Click(object sender, EventArgs e)
        {
            CheckQuestion(currentQuestion);
        }
        public void skipButton_Click(object sender, EventArgs e)
        {
            NextQuestion(RandomNumber());
            answerBox.Text = "";
        }

        public void NextQuestion(int i)
        {
            currentQuestion = i;
            pictureBox1.ImageLocation = $"Flags/{flagsFileNames[i]}.png";
        }
        public void CheckQuestion(int number)
        {
            if (answerBox.Text.ToLower() == flagsCountries[number].ToLower())
            {
                answerBox.Text = "";
                happyText.Text = "Wybitnie!";
                pkt++;
                pktLabel.Text = $"Liczba Punktów: {pkt.ToString()}";
                NextQuestion(RandomNumber());
            }
            else
            {
                answerBox.Text = "";
                happyText.Text = "le";
                NextQuestion(RandomNumber());
            }
        }
        public int RandomNumber()
        {
            return Random.Shared.Next(0, txt.Length);
        }
    }
}