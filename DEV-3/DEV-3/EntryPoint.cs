using System;
using System.Collections.Generic;

namespace DEV_3
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            Console.Write("Project's budget: ");
            int.TryParse(Console.ReadLine(), out int projectbudget);
            Console.Write("Productivity: ");
            int.TryParse(Console.ReadLine(), out int productivity);
            Console.WriteLine("Choose criterion:\n Fixed Budget and Max Productivity - Enter 1\n Fixed Productivity and Min Budget - Enter 2\n Min amount of Juniors in team - Enter 3");
            int.TryParse(Console.ReadLine(), out int criterion);
            SetTeam obj;
            int[] team = new int[4];
            switch (criterion)
            {
                case 1:
                    obj = new MaxProductivityCriteria(projectbudget, productivity);
                    team = obj.Calculations();
                    break;
                case 2:
                    obj = new MinBudgetCriteria(projectbudget, productivity);
                    team = obj.Calculations();
                    break;
                case 3:
                    obj = new NoJuniorsCriteria(projectbudget, productivity);
                    team = obj.Calculations();
                    break;
                default:
                    Console.WriteLine("Error: Invalid criterion");
                    return;
            }
            var teambuilder = new Company();
            List<Employee> projectteam = new List<Employee>();
            projectteam = teambuilder.WorkersAllotment(team);
            if (projectteam.Count != 0)
            {
                Console.WriteLine("Your team for project:");
                foreach (Employee teammember in projectteam)
                {
                    teammember.EmployeeInfo();
                    if (teammember.GetType() == typeof(TeamLead))
                    {
                        Console.WriteLine(" - TeamLead");
                        continue;
                    }
                    if (teammember.GetType() == typeof(Senior))
                    {
                        Console.WriteLine(" - Senior");
                        continue;
                    }
                    if (teammember.GetType() == typeof(Middle))
                    {
                        Console.WriteLine(" - Middle");
                        continue;
                    }
                    if (teammember.GetType() == typeof(Junior))
                    {
                        Console.WriteLine(" - Junior");
                        continue;
                    }
                }
            }
            return;
        }
    }
}
