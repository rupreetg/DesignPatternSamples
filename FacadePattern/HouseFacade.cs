using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class HouseFacade
    {
        Doors door01;
        Windows window01;
        Almirah almirah01;

        public HouseFacade()
        {
            door01 = new Doors();
            window01 = new Windows();
            almirah01 = new Almirah();
        }

        public void LockHosue()
        {
            door01.LockDoors();
            window01.CloseWindows();
            almirah01.LockAmirah();
        }
    }
}
