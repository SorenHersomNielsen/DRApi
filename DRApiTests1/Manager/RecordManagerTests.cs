using Microsoft.VisualStudio.TestTools.UnitTesting;
using DRApi.Manager;
using System;
using System.Collections.Generic;
using System.Text;
using DRApi.Model;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DRApi.Manager.Tests
{
    [TestClass()]
    public class RecordManagerTests
    {
        RecordManager recordmanager;
        Record record;
        private static readonly string DriverDirectory = "C:/Users/herso/OneDrive/Skrivebord/3. semester/Programming/Webdrivers/chromedriver_win32";
        private static IWebDriver _driver;

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

            _driver = new ChromeDriver(DriverDirectory);

            _driver.Navigate().GoToUrl("file:///C:User/herso/OneDrive/Skrivebord/3.semester/Programming/DRapiHtml");
            Assert.AreNotEqual("Calculator", _driver.Title);
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