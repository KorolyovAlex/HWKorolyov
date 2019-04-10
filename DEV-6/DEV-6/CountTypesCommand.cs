using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_6
{
    class CountTypesCommand
    {
        private List<Brand> carList;

        public CountTypesCommand(List<Brand> carList)
        {
            this.carList = carList;
        }
    }
}
