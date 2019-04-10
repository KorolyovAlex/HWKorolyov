using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_6
{
    class Menu
    {
        private List<Brand> carList;
        Command command;

        public Menu(List<Brand> carList)
        {
            this.carList = carList;
        }

        public void SetCommand(Command command)
        {
            this.command = command;
        }

        public void DoRequest()
        {
            command.Execute();
        }
    }
}
