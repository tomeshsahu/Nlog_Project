using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace NLog_Example
{
    public class AddNumber
    {
        NLog obj1 = new NLog();
        public int Sum(int a, int b)
        {
            if (a == 0 || b == 0)
            {
                obj1.LogDebug("Debug Successfull : Sum()");
                obj1.LogError("Expecting null values");
                obj1.LogWarn("a or b should not equal to 0");
            }
            int c = a + b;
            obj1.LogDebug("Debug Successfull : Sum()");
            obj1.LogInfo("Sum method passed, Result" + c);
            return c;
        }
    }
}


