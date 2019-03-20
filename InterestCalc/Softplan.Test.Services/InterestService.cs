using Softplan.Test.Interface.Service;
using System;

namespace Softplan.Test.Services
{
    public class InterestService : IInterestService
    {
        public InterestService()
        {

        }

        public decimal Calc(decimal value, int months)
        {
            return value;
        }
    }
}
