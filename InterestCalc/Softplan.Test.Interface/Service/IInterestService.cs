using System;
using System.Collections.Generic;
using System.Text;

namespace Softplan.Test.Interface.Service
{
    public interface IInterestService
    {
        decimal Calc(decimal value, int months);
    }
}
