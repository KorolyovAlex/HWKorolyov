namespace DEV_3
{
    class Middle : Junior
    {
        public Middle(string firstname, string lastname) : base(firstname, lastname)
        {
            salary += 200;
            productivity += 50;
        }

        public Middle()
        {
            salary += 200;
            productivity += 50;
        }
    }
}
