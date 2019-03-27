using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_4
{
    class SeminarLesson : EducationalMaterial, ICloneable
    {
        private int lessonnumber;
        public string[] tasks;

        public SeminarLesson(int lessonnumber)
        {
            Random rand = new Random();
            int amount = rand.Next(3, 7);
            tasks = new string[amount];
            this.lessonnumber = lessonnumber;
            for (int i = 0; i < tasks.Length; i++)
            {
                tasks[i] = lessonnumber.ToString() + "." + rand.Next(0, 101);
            }
            guid = GuidGenerator.GenerateGuid();
        }
        public override string ToString()
        {
            return "Seminar lesson";
        }        

        public object Clone()
        {
            return new SeminarLesson(lessonnumber)
            {
                guid = this.guid,
                tasks = this.tasks
            };
        }
    }
}
