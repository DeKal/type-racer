using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TypeRacer
{

    public partial class Game : Form
    {
        private string CurrentContent;
        //private double PercentPerChar;
        private const string ACCURACY = "Accuracy : ";
        private const string CORRECTED = "Corrected : ";
        private const string MISSED = "Missed : ";
        private const string TOTAL = "Total : ";
        private PlayerStatus playerStatus;
        private bool GameStart;
        public Game()
        {
            InitializeComponent();
        }
        public PlayerStatus GetPlayerStatus(){
            return playerStatus;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadGame();
        }

        private void SetStatusBar(double accuracy, int corrected, int missed, int total)
        {
            accuracy = Math.Round(accuracy, 3); 
            toolStripStatusAccuracy.Text = ACCURACY + accuracy + "%";
            toolStripStatusCorrected.Text = CORRECTED + corrected;
            toolStripStatusMissed.Text = MISSED + missed;
            toolStripStatusTotalTimesType.Text = TOTAL + total;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            GameStart = true;
            timer1.Enabled = true;
            btnStart.Visible = false;
            lbFirstCharacter.Visible = true;
            ShowCurrentText();
            this.Focus();
         }

        private void ShowCurrentText()
        {
            if (CurrentContent != "")
            {
                lbFirstCharacter.Text = CurrentContent[0].ToString();
                CurrentContent = CurrentContent.Remove(0, 1);
                lbGameText.Text = CurrentContent;
            }
            else
            {
                timer1.Stop();
                EndGame();
            }
        }

        private void EndGame()
        {
            Sumary SumaryForm=new Sumary();
            bool result=true;
            
            SumaryForm.ShowDialog(this);
            result = SumaryForm.GetExitID();
            
            if (result!=true) 
                Application.Exit();
            else LoadGame();
        }

        private void LoadGame()
        {
            timer1.Stop();
            GameStart = false;
            lbGameText.Text = "      Type Racer";
            lbFirstCharacter.Visible = false;
            btnStart.Visible = true;

            CurrentContent = GetContent();
            
            progressBar1.Maximum = CurrentContent.Length;
            progressBar1.Value = 0;
            playerStatus = new PlayerStatus(0, 0);
            SetStatusBar(100, 0, 0, 0);
            
        }

        private string GetContent()
        {
            return Properties.Resources.EasyGame;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (GameStart == true)
            {
                if (lbFirstCharacter.Text == e.KeyChar.ToString())
                {
                    lbFirstCharacter.BackColor = SystemColors.AppWorkspace;
                    timer1.Stop();
                    timer1.Start();
                    
                    progressBar1.Increment(1);
                    playerStatus.InreaseCorrectedBy(1);
                    SetStatusBar(playerStatus.EstimatedAccuracy(), playerStatus.GetCorrected()
                                        , playerStatus.GetMissed(), playerStatus.Total());
                    
                    ShowCurrentText();
                }
                else
                {
                    lbFirstCharacter.BackColor = Color.Red;
                    System.Media.SystemSounds.Beep.Play();
                    playerStatus.IncreaseMissedBy(1);
                    SetStatusBar(playerStatus.EstimatedAccuracy(), playerStatus.GetCorrected()
                                        , playerStatus.GetMissed(), playerStatus.Total());
                }
            }
        }

        
        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
            playerStatus.IncreaseTotalBy(1);
            SetStatusBar(playerStatus.EstimatedAccuracy(), playerStatus.GetCorrected()
                                , playerStatus.GetMissed(), playerStatus.Total());
            ShowCurrentText();
        }
    }
}
