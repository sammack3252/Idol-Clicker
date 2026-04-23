namespace Idol_Clicker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            menuStrip1 = new MenuStrip();
            helpToolStripMenuItem = new ToolStripMenuItem();
            earningGemsToolStripMenuItem = new ToolStripMenuItem();
            unlockingOutfitsToolStripMenuItem = new ToolStripMenuItem();
            outfitsToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            textBox1 = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            label7 = new Label();
            label6 = new Label();
            button3 = new Button();
            button4 = new Button();
            label8 = new Label();
            label9 = new Label();
            button5 = new Button();
            button6 = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Juice ITC", 60F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(296, 43);
            label1.Name = "label1";
            label1.Size = new Size(360, 113);
            label1.TabIndex = 0;
            label1.Text = "Idol Clicker";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.ForeColor = Color.MediumAquamarine;
            label2.Location = new Point(296, 9);
            label2.Name = "label2";
            label2.Size = new Size(72, 46);
            label2.TabIndex = 1;
            label2.Text = "\\ | /";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F);
            label3.ForeColor = Color.MediumAquamarine;
            label3.Location = new Point(584, 138);
            label3.Name = "label3";
            label3.Size = new Size(72, 46);
            label3.TabIndex = 2;
            label3.Text = "/ | \\";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 192);
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Juice ITC", 30F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.MenuHighlight;
            button1.Location = new Point(291, 215);
            button1.Name = "button1";
            button1.Size = new Size(372, 115);
            button1.TabIndex = 3;
            button1.Text = "Play!";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonHighlight;
            button2.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 192);
            button2.FlatAppearance.BorderSize = 2;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Juice ITC", 20F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.MenuHighlight;
            button2.Location = new Point(291, 359);
            button2.Name = "button2";
            button2.Size = new Size(372, 49);
            button2.TabIndex = 4;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.MenuHighlight;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { helpToolStripMenuItem, outfitsToolStripMenuItem, exitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(4, 2, 0, 2);
            menuStrip1.Size = new Size(939, 37);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.Visible = false;
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.BackColor = SystemColors.MenuHighlight;
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { earningGemsToolStripMenuItem, unlockingOutfitsToolStripMenuItem });
            helpToolStripMenuItem.Font = new Font("Juice ITC", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(61, 33);
            helpToolStripMenuItem.Text = "Help";
            // 
            // earningGemsToolStripMenuItem
            // 
            earningGemsToolStripMenuItem.BackColor = SystemColors.MenuHighlight;
            earningGemsToolStripMenuItem.Name = "earningGemsToolStripMenuItem";
            earningGemsToolStripMenuItem.Size = new Size(244, 34);
            earningGemsToolStripMenuItem.Text = "Earning Crystals";
            earningGemsToolStripMenuItem.Click += earningGemsToolStripMenuItem_Click;
            // 
            // unlockingOutfitsToolStripMenuItem
            // 
            unlockingOutfitsToolStripMenuItem.BackColor = SystemColors.MenuHighlight;
            unlockingOutfitsToolStripMenuItem.Name = "unlockingOutfitsToolStripMenuItem";
            unlockingOutfitsToolStripMenuItem.Size = new Size(244, 34);
            unlockingOutfitsToolStripMenuItem.Text = "Unlocking Outfits";
            unlockingOutfitsToolStripMenuItem.Click += unlockingOutfitsToolStripMenuItem_Click;
            // 
            // outfitsToolStripMenuItem
            // 
            outfitsToolStripMenuItem.BackColor = SystemColors.MenuHighlight;
            outfitsToolStripMenuItem.Font = new Font("Juice ITC", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            outfitsToolStripMenuItem.Name = "outfitsToolStripMenuItem";
            outfitsToolStripMenuItem.Size = new Size(87, 33);
            outfitsToolStripMenuItem.Text = "Outfits";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.BackColor = SystemColors.MenuHighlight;
            exitToolStripMenuItem.Font = new Font("Juice ITC", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(60, 33);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ButtonHighlight;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Juice ITC", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = SystemColors.InfoText;
            textBox1.Location = new Point(520, 290);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(419, 210);
            textBox1.TabIndex = 6;
            textBox1.Visible = false;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonHighlight;
            label4.Font = new Font("Juice ITC", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.MenuHighlight;
            label4.Location = new Point(520, 505);
            label4.MinimumSize = new Size(130, 0);
            label4.Name = "label4";
            label4.Size = new Size(148, 29);
            label4.TabIndex = 7;
            label4.Text = "Say something!: ";
            label4.Visible = false;
            label4.Click += label4_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.InactiveCaption;
            textBox2.Font = new Font("Juice ITC", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(674, 506);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(265, 28);
            textBox2.TabIndex = 8;
            textBox2.Visible = false;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.Image = Properties.Resources.miku1;
            pictureBox1.Location = new Point(520, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(488, 336);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.crystal;
            pictureBox2.Location = new Point(520, 501);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(33, 37);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ButtonHighlight;
            label5.Font = new Font("Juice ITC", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(555, 506);
            label5.Name = "label5";
            label5.Size = new Size(85, 29);
            label5.TabIndex = 11;
            label5.Text = "Crystals:";
            label5.Visible = false;
            label5.Click += label5_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Juice ITC", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.InfoText;
            label7.Location = new Point(883, 509);
            label7.Name = "label7";
            label7.Size = new Size(23, 29);
            label7.TabIndex = 13;
            label7.Text = "0";
            label7.Visible = false;
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ButtonHighlight;
            label6.Font = new Font("Juice ITC", 32F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.InactiveCaptionText;
            label6.Location = new Point(4, 40);
            label6.Name = "label6";
            label6.Size = new Size(175, 61);
            label6.TabIndex = 14;
            label6.Text = "Upgrades";
            label6.Visible = false;
            label6.Click += label6_Click;
            // 
            // button3
            // 
            button3.AllowDrop = true;
            button3.BackColor = Color.SkyBlue;
            button3.Font = new Font("Kristen ITC", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(2, 103);
            button3.Name = "button3";
            button3.Size = new Size(263, 68);
            button3.TabIndex = 15;
            button3.Text = "Perform a Show\r\nCost: 10\r\n(+1 Crystal per Click)";
            button3.UseVisualStyleBackColor = false;
            button3.Visible = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.AllowDrop = true;
            button4.BackColor = Color.SkyBlue;
            button4.Font = new Font("Kristen ITC", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.Black;
            button4.Location = new Point(257, 103);
            button4.Name = "button4";
            button4.Size = new Size(263, 68);
            button4.TabIndex = 16;
            button4.Text = "Write a Song\r\nCost: 50\r\n(+10 Crystals per Click)";
            button4.UseVisualStyleBackColor = false;
            button4.Visible = false;
            button4.Click += button4_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Juice ITC", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(185, 40);
            label8.Name = "label8";
            label8.Size = new Size(138, 62);
            label8.TabIndex = 17;
            label8.Text = "Current clicks\r\nper second: ";
            label8.Visible = false;
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Juice ITC", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.InactiveCaptionText;
            label9.Location = new Point(320, 55);
            label9.Name = "label9";
            label9.Size = new Size(197, 39);
            label9.TabIndex = 18;
            label9.Text = "clicks per second";
            label9.Visible = false;
            label9.Click += label9_Click;
            // 
            // button5
            // 
            button5.AllowDrop = true;
            button5.BackColor = Color.SkyBlue;
            button5.Font = new Font("Kristen ITC", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.Black;
            button5.Location = new Point(2, 172);
            button5.Name = "button5";
            button5.Size = new Size(263, 68);
            button5.TabIndex = 19;
            button5.Text = "Create Choreography\r\nCost: 500\r\n(+100 Crystal per Click)";
            button5.UseVisualStyleBackColor = false;
            button5.Visible = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.AllowDrop = true;
            button6.BackColor = Color.SkyBlue;
            button6.Font = new Font("Kristen ITC", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.Black;
            button6.Location = new Point(257, 172);
            button6.Name = "button6";
            button6.Size = new Size(263, 68);
            button6.TabIndex = 20;
            button6.Text = "Film a Music Video\r\nCost: 2500\r\n(+1000 Crystal per Click)";
            button6.UseVisualStyleBackColor = false;
            button6.Visible = false;
            button6.Click += button6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(939, 538);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            ForeColor = SystemColors.MenuHighlight;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem earningGemsToolStripMenuItem;
        private ToolStripMenuItem unlockingOutfitsToolStripMenuItem;
        private ToolStripMenuItem outfitsToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private TextBox textBox1;
        private Label label4;
        private TextBox textBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label5;
        private Label label7;
        private Label label6;
        private Button button3;
        private Button button4;
        private Label label8;
        private Label label9;
        private Button button5;
        private Button button6;
    }
}
