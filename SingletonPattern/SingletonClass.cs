using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class SingletonClass
    {
        private static SingletonClass instance = new SingletonClass();
        private long instanceCreationTime;
        private SingletonClass()
        {
            instanceCreationTime = DateTime.Now.Ticks;
        }

        public static SingletonClass Instance => instance;

        public void DisplayInstanceCreationTime() => Console.WriteLine(instanceCreationTime);
    }
}
