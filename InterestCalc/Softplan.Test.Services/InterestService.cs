using Microsoft.Extensions.Configuration;
using Softplan.Test.Interface.Service;
using System;

namespace Softplan.Test.Services
{
    public class InterestService : IInterestService
    {
        private readonly double FIXED_INTEREST = 0.001;

        public InterestService()
        {
            
        }

        public decimal Calc(decimal value, int months)
        {
            var vf = (value + (value * Convert.ToDecimal(FIXED_INTEREST) + months)).ToString("###.##");
            return Convert.ToDecimal(String.Format("{0:0.00}", Convert.ToDecimal(vf)));
        }
    }
}
