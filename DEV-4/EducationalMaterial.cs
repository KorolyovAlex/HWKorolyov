using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_4
{
    class EducationalMaterial
    {
        protected string guid;

        public string GetGuid()
        {
            return guid;
        }

        public override bool Equals(object obj)
        {
            if (obj is EducationalMaterial)
            {
                EducationalMaterial material = (EducationalMaterial)obj;
                return this.guid == material.GetGuid();
            }
            return false;
        } 
    }
}
