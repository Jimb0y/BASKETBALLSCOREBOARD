namespace BasketBallScoreBoard
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTeamBNAme = new System.Windows.Forms.TextBox();
            this.TeamAScore = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TeamBScore = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbTimerTime = new System.Windows.Forms.Label();
            this.tbTeamANAme = new System.Windows.Forms.TextBox();
            this.btnMinusTeamA = new System.Windows.Forms.Button();
            this.btnPlusTeamA = new System.Windows.Forms.Button();
            this.btnPlusTeamB = new System.Windows.Forms.Button();
            this.btnMinusTeamB = new System.Windows.Forms.Button();
            this.btnTimerStart = new System.Windows.Forms.Button();
            this.btnTimerPause = new System.Windows.Forms.Button();
            this.btnTimerReset = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbTimeoutsScoreA = new System.Windows.Forms.Label();
            this.lbTimeoutsScoreB = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbFoulsScoreB = new System.Windows.Forms.Label();
            this.lbFoulsScoreA = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lbPeriodScore = new System.Windows.Forms.Label();
            this.btnMinusFoulsB = new System.Windows.Forms.Button();
            this.btnPlusFoulsB = new System.Windows.Forms.Button();
            this.btnMinusFoulsA = new System.Windows.Forms.Button();
            this.btnPlusFoulsA = new System.Windows.Forms.Button();
            this.btnPlusTimeoutsB = new System.Windows.Forms.Button();
            this.btnMinusTimeoutsB = new System.Windows.Forms.Button();
            this.btnMinusTimeoutsA = new System.Windows.Forms.Button();
            this.btnPlusTimeoutsA = new System.Windows.Forms.Button();
            this.btnMinusPeriod = new System.Windows.Forms.Button();
            this.btnPlusPeriod = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbShotClockTimer = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ShotClockTimer = new System.Windows.Forms.Timer(this.components);
            this.btn14sec = new System.Windows.Forms.Button();
            this.btnShotClockReset = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(495, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(478, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "BASKETBALL SCOREBOARD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(387, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "TEAM A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1050, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "TEAM B";
            // 
            // tbTeamBNAme
            // 
            this.tbTeamBNAme.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTeamBNAme.Location = new System.Drawing.Point(974, 152);
            this.tbTeamBNAme.Name = "tbTeamBNAme";
            this.tbTeamBNAme.Size = new System.Drawing.Size(257, 44);
            this.tbTeamBNAme.TabIndex = 2;
            this.tbTeamBNAme.TextChanged += new System.EventHandler(this.tbTeamBNAme_TextChanged);
            // 
            // TeamAScore
            // 
            this.TeamAScore.AutoSize = true;
            this.TeamAScore.BackColor = System.Drawing.Color.White;
            this.TeamAScore.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamAScore.ForeColor = System.Drawing.Color.Black;
            this.TeamAScore.Location = new System.Drawing.Point(37, 12);
            this.TeamAScore.Name = "TeamAScore";
            this.TeamAScore.Size = new System.Drawing.Size(136, 80);
            this.TeamAScore.TabIndex = 1;
            this.TeamAScore.Text = "888";
            this.TeamAScore.Click += new System.EventHandler(this.TeamAScore_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.TeamAScore);
            this.panel1.Controls.Add(this.btnPlusTeamA);
            this.panel1.Controls.Add(this.btnMinusTeamA);
            this.panel1.ForeColor = System.Drawing.Color.Yellow;
            this.panel1.Location = new System.Drawing.Point(307, 232);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 149);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Controls.Add(this.TeamBScore);
            this.panel2.Controls.Add(this.btnPlusTeamB);
            this.panel2.Controls.Add(this.btnMinusTeamB);
            this.panel2.ForeColor = System.Drawing.Color.Yellow;
            this.panel2.Location = new System.Drawing.Point(935, 231);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(246, 149);
            this.panel2.TabIndex = 3;
            // 
            // TeamBScore
            // 
            this.TeamBScore.AutoSize = true;
            this.TeamBScore.BackColor = System.Drawing.Color.White;
            this.TeamBScore.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamBScore.ForeColor = System.Drawing.Color.Black;
            this.TeamBScore.Location = new System.Drawing.Point(49, 12);
            this.TeamBScore.Name = "TeamBScore";
            this.TeamBScore.Size = new System.Drawing.Size(136, 80);
            this.TeamBScore.TabIndex = 1;
            this.TeamBScore.Text = "888";
            this.TeamBScore.Click += new System.EventHandler(this.TeamAScore_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(52, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "TIMER";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SlateGray;
            this.panel3.Controls.Add(this.lbTimerTime);
            this.panel3.Controls.Add(this.lbPeriodScore);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label5);
            this.panel3.ForeColor = System.Drawing.Color.Yellow;
            this.panel3.Location = new System.Drawing.Point(604, 116);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(266, 112);
            this.panel3.TabIndex = 3;
            // 
            // lbTimerTime
            // 
            this.lbTimerTime.AutoSize = true;
            this.lbTimerTime.BackColor = System.Drawing.Color.White;
            this.lbTimerTime.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimerTime.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbTimerTime.Location = new System.Drawing.Point(23, 23);
            this.lbTimerTime.Name = "lbTimerTime";
            this.lbTimerTime.Size = new System.Drawing.Size(120, 60);
            this.lbTimerTime.TabIndex = 1;
            this.lbTimerTime.Text = "12:51";
            this.lbTimerTime.Click += new System.EventHandler(this.TeamAScore_Click);
            // 
            // tbTeamANAme
            // 
            this.tbTeamANAme.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTeamANAme.Location = new System.Drawing.Point(288, 143);
            this.tbTeamANAme.Name = "tbTeamANAme";
            this.tbTeamANAme.Size = new System.Drawing.Size(262, 44);
            this.tbTeamANAme.TabIndex = 2;
            this.tbTeamANAme.TextChanged += new System.EventHandler(this.tbTeamANAme_TextChanged);
            // 
            // btnMinusTeamA
            // 
            this.btnMinusTeamA.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinusTeamA.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMinusTeamA.Location = new System.Drawing.Point(0, 95);
            this.btnMinusTeamA.Name = "btnMinusTeamA";
            this.btnMinusTeamA.Size = new System.Drawing.Size(60, 54);
            this.btnMinusTeamA.TabIndex = 4;
            this.btnMinusTeamA.Text = "–";
            this.btnMinusTeamA.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMinusTeamA.UseVisualStyleBackColor = true;
            this.btnMinusTeamA.Click += new System.EventHandler(this.btnMinusTeamA_Click);
            // 
            // btnPlusTeamA
            // 
            this.btnPlusTeamA.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlusTeamA.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPlusTeamA.Location = new System.Drawing.Point(146, 95);
            this.btnPlusTeamA.Name = "btnPlusTeamA";
            this.btnPlusTeamA.Size = new System.Drawing.Size(60, 54);
            this.btnPlusTeamA.TabIndex = 4;
            this.btnPlusTeamA.Text = "+";
            this.btnPlusTeamA.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPlusTeamA.UseVisualStyleBackColor = true;
            this.btnPlusTeamA.Click += new System.EventHandler(this.btnPlusTeamA_Click);
            // 
            // btnPlusTeamB
            // 
            this.btnPlusTeamB.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlusTeamB.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPlusTeamB.Location = new System.Drawing.Point(186, 95);
            this.btnPlusTeamB.Name = "btnPlusTeamB";
            this.btnPlusTeamB.Size = new System.Drawing.Size(60, 54);
            this.btnPlusTeamB.TabIndex = 4;
            this.btnPlusTeamB.Text = "+";
            this.btnPlusTeamB.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPlusTeamB.UseVisualStyleBackColor = true;
            this.btnPlusTeamB.Click += new System.EventHandler(this.btnPlusTeamB_Click);
            // 
            // btnMinusTeamB
            // 
            this.btnMinusTeamB.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinusTeamB.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMinusTeamB.Location = new System.Drawing.Point(0, 95);
            this.btnMinusTeamB.Name = "btnMinusTeamB";
            this.btnMinusTeamB.Size = new System.Drawing.Size(60, 54);
            this.btnMinusTeamB.TabIndex = 4;
            this.btnMinusTeamB.Text = "–";
            this.btnMinusTeamB.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMinusTeamB.UseVisualStyleBackColor = true;
            this.btnMinusTeamB.Click += new System.EventHandler(this.btnMinusTeamB_Click);
            // 
            // btnTimerStart
            // 
            this.btnTimerStart.Location = new System.Drawing.Point(540, 62);
            this.btnTimerStart.Name = "btnTimerStart";
            this.btnTimerStart.Size = new System.Drawing.Size(124, 49);
            this.btnTimerStart.TabIndex = 5;
            this.btnTimerStart.Text = "START";
            this.btnTimerStart.UseVisualStyleBackColor = true;
            this.btnTimerStart.Click += new System.EventHandler(this.btnTimerStart_Click);
            // 
            // btnTimerPause
            // 
            this.btnTimerPause.Location = new System.Drawing.Point(670, 62);
            this.btnTimerPause.Name = "btnTimerPause";
            this.btnTimerPause.Size = new System.Drawing.Size(124, 49);
            this.btnTimerPause.TabIndex = 5;
            this.btnTimerPause.Text = "PAUSE";
            this.btnTimerPause.UseVisualStyleBackColor = true;
            this.btnTimerPause.Click += new System.EventHandler(this.btnTimerPause_Click);
            // 
            // btnTimerReset
            // 
            this.btnTimerReset.Location = new System.Drawing.Point(803, 61);
            this.btnTimerReset.Name = "btnTimerReset";
            this.btnTimerReset.Size = new System.Drawing.Size(124, 49);
            this.btnTimerReset.TabIndex = 5;
            this.btnTimerReset.Text = "RESET";
            this.btnTimerReset.UseVisualStyleBackColor = true;
            this.btnTimerReset.Click += new System.EventHandler(this.btnTimerReset_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(322, 593);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 26);
            this.label6.TabIndex = 6;
            this.label6.Text = "Timeouts";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1066, 593);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 26);
            this.label7.TabIndex = 6;
            this.label7.Text = "Timeouts";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // lbTimeoutsScoreA
            // 
            this.lbTimeoutsScoreA.BackColor = System.Drawing.Color.White;
            this.lbTimeoutsScoreA.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimeoutsScoreA.ForeColor = System.Drawing.Color.Red;
            this.lbTimeoutsScoreA.Location = new System.Drawing.Point(424, 575);
            this.lbTimeoutsScoreA.Name = "lbTimeoutsScoreA";
            this.lbTimeoutsScoreA.Size = new System.Drawing.Size(45, 64);
            this.lbTimeoutsScoreA.TabIndex = 1;
            this.lbTimeoutsScoreA.Text = "0";
            this.lbTimeoutsScoreA.Click += new System.EventHandler(this.TeamAScore_Click);
            // 
            // lbTimeoutsScoreB
            // 
            this.lbTimeoutsScoreB.BackColor = System.Drawing.Color.White;
            this.lbTimeoutsScoreB.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimeoutsScoreB.ForeColor = System.Drawing.Color.Red;
            this.lbTimeoutsScoreB.Location = new System.Drawing.Point(988, 575);
            this.lbTimeoutsScoreB.Name = "lbTimeoutsScoreB";
            this.lbTimeoutsScoreB.Size = new System.Drawing.Size(51, 66);
            this.lbTimeoutsScoreB.TabIndex = 1;
            this.lbTimeoutsScoreB.Text = "0";
            this.lbTimeoutsScoreB.Click += new System.EventHandler(this.TeamAScore_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1066, 450);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 26);
            this.label10.TabIndex = 6;
            this.label10.Text = "Fouls";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(353, 442);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 26);
            this.label11.TabIndex = 6;
            this.label11.Text = "Fouls";
            // 
            // lbFoulsScoreB
            // 
            this.lbFoulsScoreB.BackColor = System.Drawing.Color.White;
            this.lbFoulsScoreB.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFoulsScoreB.ForeColor = System.Drawing.Color.Red;
            this.lbFoulsScoreB.Location = new System.Drawing.Point(988, 429);
            this.lbFoulsScoreB.Name = "lbFoulsScoreB";
            this.lbFoulsScoreB.Size = new System.Drawing.Size(51, 66);
            this.lbFoulsScoreB.TabIndex = 1;
            this.lbFoulsScoreB.Text = "0";
            this.lbFoulsScoreB.Click += new System.EventHandler(this.TeamAScore_Click);
            // 
            // lbFoulsScoreA
            // 
            this.lbFoulsScoreA.BackColor = System.Drawing.Color.White;
            this.lbFoulsScoreA.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFoulsScoreA.ForeColor = System.Drawing.Color.Red;
            this.lbFoulsScoreA.Location = new System.Drawing.Point(424, 421);
            this.lbFoulsScoreA.Name = "lbFoulsScoreA";
            this.lbFoulsScoreA.Size = new System.Drawing.Size(48, 62);
            this.lbFoulsScoreA.TabIndex = 1;
            this.lbFoulsScoreA.Text = "0";
            this.lbFoulsScoreA.Click += new System.EventHandler(this.TeamAScore_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(175, 86);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 26);
            this.label14.TabIndex = 6;
            this.label14.Text = "Period";
            // 
            // lbPeriodScore
            // 
            this.lbPeriodScore.AutoSize = true;
            this.lbPeriodScore.BackColor = System.Drawing.Color.White;
            this.lbPeriodScore.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPeriodScore.ForeColor = System.Drawing.Color.Red;
            this.lbPeriodScore.Location = new System.Drawing.Point(189, 23);
            this.lbPeriodScore.Name = "lbPeriodScore";
            this.lbPeriodScore.Size = new System.Drawing.Size(43, 60);
            this.lbPeriodScore.TabIndex = 1;
            this.lbPeriodScore.Text = "1";
            this.lbPeriodScore.Click += new System.EventHandler(this.TeamAScore_Click);
            // 
            // btnMinusFoulsB
            // 
            this.btnMinusFoulsB.AutoSize = true;
            this.btnMinusFoulsB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinusFoulsB.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMinusFoulsB.Location = new System.Drawing.Point(1022, 498);
            this.btnMinusFoulsB.Name = "btnMinusFoulsB";
            this.btnMinusFoulsB.Size = new System.Drawing.Size(41, 42);
            this.btnMinusFoulsB.TabIndex = 4;
            this.btnMinusFoulsB.Text = "–";
            this.btnMinusFoulsB.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMinusFoulsB.UseVisualStyleBackColor = true;
            this.btnMinusFoulsB.Click += new System.EventHandler(this.btnMinusFoulsB_Click);
            // 
            // btnPlusFoulsB
            // 
            this.btnPlusFoulsB.AutoSize = true;
            this.btnPlusFoulsB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlusFoulsB.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPlusFoulsB.Location = new System.Drawing.Point(974, 498);
            this.btnPlusFoulsB.Name = "btnPlusFoulsB";
            this.btnPlusFoulsB.Size = new System.Drawing.Size(42, 42);
            this.btnPlusFoulsB.TabIndex = 4;
            this.btnPlusFoulsB.Text = "+";
            this.btnPlusFoulsB.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPlusFoulsB.UseVisualStyleBackColor = true;
            this.btnPlusFoulsB.Click += new System.EventHandler(this.btnPlusFoulsB_Click);
            // 
            // btnMinusFoulsA
            // 
            this.btnMinusFoulsA.AutoSize = true;
            this.btnMinusFoulsA.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinusFoulsA.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMinusFoulsA.Location = new System.Drawing.Point(402, 486);
            this.btnMinusFoulsA.Name = "btnMinusFoulsA";
            this.btnMinusFoulsA.Size = new System.Drawing.Size(41, 42);
            this.btnMinusFoulsA.TabIndex = 4;
            this.btnMinusFoulsA.Text = "–";
            this.btnMinusFoulsA.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMinusFoulsA.UseVisualStyleBackColor = true;
            this.btnMinusFoulsA.Click += new System.EventHandler(this.btnMinusFoulsA_Click);
            // 
            // btnPlusFoulsA
            // 
            this.btnPlusFoulsA.AutoSize = true;
            this.btnPlusFoulsA.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlusFoulsA.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPlusFoulsA.Location = new System.Drawing.Point(449, 486);
            this.btnPlusFoulsA.Name = "btnPlusFoulsA";
            this.btnPlusFoulsA.Size = new System.Drawing.Size(42, 42);
            this.btnPlusFoulsA.TabIndex = 4;
            this.btnPlusFoulsA.Text = "+";
            this.btnPlusFoulsA.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPlusFoulsA.UseVisualStyleBackColor = true;
            this.btnPlusFoulsA.Click += new System.EventHandler(this.btnPlusFoulsA_Click);
            // 
            // btnPlusTimeoutsB
            // 
            this.btnPlusTimeoutsB.AutoSize = true;
            this.btnPlusTimeoutsB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlusTimeoutsB.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPlusTimeoutsB.Location = new System.Drawing.Point(968, 642);
            this.btnPlusTimeoutsB.Name = "btnPlusTimeoutsB";
            this.btnPlusTimeoutsB.Size = new System.Drawing.Size(42, 42);
            this.btnPlusTimeoutsB.TabIndex = 4;
            this.btnPlusTimeoutsB.Text = "+";
            this.btnPlusTimeoutsB.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPlusTimeoutsB.UseVisualStyleBackColor = true;
            this.btnPlusTimeoutsB.Click += new System.EventHandler(this.btnPlusTimeoutsB_Click_1);
            // 
            // btnMinusTimeoutsB
            // 
            this.btnMinusTimeoutsB.AutoSize = true;
            this.btnMinusTimeoutsB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinusTimeoutsB.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMinusTimeoutsB.Location = new System.Drawing.Point(1016, 642);
            this.btnMinusTimeoutsB.Name = "btnMinusTimeoutsB";
            this.btnMinusTimeoutsB.Size = new System.Drawing.Size(41, 42);
            this.btnMinusTimeoutsB.TabIndex = 4;
            this.btnMinusTimeoutsB.Text = "–";
            this.btnMinusTimeoutsB.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMinusTimeoutsB.UseVisualStyleBackColor = true;
            this.btnMinusTimeoutsB.Click += new System.EventHandler(this.btnMinusTimeoutsB_Click_1);
            // 
            // btnMinusTimeoutsA
            // 
            this.btnMinusTimeoutsA.AutoSize = true;
            this.btnMinusTimeoutsA.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinusTimeoutsA.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMinusTimeoutsA.Location = new System.Drawing.Point(402, 643);
            this.btnMinusTimeoutsA.Name = "btnMinusTimeoutsA";
            this.btnMinusTimeoutsA.Size = new System.Drawing.Size(41, 42);
            this.btnMinusTimeoutsA.TabIndex = 4;
            this.btnMinusTimeoutsA.Text = "–";
            this.btnMinusTimeoutsA.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMinusTimeoutsA.UseVisualStyleBackColor = true;
            this.btnMinusTimeoutsA.Click += new System.EventHandler(this.btnMinusTimeoutsA_Click);
            // 
            // btnPlusTimeoutsA
            // 
            this.btnPlusTimeoutsA.AutoSize = true;
            this.btnPlusTimeoutsA.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlusTimeoutsA.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPlusTimeoutsA.Location = new System.Drawing.Point(446, 642);
            this.btnPlusTimeoutsA.Name = "btnPlusTimeoutsA";
            this.btnPlusTimeoutsA.Size = new System.Drawing.Size(42, 42);
            this.btnPlusTimeoutsA.TabIndex = 4;
            this.btnPlusTimeoutsA.Text = "+";
            this.btnPlusTimeoutsA.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPlusTimeoutsA.UseVisualStyleBackColor = true;
            this.btnPlusTimeoutsA.Click += new System.EventHandler(this.btnPlusTimeoutsA_Click);
            // 
            // btnMinusPeriod
            // 
            this.btnMinusPeriod.AutoSize = true;
            this.btnMinusPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinusPeriod.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMinusPeriod.Location = new System.Drawing.Point(884, 125);
            this.btnMinusPeriod.Name = "btnMinusPeriod";
            this.btnMinusPeriod.Size = new System.Drawing.Size(36, 42);
            this.btnMinusPeriod.TabIndex = 4;
            this.btnMinusPeriod.Text = "–";
            this.btnMinusPeriod.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMinusPeriod.UseVisualStyleBackColor = true;
            this.btnMinusPeriod.Click += new System.EventHandler(this.btnMinusPeriod_Click);
            // 
            // btnPlusPeriod
            // 
            this.btnPlusPeriod.AutoSize = true;
            this.btnPlusPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlusPeriod.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPlusPeriod.Location = new System.Drawing.Point(884, 183);
            this.btnPlusPeriod.Name = "btnPlusPeriod";
            this.btnPlusPeriod.Size = new System.Drawing.Size(36, 36);
            this.btnPlusPeriod.TabIndex = 4;
            this.btnPlusPeriod.Text = "+";
            this.btnPlusPeriod.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPlusPeriod.UseVisualStyleBackColor = true;
            this.btnPlusPeriod.Click += new System.EventHandler(this.btnPlusPeriod_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BasketBallScoreBoard.Properties.Resources.image_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(559, 252);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(354, 435);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbShotClockTimer
            // 
            this.lbShotClockTimer.AutoSize = true;
            this.lbShotClockTimer.BackColor = System.Drawing.Color.White;
            this.lbShotClockTimer.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShotClockTimer.ForeColor = System.Drawing.Color.Red;
            this.lbShotClockTimer.Location = new System.Drawing.Point(700, 708);
            this.lbShotClockTimer.Name = "lbShotClockTimer";
            this.lbShotClockTimer.Size = new System.Drawing.Size(72, 60);
            this.lbShotClockTimer.TabIndex = 1;
            this.lbShotClockTimer.Text = "24";
            this.lbShotClockTimer.Click += new System.EventHandler(this.TeamAScore_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(778, 726);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 26);
            this.label8.TabIndex = 6;
            this.label8.Text = "ShotClock";
            this.label8.Click += new System.EventHandler(this.label7_Click);
            // 
            // ShotClockTimer
            // 
            this.ShotClockTimer.Interval = 1000;
            this.ShotClockTimer.Tick += new System.EventHandler(this.ShotClockTimer_Tick);
            // 
            // btn14sec
            // 
            this.btn14sec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn14sec.Location = new System.Drawing.Point(618, 708);
            this.btn14sec.Name = "btn14sec";
            this.btn14sec.Size = new System.Drawing.Size(75, 23);
            this.btn14sec.TabIndex = 8;
            this.btn14sec.Text = "14sec";
            this.btn14sec.UseVisualStyleBackColor = true;
            this.btn14sec.Click += new System.EventHandler(this.btn14sec_Click_1);
            // 
            // btnShotClockReset
            // 
            this.btnShotClockReset.BackColor = System.Drawing.Color.Transparent;
            this.btnShotClockReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShotClockReset.Location = new System.Drawing.Point(618, 737);
            this.btnShotClockReset.Name = "btnShotClockReset";
            this.btnShotClockReset.Size = new System.Drawing.Size(75, 29);
            this.btnShotClockReset.TabIndex = 9;
            this.btnShotClockReset.Text = "Reset";
            this.btnShotClockReset.UseVisualStyleBackColor = false;
            this.btnShotClockReset.Click += new System.EventHandler(this.btnShotClockReset_Click_1);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1265, 842);
            this.Controls.Add(this.btnShotClockReset);
            this.Controls.Add(this.btn14sec);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbFoulsScoreA);
            this.Controls.Add(this.lbFoulsScoreB);
            this.Controls.Add(this.lbShotClockTimer);
            this.Controls.Add(this.lbTimeoutsScoreB);
            this.Controls.Add(this.lbTimeoutsScoreA);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnTimerReset);
            this.Controls.Add(this.btnTimerPause);
            this.Controls.Add(this.btnTimerStart);
            this.Controls.Add(this.btnPlusFoulsA);
            this.Controls.Add(this.btnPlusPeriod);
            this.Controls.Add(this.btnPlusTimeoutsA);
            this.Controls.Add(this.btnPlusTimeoutsB);
            this.Controls.Add(this.btnMinusPeriod);
            this.Controls.Add(this.btnPlusFoulsB);
            this.Controls.Add(this.btnMinusTimeoutsA);
            this.Controls.Add(this.btnMinusFoulsA);
            this.Controls.Add(this.btnMinusTimeoutsB);
            this.Controls.Add(this.btnMinusFoulsB);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.tbTeamANAme);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbTeamBNAme);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTeamBNAme;
        private System.Windows.Forms.Label TeamAScore;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label TeamBScore;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbTimerTime;
        private System.Windows.Forms.TextBox tbTeamANAme;
        private System.Windows.Forms.Button btnMinusTeamA;
        private System.Windows.Forms.Button btnPlusTeamA;
        private System.Windows.Forms.Button btnPlusTeamB;
        private System.Windows.Forms.Button btnMinusTeamB;
        private System.Windows.Forms.Button btnTimerStart;
        private System.Windows.Forms.Button btnTimerPause;
        private System.Windows.Forms.Button btnTimerReset;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbTimeoutsScoreA;
        private System.Windows.Forms.Label lbTimeoutsScoreB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbFoulsScoreB;
        private System.Windows.Forms.Label lbFoulsScoreA;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbPeriodScore;
        private System.Windows.Forms.Button btnMinusFoulsB;
        private System.Windows.Forms.Button btnPlusFoulsB;
        private System.Windows.Forms.Button btnMinusFoulsA;
        private System.Windows.Forms.Button btnPlusFoulsA;
        private System.Windows.Forms.Button btnPlusTimeoutsB;
        private System.Windows.Forms.Button btnMinusTimeoutsB;
        private System.Windows.Forms.Button btnMinusTimeoutsA;
        private System.Windows.Forms.Button btnPlusTimeoutsA;
        private System.Windows.Forms.Button btnMinusPeriod;
        private System.Windows.Forms.Button btnPlusPeriod;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbShotClockTimer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer ShotClockTimer;
        private System.Windows.Forms.Button btnShotClockReset;
        private System.Windows.Forms.Button btn14sec;
    }
}

