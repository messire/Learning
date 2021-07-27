using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using Custom.Helpers;
using NUnit.Framework;

namespace Custom.Test.Tests
{
    [TestFixture]
    public class GetFirstTests : BaseTest<GetFirst>
    {
        private void CheckResult(IEnumerable<Point> actual, int k)
        {
            List<Point> points = actual.ToList();
            Assert.AreEqual(k, points.Count);
        }

        [Test]
        public void GetFirst()
        {
            Random _rnd = new Random();
            int count = _rnd.Next(10, 100);
            int max = _rnd.Next(0, int.MaxValue);
            int min = _rnd.Next(0, max - 1);

            int k = _rnd.Next(10, count - 1);
            
            Point[] collection = Generator.CreatPointCollection(count, min, max);
            
            IEnumerable<Point> result = Tester.Calculate(collection, k);
            
            CheckResult(result, k);
        }
    }
}