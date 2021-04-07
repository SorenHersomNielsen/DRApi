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
        RecordManager recordmanager;
        Record record;
        [TestInitialize]
        public void Start()
        {
            recordmanager = new RecordManager();
            record = new Record();
        }

        [TestMethod()]
        public void GetAllTest()
        {
            record.Title = "Øde Ø";
            Assert.AreEqual("Øde Ø", record.Title);
            //Assert.ThrowsException<ArgumentException>(() => record.Title = "Øde ø");
            var list = RecordManager.RecordList.Count;
            Assert.AreEqual(list, RecordManager.RecordList.Count);
            Assert.AreNotEqual(recordmanager.GetAll(), recordmanager.GetAll());
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