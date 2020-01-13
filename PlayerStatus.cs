using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeRacer
{
    public class PlayerStatus
    {
        public PlayerStatus(int _corrected,int _missed)
        {
            total = 0;
            missed = _missed;
            corrected = _corrected;
        }
        private int missed;
        private int corrected;
        private int total;
        public int GetCorrected()
        {
            return corrected;
        }
        public int GetMissed()
        {
            return missed;
        }
        public void InreaseCorrectedBy(int gap )
        {
            corrected += gap;
        }
        public void IncreaseMissedBy(int gap)
        {
            missed += gap;
        }
        public void IncreaseTotalBy(int gap)
        {
            total += gap;
        }
        public int Total()
        {
            return missed + corrected + total;
        }
        public double EstimatedAccuracy(){
            double total = this.Total();
            return (corrected * 100) / total;
        }
    }
}
