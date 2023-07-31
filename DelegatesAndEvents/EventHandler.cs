using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    public delegate void DelEventHandler();
    public class EventHandler
    {
        public static event DelEventHandler del;
        public static void India()
        {
            Console.WriteLine("India");

        }
        public static void USA()
        {
            Console.WriteLine("USA");
        }
        public static void England()
        {
            Console.WriteLine("England");
        }
        public static void EventImplement()
        {
            del += new DelEventHandler(India);
            del += new DelEventHandler(USA);
            del += new DelEventHandler(England);
            del.Invoke();
        }
    }
}
