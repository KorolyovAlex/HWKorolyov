namespace DEV_3
{
    class TeamLead : Senior
    {
        public TeamLead(string firstname, string lastname) : base(firstname, lastname)
        {
            salary += 300;
            productivity += 70;
        }
        public TeamLead()
        {
            salary += 300;
            productivity += 70;
        }
    }
}
