using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_4
{
    class Lecture : Subject, ICloneable
    {
        protected struct Presentation
        {
            public string uri;
            public PresentationFormat format;
        }

        protected Presentation presentation;

        public string lecturetext;

        static int counter = 0;

        protected enum PresentationFormat : byte
        {
            Unknown,
            PDF,
            PPT
        }

        public Lecture()
        {
            seminars = new List<SeminarLesson>();
            Random rand = new Random();
            int amount = rand.Next(0, 3);
            for (int i = 0; i < amount; i++)
            {
                var seminar = new SeminarLesson(++counter);
                seminars.Add(seminar);
                base.seminars.Add(seminar);
            }
            labs = new List<LaboratoryLesson>();
            amount = rand.Next(0, 3);
            for (int i = 0; i < amount; i++)
            {
                var laba = new LaboratoryLesson();
                labs.Add(laba);
                base.labs.Add(laba);
            }
            presentation.format = (PresentationFormat)rand.Next(0, 3);
            presentation.uri = @"https://ru.wikipedia.org/wiki/%D0%9B%D0%B5%D0%BA%D1%86%D0%B8%D1%8F";
            guid = GuidGenerator.GenerateGuid();
        }
                
        public override string ToString()
        {
            foreach (SeminarLesson sem in seminars)
            {
                sem.ToString();
            }
            foreach(LaboratoryLesson lab in labs)
            {
                lab.ToString();
            }
            return "Lecture";
        }

        public object Clone()
        {
            return new Lecture
            {
                guid = this.guid,
                labs = this.labs,
                presentation = this.presentation,
                seminars = this.seminars,
                lecturetext = this.lecturetext
            };
        }
    }
}
