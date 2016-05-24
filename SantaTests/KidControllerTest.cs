using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Santa.Controllers;
using Santa.Models;
using System.Linq;
using System.Diagnostics;

namespace SantaTests
{
    [TestClass]
    public class KidControllerTest
    {
        private List<Tuple<string,int?, int?>> CheckCountData = new List<Tuple<string,int?, int?>>
        {
            { "CheckCount: 0 0",0,0 },
            { "CheckCount: 1 1",1,1 },
            { "CheckCount: 2 0",2,0 },
            { "CheckCount: null",null,0 },
            { "CheckCount: 34 0",34,0 },
            { "CheckCount: -23 -1",-23,-1 }
        };

        private static string testPar = "bob";
        private static Kid testKid = new Kid
        {
            Id = 1,
            Par = testPar,
            fName = "Joe",
            lName = "Bob",
            NN = 3
        };
        private static Kid testKid1 = new Kid
        {
            Id = 2,
            Par = testPar,
            fName = "slkfd",
            lName = "aoishgd",
            NN = -4
        };
        private static Kid testKid2 = new Kid
        {
            Id = 3,
            Par = testPar,
            fName = "xoicf",
            lName = "iuha",
            NN = 12
        };
        private static Kid testKid3 = new Kid
        {
            Id = 4,
            Par = testPar,
            fName = "asoif",
            lName = "ouish",
            NN = 3
        };
        private static Kid testKid4 = new Kid
        {
            Id = 5,
            Par = testPar,
            fName = "qwet",
            lName = "oidb",
            NN = -2
        };
        private static List<Kid> testKidList = new List<Kid>
        {
            testKid,testKid1,testKid2,testKid3,testKid4
        };
        private static List<Kid> defaultTestKidList = new List<Kid>
        {
            testKid2,testKid,testKid3,testKid4,testKid1
        };
        private static List<Tuple<string,IEnumerable<Kid>, int, int, List<Kid>>> sortKidsData =
            new List<Tuple<string,IEnumerable<Kid>, int, int, List<Kid>>>
        {
            {"Sort Kids: null",null,0,1,new List<Kid> { } },
            {"Sort Kids: 0 0",testKidList,0,0,new List<Kid>{testKid3,testKid,testKid4,testKid1,testKid2}},
            {"Sort Kids: 0 1",testKidList,0,1,new List<Kid>{testKid2,testKid1,testKid4,testKid,testKid3}},
            {"Sort Kids: 1 0",testKidList,1,0,new List<Kid>{testKid1,testKid,testKid2,testKid4,testKid3}},
            {"Sort Kids: 1 1",testKidList,1,1,new List<Kid>{testKid3,testKid4,testKid2,testKid,testKid1}},
            {"Sort Kids: 2 0",testKidList,2,0,defaultTestKidList},
            {"Sort Kids: 2 1",testKidList,2,1,new List<Kid>{testKid1,testKid4,testKid,testKid3,testKid2}},
            {"Sort Kids: -2 0",testKidList,-2,0,defaultTestKidList},
            {"Sort Kids: 9 1",testKidList,9,1,defaultTestKidList}
        };

        [TestMethod]
        public void TestCheckCount()
        {
            Debug.WriteLine("TestCheckCount");
            foreach (Tuple<string,int?,int?> item in CheckCountData)
            {
                Debug.WriteLine(item.Item1);
                Assert.AreEqual(KidsController.CheckCount(item.Item2),item.Item3);
            }
        }

        [TestMethod]
        public void TestSortKids()
        {
            Debug.WriteLine("TestSortKids:");
            foreach (Tuple<string,IEnumerable<Kid>, int, int, List<Kid>> item in sortKidsData)
            {
                Debug.WriteLine(item.Item1);
                List<Kid> temp = KidsController.SortKids(item.Item2, item.Item3, item.Item4).ToList();
                for(int i = 0; i < temp.Count || i < item.Item5.Count; i++)
                {
                    Assert.AreEqual(item.Item5[i],temp[i]);
                }
            }
        }
    }
}
