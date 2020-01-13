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
    public partial class Sumary : Form
    {
        private bool exitState;
        public Sumary()
        {
            InitializeComponent();
        }
        public bool GetExitID()
        {
            return exitState;
        }
        
        private void Sumary_Load(object sender, EventArgs e)
        {
            exitState = false;
            PlayerStatus playerStatus=Program.GetMainGame().GetPlayerStatus();
            lbSumaryAccuracy.Text = Math.Round(playerStatus.EstimatedAccuracy(),3).ToString();
            lbSumaryCorrected.Text = playerStatus.GetCorrected().ToString();
            lbSumaryMissed.Text = playerStatus.GetMissed().ToString();
            lbSumaryTotal.Text = playerStatus.Total().ToString();
        }

        private void btAgain_Click(object sender, EventArgs e)
        {
            exitState = true;
            this.Dispose();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            exitState = false;
            this.Dispose();
        }
    }
}
