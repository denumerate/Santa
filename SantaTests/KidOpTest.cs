using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Santa.Models;
using System.Collections.Generic;

namespace SantaTests
{

    [TestClass]
    public class KidOpTest
    {

        private List<Tuple<int, string>> JudgeData = new List<Tuple<int, string>>
        {
            {2, "Not Terrible" },
            {4, "Meh" },
            {-233, "Devil Incarnate" },
            {65, "Far Too Perfect" },
            {7, ":)" },
            {-7, "Delinquent" },
            {5, "Meh" },
            {-1, "Not Terrible" },
            {0, "Not Terrible" },
            {-3, "In Trouble" }
        };

        [TestMethod]
        public void TestJudge()
        {
            foreach(Tuple<int,string> item in JudgeData)
            {
                Assert.AreEqual(KidOp.Judge(item.Item1), item.Item2);
            }
        }
    }
}
