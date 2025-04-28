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

        [TestInitialize()]
        public void Setup() {
            //Arrange
            MusicRecord musicRecord = new MusicRecord();
        }


        [TestMethod()]
        public void TestTitle() {
           
            //Act
     
            //Assert
            Assert.ThrowsException<ArgumentNullException>(
                () => musicRecord.Title = null);
            Assert.ThrowsException<ArgumentOutOfRangeException>(
                () => musicRecord.Title = "c");
        }

        [TestMethod()]
        public void TestDuration() {

            
        }

        [TestMethod()]
        public void ToStringTest() {
            //Arrange
            MusicRecord musicRecord = new MusicRecord();
            //Act
            musicRecord.Title = "test";
            string result = musicRecord.ToString();
            //Assert
            Assert.AreEqual("test",result);


        }
    }
}