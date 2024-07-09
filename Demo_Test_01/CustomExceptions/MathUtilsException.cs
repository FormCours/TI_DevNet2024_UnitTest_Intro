using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Test_01.CustomExceptions
{
    public class MathUtilsException : Exception { }
    public class MathUtilsDivByZeroException : MathUtilsException { }

}
