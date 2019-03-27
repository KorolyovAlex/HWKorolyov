using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_4
{
    class LaboratoryLesson : EducationalMaterial, ICloneable
    {
        public LaboratoryLesson()
        {
            guid = GuidGenerator.GenerateGuid();
        }

        public override string ToString()
        {
            return "Labaratory lesson";
        }        
        public object Clone()
        {
            return new LaboratoryLesson
            {
                guid = this.guid
            };
        }
    }
}
