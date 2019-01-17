using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ColorSorting.Tests
{
    [TestClass]
    public class UnitTest1
    {
        private Data _dataStorage;
        string objectsField = "КЗСЗЗСККЗСК";
        string firstObjectColor = "З";
        string secondObjectColor = "С";
        string thirdObjectColor = "К";

        [TestInitialize]
        public void TestInitialize()
        {
            Debug.WriteLine("Test Initialize");
            _dataStorage = new Data();
            
        }

        [TestMethod]
        public void SetData_WhriteObjectsFieldInData_FieldsAreEqual()
        {

            _dataStorage.ObjectsFromForm = objectsField;

            Assert.AreEqual(objectsField, _dataStorage.ObjectsFromForm);

        }

        [TestMethod]
        public void SetData_WhriteFirstObfectColorInData_FieldsAreEqual()
        {

            _dataStorage.FirstObject = firstObjectColor;

            Assert.AreEqual(firstObjectColor, _dataStorage.FirstObject);

        }

        [TestMethod]
        public void SetData_WhriteSecondObfectColorInData_FieldsAreEqual()
        {

            _dataStorage.SecondObject = secondObjectColor;

            Assert.AreEqual(secondObjectColor, _dataStorage.SecondObject);

        }

        [TestMethod]
        public void SetData_WhriteThirdObfectColorInData_FieldsAreEqual()
        {

            _dataStorage.ThirdObgect = thirdObjectColor;

            Assert.AreEqual(thirdObjectColor, _dataStorage.ThirdObgect);
                        
        }


    }
}
