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
    public class TestsMatch
    {
        [TestMethod()]
        public void TestConstructor()
        {
            try
            {
                Result firstMatch = new Result(2, 1);
                Result secondMatch = new Result(2, 1);
                Match match = new Match("FTC", "Szeged", firstMatch, secondMatch);
            }
            catch (Exception e)
            {
                Assert.Fail("A Match constructor hibát dob.");
            }
        }

        [TestMethod()]
        public void TestWinnerFirstPoint()
        {
            Result firstMatch = new Result(3, 1);
            Result secondMatch = new Result(2, 1);
            Match match = new Match("FTC", "Szeged", firstMatch, secondMatch);
            string expected = "FTC";
            string actaul = match.Winner;
            Assert.AreEqual(expected, actaul, "A győztest nem jól határozta meg! Első csapat pontokkal!");
        }
        [TestMethod()]
        public void TestWinnerSecondPoint()
        {
            Result firstMatch = new Result(3, 3);
            Result secondMatch = new Result(2, 1);
            Match match = new Match("FTC", "Szeged", firstMatch, secondMatch);
            string expected = "Szeged";
            string actaul = match.Winner;
            Assert.AreEqual(expected, actaul, "A győztest nem jól határozta meg! Második csapat pontokkal!");
        }

        [TestMethod()]
        public void TestNoWinner()
        {
            Result firstMatch = new Result(3, 0);
            Result secondMatch = new Result(3, 0);
            Match match = new Match("FTC", "Szeged", firstMatch, secondMatch);
            string expected = "-";
            string actaul = match.Winner;
            Assert.AreEqual(expected, actaul, "Amikor nincs győztes nem jól hatorzta meg a kimenetet!");
        }

        [TestMethod()]
        public void TestNoWinner2()
        {
            Result firstMatch = new Result(3, 3);
            Result secondMatch = new Result(3, 3);
            Match match = new Match("FTC", "Szeged", firstMatch, secondMatch);
            string expected = "-";
            string actaul = match.Winner;
            Assert.AreEqual(expected, actaul, "Amikor nincs győztes nem jól hatorzta meg a kimenetet!");
        }
    }
}