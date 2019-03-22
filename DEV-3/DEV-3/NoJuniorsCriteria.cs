namespace DEV_3
{
    class NoJuniorsCriteria : SetTeam
    {
        public NoJuniorsCriteria(int budget, int productivity)
        {
            this.productivity = productivity;
            this.budget = budget;
        }

        public override int[] Calculations()
        {
            int[] team = new int[4];
            team[3] = (int)productivity / teamlead.Productivity;
            productivity -= team[3] * teamlead.Productivity;
            team[2] = (int)productivity / senior.Productivity;
            productivity -= team[2] * senior.Productivity;
            team[1] = (int)productivity / middle.Productivity;
            productivity -= team[1] * middle.Productivity;
            return team;
        }
    }
}
