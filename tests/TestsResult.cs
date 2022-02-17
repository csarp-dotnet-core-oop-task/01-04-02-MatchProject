using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using MatchProject;

namespace MatchProject.Tests
{
    [TestClass()]
    public class TestsResult
    {
        [TestMethod()]
        public void TestConstructor()
        {
            try
            {
                Result firstMatch = new Result(2, 1);
            }
            catch (Exception e)
            {
                Assert.Fail("A Result constructor hibát dob.");
            }
        }

        [TestMethod()]
        public void TestHomeTeamPoint()
        {
            Result match01 = new Result(2, 1);
            Result match02 = new Result(1, 1);
            Result match03 = new Result(1, 2);


            int expected = 2;
            int actaul = match01.HomeTeamPoint;
            Assert.AreEqual(expected, actaul, "A hazai pontok számát nem jól határozta meg.");

            expected = 1;
            actaul = match02.HomeTeamPoint;
            Assert.AreEqual(expected, actaul, "A hazai pontok számát nem jól határozta meg.");

            expected = 0;
            actaul = match03.HomeTeamPoint;
            Assert.AreEqual(expected, actaul, "A hazai pontok számát nem jól határozta meg.");
        }

        [TestMethod()]
        public void TestGuestTeamPointt()
        {
            Result match01 = new Result(2, 1);
            Result match02 = new Result(1, 1);
            Result match03 = new Result(1, 2);


            int expected = 0;
            int actaul = match01.GuestTeamPoint;
            Assert.AreEqual(expected, actaul, "A vendég pontok számát nem jól határozta meg.");

            expected = 1;
            actaul = match02.GuestTeamPoint;
            Assert.AreEqual(expected, actaul, "A vendég pontok számát nem jól határozta meg.");

            expected = 2;
            actaul = match03.GuestTeamPoint;
            Assert.AreEqual(expected, actaul, "A vendég pontok számát nem jól határozta meg.");
        }

        [TestMethod()]
        public void TestGoalDifference()
        {
            Result match01 = new Result(2, 1);
            Result match02 = new Result(1, 1);
            Result match03 = new Result(1, 2);


            int expected = 1;
            int actaul = match01.GoalDifference;
            Assert.AreEqual(expected, actaul, "A gólkülöbséget nem jól határozta meg.");

            expected = 0;
            actaul = match02.GoalDifference;
            Assert.AreEqual(expected, actaul, "A gólkülöbséget nem jól határozta meg.");

            expected = -1;
            actaul = match03.GoalDifference;
            Assert.AreEqual(expected, actaul, "A gólkülöbséget nem jól határozta meg.");
        }

    }
}