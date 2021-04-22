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
        Tracks tracks;

        [TestInitialize]
        public void Start()
        {
            recordmanager = new RecordManager();
            record = new Record();
            tracks = new Tracks();
        }

        [TestMethod()]
        public void GetAllTest()
        {
            record.Title = "Øde Ø";
            Assert.AreEqual("Øde Ø", record.Title);
            var list = RecordManager.RecordList.Count;
            Assert.AreEqual(list, RecordManager.RecordList.Count);
            Assert.AreNotEqual(recordmanager.GetAll(), recordmanager.GetAll());
        }

        [TestMethod()]
        public void GetByIdTest()
        {
            record.Id = 4;
            Assert.AreEqual(4, record.Id);

            var getbyid = recordmanager.GetById(3);
            Assert.AreEqual(getbyid, recordmanager.GetById(3));
        }

        [TestMethod()]
        public void GetByTitleTest()
        {
            record.Title = "evig glad";
            Assert.AreEqual("evig glad", record.Title);

            var getbytitle = recordmanager.GetByTitle("rasmus");
            Assert.AreEqual(getbytitle, recordmanager.GetByTitle("rasmus"));
        }

        [TestMethod()]
        public void GetByArtistTest()
        {
            record.Artist = "hallo";
            Assert.AreEqual("hallo", record.Artist);

            Record getbyartist = recordmanager.GetByArtist("maj");
            Assert.AreEqual(getbyartist, recordmanager.GetByArtist("maj"));
        }


        [TestMethod]
        public void AllTracksTest()
        {
            tracks.Name = "back to black";
            Assert.AreEqual("back to black",tracks.Name);
            var list = RecordManager.TracksList.Count;
            Assert.AreEqual(list, RecordManager.TracksList.Count);
        }

        [TestMethod]
        public void AddTracksTest()
        {
            tracks.Name = "Watch What Happens next";
            Assert.AreEqual("Watch What Happens next", tracks.Name);

            tracks.Genre = "Rock";
            Assert.AreEqual("Rock", tracks.Genre);

            Tracks t = recordmanager.AddTracks(1, tracks);
            Assert.AreEqual(t, recordmanager.AddTracks(1, tracks));
        }
        
        
        /*
        [TestMethod]
        public void UiTest()
        {
        private static readonly string DriverDirectory = "C:/Users/herso/OneDrive/Skrivebord/3. semester/Programming/Webdrivers/chromedriver_win32";
        private static readonly string DriverDirectory2 = "C:/webDrivers";
        private static IWebDriver _driver;


        //_driver = new ChromeDriver(DriverDirectory2);

            //_driver.Navigate().GoToUrl("https://math6799-drhtml.azurewebsites.net/");
            //Assert.AreNotEqual("Calculator", _driver.Title);
        }
        */
    }
}