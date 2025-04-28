using Microsoft.VisualStudio.TestTools.UnitTesting;
using DR_Projekt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DR_Projekt.Models.Tests
{
    [TestClass()]
    public class MusicRecordTests
    {



        [TestMethod()]
        public void TestTitle()
        {

            //Act
            MusicRecord musicRecord = new MusicRecord();
            //Assert
            Assert.ThrowsException<ArgumentNullException>(
                () => musicRecord.Title = null);
            Assert.ThrowsException<ArgumentOutOfRangeException>(
                () => musicRecord.Title = "c");
        }

        [TestMethod()]
        public void TestDuration()
        {
            MusicRecord musicRecord = new MusicRecord();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => musicRecord.Duration = -1);
            musicRecord.Duration = 1;
            Assert.AreEqual(1, musicRecord.Duration);
        }

        [TestMethod()]
        public void TestYear()
        {
            MusicRecord musicRecord = new MusicRecord();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => musicRecord.Year = 1939);
            musicRecord.Year = 1945;
            Assert.AreEqual(1945, musicRecord.Year);
        }

        [TestMethod()]
        public void ToStringTest()
        {
            //Arrange
            MusicRecord musicRecord = new MusicRecord();
            //Act
            musicRecord.Title = "test";
            string result = musicRecord.ToString();
            //Assert
            Assert.AreEqual("test", result);


        }
    }
}