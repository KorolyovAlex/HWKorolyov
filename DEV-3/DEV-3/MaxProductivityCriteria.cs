namespace DEV_3
{
    class MaxProductivityCriteria : SetTeam
    {
        public MaxProductivityCriteria(int budget, int productivity)
        {
            this.productivity = productivity;
            this.budget = budget;
        }

        public override int[] Calculations()
        {
            int[] team = new int[4];
            team[3] = (int)budget / teamlead.Salary;
            budget -= team[3] * teamlead.Salary;
            team[2] = (int)budget / senior.Salary;
            budget -= team[2] * senior.Salary;
            team[1] = (int)budget / middle.Salary;
            budget -= team[1] * middle.Salary;
            team[0] = (int)budget / junior.Salary;
            budget -= team[0] * junior.Salary;
            return team;
        }
    }
}
