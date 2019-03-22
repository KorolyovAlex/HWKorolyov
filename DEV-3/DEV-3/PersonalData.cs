namespace DEV_3
{
    class PersonalData
    {
        private string firstname;
        private string lastname;

        public PersonalData(string firstname, string lastname)
        {
            this.firstname = firstname;
            this.lastname = lastname;
        }

        public string Firstname
        {
            get { return firstname; }
        }

        public string Lastname
        {
            get { return lastname; }
        }
    }
}
