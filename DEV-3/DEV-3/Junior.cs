namespace DEV_3
{
    class Junior : Employee
    {
        public Junior(string firstname, string lastname) : base(firstname, lastname)
        {
            salary += 400;
            productivity += 50;
        }
        
        public Junior()
        {
            salary += 400;
            productivity += 50;
        }
    }
}
