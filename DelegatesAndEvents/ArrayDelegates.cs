using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    public  class ArrayDelegates
    {
        delegate void DelOp(int x, int y);
        public static void Implemented()
        {
            DelOp[] op =
            {
                new DelOp(Operation.Add),
                new DelOp(Operation.Sub)
            };
            for(int i=0;i<op.Length; i++)
            {
                op[i](1, 2);
                op[i](3, 4);
                op[i](6, 2);
            }
            
        }
        public static void MultiCastDelegate()
        {
            DelOp op = Operation.Add;
            op += Operation.Sub;
            op(2, 1);
            op(7, 3);
        }
    }
}
