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
        public void TestTitle() {
            //Arrange
            MusicRecord musicRecord = new MusicRecord();
            //Act
     
            //Assert
            Assert.ThrowsException<ArgumentNullException>(
                () => musicRecord.Title = null);
        }

        [TestMethod()]
        public void ToStringTest() {
            Assert.Fail();
        }
    }
}