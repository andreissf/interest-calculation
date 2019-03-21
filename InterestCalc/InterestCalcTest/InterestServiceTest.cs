using Softplan.Test.Services;
using System;
using Xunit;

namespace InterestCalcTest
{
    public class InterestServiceTest
    {
        [Fact]
        public void CalulateInterast()
        {

            InterestService interestService = new InterestService();
            var result = interestService.Calc(100, 5);
            Assert.Equal<decimal>(Convert.ToDecimal("105,10"), result);
        }
    }
}
