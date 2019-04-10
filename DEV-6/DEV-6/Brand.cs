using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_6
{
    class Brand
    {
        public string name;
        public List<Model> models;

        public Brand()
        {
            models = new List<Model>();
        }
    }
}
