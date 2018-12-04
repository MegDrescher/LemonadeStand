namespace LemonadeStand
{
    public class Report
    {
        public Player player;
        private float totalCupsSold;
        private float totalIceUsed;
        private float totalSugarUsed;
        private float totalLemonsUsed;
        private float cashMadeToday;
        private decimal cashMadeTodayRounded;

        public Report(Player player)
        {
            this.player = player;

        }

        public float CashMadeToday
        {
            get
            {
                return cashMadeToday;
            }
            set
            {
                cashMadeToday = value;
            }
        }

        public decimal CashMadeTodayRounded
        {
            get
            {
                return cashMadeTodayRounded;
            }
            set
            {
                cashMadeTodayRounded = value;
            }
        }
        
        public float TotalCupsSold
        {
            get
            {
                return totalCupsSold;
            }
            set
            {
                totalCupsSold = value;
            }
        }

        public float TotalIceUsed
        {
            get
            {
                return totalIceUsed;
            }
            set
            {
                totalIceUsed = value;
            }
        }

        public float TotalLemonsUsed
        {
            get
            {
                return totalLemonsUsed;
            }
            set
            {
                totalLemonsUsed = value;
            }
        }

        public float TotalSugarUsed
        {
            get
            {
                return totalSugarUsed;
            }
            set
            {
                totalSugarUsed = value;
            }
                
        }

        
    
    }
}