using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Api;
using NUnit.Framework.Constraints;
using Assert = NUnit.Framework.Assert;

namespace TestProject.Tests
{
    [TestClass()]
    public class CustomMathTests
    {
        //[TestMethod()]
        //public void SumXTest()
        //{
        //   // Assert.Fail();
        //}

        [TestCase(10,20,30)]
        [TestCase(20,30,50)]
        [TestCase(-10, -20, -30)]
        [TestCase(-20, -30, -50)]
        public void SumTest(int x, int y, int expected)
        {
            int result = CustomMath.Sum(x, y);
            NUnit.Framework.Assert.AreEqual(expected, result);
        }

        [TestCase(10, 20,0.5)]
        [TestCase(20, 10, 2)]
        [TestCase(20, -30, -0.66666666666666663)]
        [TestCase(-20, -30, 0.66666666666666663)]
        [TestCase(0, -30, 0)]
        
        public void DivideTest(double x, double y, double expected)
        {

            double result = CustomMath.Divide(x,y );
            NUnit.Framework.Assert.AreEqual(expected, result);

        }


        [TestCase(30, 0)]
        public void DivideTestBy0(double x, double y)
        {
            Assert.Throws<DivideByZeroException>(() => CustomMath.Divide(x, y));
            
        }

        [TestMethod()]
        public void SumXTest()
        {
            CustomMath m = new CustomMath();
            m.y = 10;
            m.x = 20;
            var expected = 30;
            m.SumX();
            Assert.AreEqual(expected, m.x);

            m.y = 20;
            m.x = 20;
            expected = 40;
            m.SumX();
            Assert.AreEqual(expected, m.x);
        }

    }
}