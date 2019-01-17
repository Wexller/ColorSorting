using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ColorSorting.Tests
{
    [TestClass]
    public class ColorSortingFormTests
    {
        private Data _dataStorage;
        private ColorSortingForm _sortingForm;
        string objectsField = "КЗСЗЗСККЗСК";
        string firstObjectColor = "З";
        string secondObjectColor = "С";
        string thirdObjectColor = "К";
               
        [TestInitialize]
        /// <summary>
        /// Тест, загружающийся перед каждым запуском теста
        /// </summary>
        public void TestInitialize()
        {
            Debug.WriteLine("Test Initialize");
            _dataStorage = new Data();
            _sortingForm = new ColorSortingForm();
            _sortingForm.SetData(_dataStorage, objectsField, firstObjectColor, secondObjectColor, thirdObjectColor);
        }

        [TestMethod]
        /// <summary>
        /// Тест, проверяющий запись в поле ObjectsFromForm класса Data
        /// </summary>
        public void SetData_WhriteObjectsFieldInData_FieldsAreEqual()
        {
                        
            Assert.AreEqual(objectsField, _dataStorage.ObjectsFromForm);

        }

        [TestMethod]
        /// <summary>
        /// Тест, проверяющий запись в поле FirstObject класса Data
        /// </summary>
        public void SetData_WhriteFirstObfectColorInData_FieldsAreEqual()
        {

            Assert.AreEqual(firstObjectColor, _dataStorage.FirstObject);

        }

        [TestMethod]
        /// <summary>
        /// Тест, проверяющий запись в поле SecondObject класса Data
        /// </summary>
        public void SetData_WhriteSecondObfectColorInData_FieldsAreEqual()
        {

            Assert.AreEqual(secondObjectColor, _dataStorage.SecondObject);

        }

        [TestMethod]
        /// <summary>
        /// Тест, проверяющий запись в поле ThirdObgect класса Data
        /// </summary>
        public void SetData_WhriteThirdObfectColorInData_FieldsAreEqual()
        {

            Assert.AreEqual(thirdObjectColor, _dataStorage.ThirdObgect);
                        
        }

        [TestMethod]
        /// <summary>
        /// Тест, проверяющий выбор разных отношений
        /// </summary>
        public void CheckObjectColors_1and2and3_isTrue()
        {
            int param1 = 1;
            int param2 = 2;
            int param3 = 3;

            bool expected = true;

            bool result = _sortingForm.CheckObjectColors(param1, param2, param3);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        /// <summary>
        /// Тест, проверяющий выбор одинаковых
        /// </summary>
        public void CheckObjectColors_1and2and3_isFalse()
        {
            int param1 = 1;
            int param2 = 2;
            int param3 = 2;

            bool expected = false;

            bool result = _sortingForm.CheckObjectColors(param1, param2, param3);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        /// <summary>
        /// Тест, проверяющий заполненное поле ввода
        /// </summary>
        public void CheckObjectsField_NotEmptyField_IsTrue()
        {
            string textField = "ЗКССКС";

            bool expected = true;

            bool result = _sortingForm.CheckObjectsField(textField);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        /// <summary>
        /// Тест, проверяющий пустое поле ввода
        /// </summary>
        public void CheckObjectsField_EmptyField_IsFalse()
        {
            string textField = "";

            bool expected = false;

            bool result = _sortingForm.CheckObjectsField(textField);

            Assert.AreEqual(expected, result);
        }
    }
}
