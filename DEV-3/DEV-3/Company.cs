using System;
using System.Collections.Generic;
using System.IO;

namespace DEV_3
{    
    class Company
    {
        private int[] workers = {15, 4, 5, 6};
        private List<PersonalData> workername = new List<PersonalData>();

        public Company()
        {
            ReadNames();
        }

        private bool AmountChecker(int[] team)
        {
            for (int i = 0; i < team.Length; i++)
            {
                if (team[i] > workers[i])
                {
                    return true;
                }                
            }
            return false;
        }
        private void ReadNames()
        {
            using (StreamReader sr = new StreamReader(@"E:\C#\DEV-3\DEV-3\Names.txt"))
            {
                string fullname;
                while ((fullname = sr.ReadLine()) != null)
                {
                    string[] name = fullname.Split();
                    workername.Add(new PersonalData(name[0], name[1]));
                }
                sr.Close();
            }
        }

        public List<Employee> WorkersAllotment(int[] teamcomposition)
        {
            List<Employee> workerslist = new List<Employee>();
            if (AmountChecker(teamcomposition))
            {
                Console.WriteLine("We don't have enough employees to work on your project");
                return workerslist;
            }
            for (int index = 0; index < teamcomposition.Length; index++)
            {
                while (teamcomposition[index] != 0)
                {
                    switch (index)
                    {
                        case 0:
                            workerslist.Add(new Junior(workername[0].Firstname, workername[0].Lastname));
                            workername.RemoveAt(0);
                            break;
                        case 1:
                            workerslist.Add(new Middle(workername[0].Firstname, workername[0].Lastname));
                            workername.RemoveAt(0);
                            break;
                        case 2:
                            workerslist.Add(new Senior(workername[0].Firstname, workername[0].Lastname));
                            workername.RemoveAt(0);
                            break;
                        case 3:
                            workerslist.Add(new TeamLead(workername[0].Firstname, workername[0].Lastname));
                            workername.RemoveAt(0);
                            break;
                        default:
                            break;
                    }
                    teamcomposition[index]--;
                    workers[index]--;
                }
            }
            return workerslist;
        }
    }
}
