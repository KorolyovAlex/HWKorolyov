using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_4
{
    class Subject : EducationalMaterial, ICloneable
    {
        public List<Lecture> lectures;
        public List<SeminarLesson> seminars;
        public List<LaboratoryLesson> labs;

        public Subject()
        {
            lectures = new List<Lecture>();
            Random rand = new Random();
            int amount = rand.Next(0, 17);
            for (int i = 0; i < amount; i++)
            {
                lectures.Add(new Lecture());
            }
            seminars = new List<SeminarLesson>();
            labs = new List<LaboratoryLesson>();
            guid = GuidGenerator.GenerateGuid();
        }

        public Lecture this[int index]
        {
            get
            {
                lectures[index].ToString();
                return lectures[index];
            }
        }

        public override string ToString()
        {
            return "Subject";
        }

        public object Clone()
        {
            return new Subject()
            {
                guid = this.guid,
                lectures = this.lectures,
                seminars = this.seminars,
                labs = this.labs
            };
        }
    }
}
