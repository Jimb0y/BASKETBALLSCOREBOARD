using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasketBallScoreBoard
{
    public partial class Form1 : Form
    {
        int teamA = 0;
        int teamB = 0;
        int foulsA = 0;
        int foulsB = 0;
        int timeoutsA = 0;
        int timeoutsB = 0;
        int period = 1;
        int minutes = 12;
        int seconds = 00;
        int shotClock = 24;

        public Form1()
        {
            
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            TeamAScore.Text = "0";
            TeamBScore.Text = "0";

            lbFoulsScoreA.Text = "0";
            lbFoulsScoreB.Text = "0";

            lbTimeoutsScoreA.Text = "0";
            lbTimeoutsScoreB.Text = "0";

            lbPeriodScore.Text = "1";

            lbTimerTime.Text = "12:00";
        }
        //SCORETEAMA
        private void btnPlusTeamA_Click(object sender, EventArgs e)
        {
            teamA++;
            TeamAScore.Text = teamA.ToString();
        }

        private void btnMinusTeamA_Click(object sender, EventArgs e)
        {
            if (teamA > 0)
                teamA--;

            TeamAScore.Text = teamA.ToString();
        }
        //SCORETEAMB
        private void btnPlusTeamB_Click(object sender, EventArgs e)
        {
            teamB++;
            TeamBScore.Text = teamB.ToString();
        }

        private void btnMinusTeamB_Click(object sender, EventArgs e)
        {
            if (teamB > 0)
                teamB--;

            TeamBScore.Text = teamB.ToString();
        }
        //FOULSA
        private void btnPlusFoulsA_Click(object sender, EventArgs e)
        {
            if (foulsA < 5)
            {
                foulsA++;
                lbFoulsScoreA.Text = foulsA.ToString();
            }
        }

        private void btnMinusFoulsA_Click(object sender, EventArgs e)
        {
            if (foulsA > 0)
                foulsA--;

            lbFoulsScoreA.Text = foulsA.ToString();
        }
        //FOULSB
        private void btnPlusFoulsB_Click(object sender, EventArgs e)
        {
            if (foulsB < 5)
            {
                foulsB++;
                lbFoulsScoreB.Text = foulsB.ToString();
            }
        }

        private void btnMinusFoulsB_Click(object sender, EventArgs e)
        {
            if (foulsB > 0)
                foulsB--;

            lbFoulsScoreB.Text = foulsB.ToString();
        }
        //TIMEOUTA
        private void btnPlusTimeoutsA_Click(object sender, EventArgs e)
        {
            timeoutsA++;
            lbTimeoutsScoreA.Text = timeoutsA.ToString();
        }

        private void btnMinusTimeoutsA_Click(object sender, EventArgs e)
        {
            if (timeoutsA > 0) { 
                timeoutsA--;

            lbTimeoutsScoreA.Text = timeoutsA.ToString();
        }else
            {
                lbTimeoutsScoreA.Text = timeoutsA.ToString();
            }
        }
         
        //Period
        private void btnPlusPeriod_Click(object sender, EventArgs e)
        {
            if (period < 4)
                period++;

            lbPeriodScore.Text = period.ToString();
        }

        private void btnMinusPeriod_Click(object sender, EventArgs e)
        {
            if (period > 1)
                period--;

            lbPeriodScore.Text = period.ToString();
        }
        private void btnTimerStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
            ShotClockTimer.Start();
        }

        private void btnTimerPause_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            ShotClockTimer.Stop();
        }

        private void btnTimerReset_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            minutes = 12;
            seconds = 0;
            lbTimerTime.Text = "12:00";
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (seconds == 0)
            {
                if (minutes == 0)
                {
                    timer1.Stop();
                    return;
                }

                minutes--;
                seconds = 59;
            }
            else
            {
                seconds--;
            }

            lbTimerTime.Text = minutes.ToString("00") + ":" + seconds.ToString("00");
        }
        private void TeamAScore_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void tbTeamANAme_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbTeamBNAme_TextChanged(object sender, EventArgs e)
        {

        }
        //TimeoutB
        private void btnMinusTimeoutsB_Click_1(object sender, EventArgs e)
        {
            if (timeoutsB > 0)
           {
               timeoutsB--;

               lbTimeoutsScoreB.Text = timeoutsB.ToString();
           }else
           {
               lbTimeoutsScoreB.Text = timeoutsB.ToString();
           }
        }

        private void btnPlusTimeoutsB_Click_1(object sender, EventArgs e)
        {
            timeoutsB++;
            lbTimeoutsScoreB.Text = timeoutsB.ToString();
        }

        private void ShotClockTimer_Tick(object sender, EventArgs e)
        {
            if (shotClock > 0)
            {
                shotClock--;
                lbShotClockTimer.Text = shotClock.ToString();

            }
            else
            {
                ShotClockTimer.Start();
            }
        }
        private void btn14sec_Click_1(object sender, EventArgs e)
        {
            shotClock = 14;
            lbShotClockTimer.Text = "14";

            ShotClockTimer.Start();
        }

        private void btnShotClockReset_Click_1(object sender, EventArgs e)
        {
            shotClock = 24;
            lbShotClockTimer.Text = "24";

            ShotClockTimer.Start();
        }
    }
 }

