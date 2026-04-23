 namespace Idol_Clicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //CancellationTokenSource tokenSource = new CancellationTokenSource();
        //CancellationToken tokenIntro = new CancellationToken();
        //CancellationToken tokenTutorial = new CancellationToken();
        int crystals = 0;
        int crystalsPerClick = 1;
        int delayTimer = 0; //0 to skip dialogue, 2000 for intended
        private void label1_Click(object sender, EventArgs e) // "Idol Clicker" title
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Idol Clicker";
        }
        private void label2_Click(object sender, EventArgs e) //title sparkle left
        {

        }

        private void button1_Click(object sender, EventArgs e) //play button
        {
            label1.Hide();
            label2.Hide();
            label3.Hide();
            button1.Hide();
            button2.Hide();

            menuStrip1.Show();
            textBox1.Show();
            pictureBox1.Show();
            label6.Show();

            introDialog();
        }

        //void keyDown(object sender, KeyEventArgs e) //debug commands
        //{
        //    switch (e.KeyCode) {
        //        case Keys.S: //skip text debug
        //            string test = "hmm";
        //            string caption = "test box";
        //            var result = MessageBox.Show(test, caption, MessageBoxButtons.OK);
        //            break;
        //        default:
        //            break;
        //    }
        //}
        async Task introDialog() //allows for delayed text to simulate real-time typing
        {
            await Task.Delay(delayTimer);
            AddText("Hello!");
            await Task.Delay(delayTimer);
            AddText("My name is Hatsune Miku!");
            await Task.Delay(delayTimer);
            AddText("What's your name?");
            await Task.Delay(delayTimer);
            label4.Show();
            textBox2.Show();
        }
        async Task tutorialDialog() //allows for delayed text to simulate real-time typing
        {
            await Task.Delay(delayTimer * 2);
            AddText("I can tell you're going to be a great manager!");
            await Task.Delay(delayTimer * 2);
            AddText("Click on me to earn crystals, which can be used to buy upgrades.");
            activateCrystals();
            await Task.Delay(delayTimer * 2);
            AddText("Earn enough, and you'll be able to buy outfits and even hire other idols!");
            await Task.Delay(delayTimer * 2);
            AddText("If you need help, click the Help button at the top.");
            await Task.Delay(delayTimer * 2);
            AddText("I look forward to working with you!");
        }

        void activateCrystals()
        {
            pictureBox2.Show();
            label5.Show();
            label7.Show();

            button3.Show();
            button4.Show();
            button5.Show();
            button6.Show();

            label7.Text = crystals.ToString();
            textBox1.Clear();
            label8.Show();
            label9.Show();
            label9.Text = crystalsPerClick.ToString() + "x";
        }
        void updateCrystals()
        {
            label7.Text = crystals.ToString();
            label9.Text = crystalsPerClick.ToString() + "x";
            updateButtons();
        }
        void updateButtons()
        {
            if (crystals >= 10)
            {
                button3.BackColor = Color.LimeGreen;
            } else
                {
                    button3.BackColor = Color.SkyBlue;
                }
            if (crystals >= 50)
            {
                button4.BackColor = Color.LimeGreen;
            } else
              {
                    button4.BackColor = Color.SkyBlue;
              }
            if(crystals >= 500)
            {
                button5.BackColor = Color.LimeGreen;
            } else
              {
                    button5.BackColor = Color.SkyBlue;
              }
            if(crystals >= 2500)
            {
                button6.BackColor = Color.LimeGreen;
            } else
                {
                    button6.BackColor= Color.SkyBlue;
                }

        }

        private void button2_Click(object sender, EventArgs e) //exit button
        {
            Application.Exit();
        }

        private void textBox2_TextChanged(object sender, EventArgs e) //inputting name field
        {
            if (textBox2.Text.Length > 0)
            {
                char c = textBox2.Text[textBox2.Text.Length - 1];
                if (c.ToString() == "\n")
                {
                    AddText($"{textBox2.Text} It's nice to meet you!");
                    textBox2.Text = "";
                    label4.Hide();
                    textBox2.Hide();
                    tutorialDialog();
                }
            }
        }
        void AddText(string text)
        {
            textBox1.Text += text + "\r\n";
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e) //menu bar
        {

        }

        private void earningGemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string gemTutorial = "Earning crystals is easy! Simply click your idol and she will perform. Then, use your hard-earned crystals to buy upgrades and outfits!";
            string caption = "Earning Crystals";
            var result = MessageBox.Show(gemTutorial, caption, MessageBoxButtons.OK);
        }

        private void unlockingOutfitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string outfitTutorial = "Click the outfits tab in the menu bar to purchase and change outfits. Most outfits can be unlocked with gems, but some require certain circumstances to be met in order to be unlocked. Try poking around and see what you can find!";
            string caption = "Unlocking Outfits";
            var result = MessageBox.Show(outfitTutorial, caption, MessageBoxButtons.OK);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e) //miku herself
        {
            crystals += crystalsPerClick;
            updateCrystals();
        }

        private void label5_Click(object sender, EventArgs e) //crystal label
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e) //crystals icon
        {

        }

        private void label7_Click(object sender, EventArgs e) //crystal amount
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e) //upgrades label
        {

        }
        void insufficientCrystals()
        {
            string notEnoughCrystals = "You don't have enough crystals for this!";
            string caption = "Insufficient Crystals";
            var result = MessageBox.Show(notEnoughCrystals, caption, MessageBoxButtons.OK);
        }
        private void button3_Click(object sender, EventArgs e) //perform a show button
        {
            if (crystals >= 10)
            {
                crystalsPerClick++;
                crystals = crystals - 10;
                updateCrystals();
            }
            else
            {
                insufficientCrystals();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (crystals >= 50)
            {
                crystalsPerClick += 10;
                crystals = crystals - 50;
                updateCrystals();
            }
            else
            {
                insufficientCrystals();
            }
        }

        private void label9_Click(object sender, EventArgs e) //clicks/second
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e) //create choreo
        {
            if (crystals >= 500)
            {
                crystalsPerClick += 100;
                crystals = crystals - 500;
                updateCrystals();
            }
            else
            {
                insufficientCrystals();
            }
        }

        private void button6_Click(object sender, EventArgs e) //film music video
        {
            if (crystals >= 2500)
            {
                crystalsPerClick += 1000;
                crystals = crystals - 2500;
                updateCrystals();
            }
            else
            {
                insufficientCrystals();
            }
        }
    }
}
