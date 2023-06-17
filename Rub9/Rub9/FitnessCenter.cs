using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rub9
{
    internal class FitnessCenter
    {
        public int ClientID { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public int TrainingDuration { get; set; }

        public FitnessCenter(int clientID, int year, int month, int trainingDuration)
        {
            ClientID = clientID;
            Year = year;
            Month = month;
            TrainingDuration = trainingDuration;
        }
    }
}
