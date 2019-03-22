namespace DEV_3
{
    class Senior : Middle
    {
        public Senior(string firstname, string lastname) : base(firstname, lastname)
        {
            salary += 150;
            productivity += 30;
        }
        public Senior()
        {
            salary += 150;
            productivity += 30;
        }
    }
}
