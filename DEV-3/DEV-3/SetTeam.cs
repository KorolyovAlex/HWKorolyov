namespace DEV_3
{
    class SetTeam
    {
        protected int productivity;
        protected int budget;
        protected Junior junior;
        protected Middle middle;
        protected Senior senior;
        protected TeamLead teamlead;

        public SetTeam()
        {
            junior = new Junior();
            middle = new Middle();
            senior = new Senior();
            teamlead = new TeamLead();
        }

        public virtual int[] Calculations()
        {
            int[] team = new int[4];
            return team;
        }
    }
}
