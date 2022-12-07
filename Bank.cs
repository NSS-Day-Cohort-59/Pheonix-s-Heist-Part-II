using System;

namespace HeistPartII
{
    //Let's create a Bank class to represent the security we're up against. Give the Bank class the following properties:
    public class Bank
    {

        //An integer property for CashOnHand
        public decimal CashOnHand { get; set; }

        //An integer property for AlarmScore
        public int AlarmScore { get; set; }

        //An integer property for VaultScore
        public int VaultScore { get; set; }

        //An integer property for SecurityGuardScore
        //A computed boolean property called IsSecure. If all the scores are less than or equal to 0, this should be false. 
        //If any of the scores are above 0, this should be true
        public int SecurityGaurdScore { get; set; }
        public bool IsSecure
        {
            get
            {
                if (AlarmScore <= 0 && VaultScore <= 0 && SecurityGaurdScore <= 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
    }
}