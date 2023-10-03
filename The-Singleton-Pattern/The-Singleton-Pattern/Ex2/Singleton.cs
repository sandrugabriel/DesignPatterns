using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Singleton_Pattern.Ex2
{
    public class Singleton
    {
        private static Singleton instance = null;
        private Singleton() { }

        public static Singleton Instance
        {
            get { 
                
                if(instance == null)
                    instance = new Singleton();
                
                return instance; 
            
            }

        }

        public void doSometimes()
        {
            Console.WriteLine("Hello");
        }

    }
}
