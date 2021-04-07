using Microsoft.VisualStudio.TestTools.UnitTesting;
using DRApi.Manager;
using System;
using System.Collections.Generic;
using System.Text;
using DRApi.Model;

namespace DRApi.Manager.Tests
{
    [TestClass()]
    public class RecordManagerTests
    {
        Record record;

        [TestInitialize]
        public void StartTest()
        {
            record = new Record();
        }

        [TestMethod()]
        public void GetAllTest()
        {
            var list = RecordManager.RecordList.Count;
            Assert.AreEqual(list, RecordManager.RecordList.Count);
        }

        [TestMethod()]
        public void GetByIdTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetByTitleTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetByArtistTest()
        {
            Assert.Fail();
        }
    }
}