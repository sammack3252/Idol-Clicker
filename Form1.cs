 namespace Idol_Clicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int crystals = 0;
        int crystalsPerClick = 1;
        int delayTimer = 1000; //0 to skip dialogue, 1000 for intended

        //outfits
        bool leoUnlocked = false;
        bool moreUnlocked = false;
        bool vbsUnlocked = false;
        bool wonderlandUnlocked = false;
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
            button7.Hide();

            menuStrip1.Show();
            textBox1.Show();
            pictureBox1.Show();

            introDialog();
        }
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
            AddText("Earn enough, and you'll be able to buy different outfits!");
            label10.Show();
            button8.Show();
            button9.Show();
            button10.Show();
            button11.Show();
            await Task.Delay(delayTimer * 2);
            AddText("If you need help, click the Help button at the top.");
            await Task.Delay(delayTimer * 2);
            AddText("I look forward to working with you!");
        }

        void activateCrystals()
        {
            pictureBox2.Show();
            label5.Show();
            label6.Show();
            label7.Show();

            button3.Show();
            button4.Show();
            button5.Show();
            button6.Show();

            label7.Text = crystals.ToString();
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
            }
            else
            {
                button3.BackColor = Color.SkyBlue;
            }
            if (crystals >= 50)
            {
                button4.BackColor = Color.LimeGreen;
            }
            else
            {
                button4.BackColor = Color.SkyBlue;
            }
            if (crystals >= 500)
            {
                button5.BackColor = Color.LimeGreen;
            }
            else
            {
                button5.BackColor = Color.SkyBlue;
            }
            if (crystals >= 2500)
            {
                button6.BackColor = Color.LimeGreen;
            }
            else
            {
                button6.BackColor = Color.SkyBlue;
            }

            if (!leoUnlocked && crystals >= 2000)
            {
                button8.BackColor = Color.LimeGreen;
            }
            else
            {
                button8.BackColor = Color.SkyBlue;
            }
            if (!moreUnlocked && crystals >= 5000)
            {
                button9.BackColor = Color.LimeGreen;
            }
            else
            {
                button9.BackColor = Color.SkyBlue;
            }
            if (!vbsUnlocked && crystals >= 10000)
            {
                button10.BackColor = Color.LimeGreen;
            }
            else
            {
                button10.BackColor = Color.SkyBlue;
            }
            if (!wonderlandUnlocked && crystals >= 50000)
            {
                button11.BackColor = Color.LimeGreen;
            }
            else
            {
                button11.BackColor = Color.SkyBlue;
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
                    textBox1.Clear();
                    if(textBox2.Text.Contains("Hatsune Miku"))
                    {
                        AddText($"Hey, that's my name!");
                        crystals += 39; //teehee
                    }
                    AddText($"It's nice to meet you!");
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
            string outfitTutorial = "Click the button of the outfit you want to purchase, and your idol will automatically equip it. Use the Outfits tab in the menu bar to change your current outfit between the ones you have unlocked.";
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
            if (pictureBox1.Visible)
            {
                crystals += crystalsPerClick;
                updateCrystals();
            }
        }

        private void label5_Click(object sender, EventArgs e) //crystal label
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e) //crystals icon
        {
            crystals += 2000; //clicking icon gives you bonus crystals >:3
            updateCrystals();
            updateButtons();
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

        //error message
        void insufficientCrystals()
        {
            string notEnoughCrystals = "You don't have enough crystals for this!";
            string caption = "Insufficient Crystals";
            var result = MessageBox.Show(notEnoughCrystals, caption, MessageBoxButtons.OK);
        }
        void alreadyPurchased()
        {
            string alreadyPurchased = "You already purchased this!";
            string caption = "Already Purchased";
            var result = MessageBox.Show(alreadyPurchased, caption, MessageBoxButtons.OK);
        }
        void lockedOutfit()
        {
            string lockedOutfit = "You don't have this outfit unlocked yet!";
            string caption = "Oufit Locked";
            var result = MessageBox.Show(lockedOutfit, caption, MessageBoxButtons.OK);
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

        private void button7_Click(object sender, EventArgs e) //credits button
        {
            string creditsText = "All images are from \"Project SEKAI COLORFUL STAGE!\" and belong to SEGA and Colorful Palette.";
            string caption = "Credits";
            var result = MessageBox.Show(creditsText, caption, MessageBoxButtons.OK);
        }

        private void pictureBox3_Click(object sender, EventArgs e) //leo need miku
        {
            if (pictureBox3.Visible)
            {
                crystals += crystalsPerClick;
                updateCrystals();
            }
        }

        private void button8_Click(object sender, EventArgs e) //leo need button
        {
            if (crystals >= 2000)
            {
                if (!leoUnlocked)
                {
                    crystals = crystals - 2000;
                    updateCrystals();
                    leoUnlocked = true;
                    pictureBox1.Hide();
                    pictureBox4.Hide();
                    pictureBox5.Hide();
                    pictureBox6.Hide();
                    pictureBox3.Show();
                    button8.Text = "Rock Band Outfit\nAlready Purchased";
                    updateButtons();
                }
                else
                {
                    alreadyPurchased();
                }

            }
            else if (leoUnlocked)
            {
                alreadyPurchased();
            }
            else
            {
                insufficientCrystals();
            }
        }

        private void rockBandToolStripMenuItem_Click(object sender, EventArgs e) //default outfit
        {
            pictureBox4.Hide();
            pictureBox3.Hide();
            pictureBox5.Hide();
            pictureBox6.Hide();
            pictureBox1.Show();
        }

        private void rockBandToolStripMenuItem1_Click(object sender, EventArgs e) //rock outfit
        {
            if (leoUnlocked)
            {
                pictureBox1.Hide();
                pictureBox4.Hide();
                pictureBox5.Hide();
                pictureBox6.Hide();
                pictureBox3.Show();
            }
            else
            {
                lockedOutfit();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e) //more more miku
        {
            if (pictureBox4.Visible)
            {
                crystals += crystalsPerClick;
                updateCrystals();
            }
        }

        private void button9_Click(object sender, EventArgs e) //stage oufit button
        {
            if (crystals >= 5000)
            {
                if (!moreUnlocked)
                {
                    crystals = crystals - 5000;
                    updateCrystals();
                    moreUnlocked = true;
                    pictureBox1.Hide();
                    pictureBox3.Hide();
                    pictureBox5.Hide();
                    pictureBox6.Hide();
                    pictureBox4.Show();
                    button9.Text = "Stage Outfit\nAlready Purchased";
                    updateButtons();
                }
                else
                {
                    alreadyPurchased();
                }

            }
            else if (moreUnlocked)
            {
                alreadyPurchased();
            }
            else
            {
                insufficientCrystals();
            }
        }

        private void button10_Click(object sender, EventArgs e) //street button
        {
            if (crystals >= 10000)
            {
                if (!vbsUnlocked)
                {
                    crystals = crystals - 10000;
                    updateCrystals();
                    vbsUnlocked = true;
                    pictureBox1.Hide();
                    pictureBox3.Hide();
                    pictureBox4.Hide();
                    pictureBox6.Hide();
                    pictureBox5.Show();
                    button10.Text = "Street Outfit\nAlready Purchased";
                    updateButtons();
                }
                else
                {
                    alreadyPurchased();
                }

            }
            else if (vbsUnlocked)
            {
                alreadyPurchased();
            }
            else
            {
                insufficientCrystals();
            }
        }

        private void streetToolStripMenuItem_Click(object sender, EventArgs e) //vbs outfit
        {
            if (vbsUnlocked)
            {
                pictureBox1.Hide();
                pictureBox4.Hide();
                pictureBox3.Hide();
                pictureBox6.Hide();
                pictureBox5.Show();
            }
            else
            {
                lockedOutfit();
            }
        }

        private void stageToolStripMenuItem_Click(object sender, EventArgs e) //more outfit
        {
            if (moreUnlocked)
            {
                pictureBox1.Hide();
                pictureBox3.Hide();
                pictureBox5.Hide();
                pictureBox4.Show();
            }
            else
            {
                lockedOutfit();
            }
        }

        private void pictureBox5_Click_1(object sender, EventArgs e) //vbs miku
        {
            if (pictureBox5.Visible)
            {
                crystals += crystalsPerClick;
                updateCrystals();
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e) //wonderland miku
        {
            if (pictureBox6.Visible)
            {
                crystals += crystalsPerClick;
                updateCrystals();
            }
        }

        private void button11_Click(object sender, EventArgs e) //wonderland button
        {
            if (crystals >= 50000)
            {
                if (!wonderlandUnlocked)
                {
                    crystals = crystals - 50000;
                    updateCrystals();
                    wonderlandUnlocked = true;
                    pictureBox1.Hide();
                    pictureBox3.Hide();
                    pictureBox4.Hide();
                    pictureBox5.Hide();
                    pictureBox6.Show();
                    button11.Text = "Catgirl Outfit\nAlready Purchased";
                    updateButtons();
                }
                else
                {
                    alreadyPurchased();
                }

            }
            else if (wonderlandUnlocked)
            {
                alreadyPurchased();
            }
            else
            {
                insufficientCrystals();
            }
        }

        private void catGirlToolStripMenuItem_Click(object sender, EventArgs e) //catgirl outfit
        {
            if (wonderlandUnlocked)
            {
                pictureBox1.Hide();
                pictureBox4.Hide();
                pictureBox3.Hide();
                pictureBox5.Hide();
                pictureBox6.Show();
            }
            else
            {
                lockedOutfit();
            }
        }
    }
}
