namespace ProSpike
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            titleText.Text = "Power High Ball";
        }

        private void PwrShootBtn_Click(object sender, EventArgs e)
        {
            titleText.Text = "Power Shoot";
        }

        private void MidHBall_Click(object sender, EventArgs e)
        {
            titleText.Text = "Middle High Ball";
        }

        private void MidQuickBtn_Click(object sender, EventArgs e)
        {
            titleText.Text = "Middle Quick";
        }

        private void OffHBallBtn_Click(object sender, EventArgs e)
        {
            titleText.Text = "Offside High Ball";
        }

        private void Custom_Click(object sender, EventArgs e)
        {
            titleText.Text = "Custom";
        }

        private void BackCBtn_Click(object sender, EventArgs e)
        {
            titleText.Text = "Backrow C";
        }

        private void BackPipeBtn_Click(object sender, EventArgs e)
        {
            titleText.Text = "Backrow Pipe";
        }

        private void OffSlideBtn_Click(object sender, EventArgs e)
        {
            titleText.Text = "Offside Slide";
        }

    }
}