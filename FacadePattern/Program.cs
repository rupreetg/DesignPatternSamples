using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Without facade
            Doors door = new Doors();
            Windows window = new Windows();
            Almirah almirah = new Almirah();
            //can have many more objects to lock the house...

            door.LockDoors();
            window.CloseWindows();
            almirah.LockAmirah();

            Console.WriteLine("-----------------------");
            //With Facade
            HouseFacade house = new HouseFacade();
            house.LockHosue();
        }
    }
}
