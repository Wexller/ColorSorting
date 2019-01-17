using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ColorSorting.Tests
{
    [TestClass]
    public class SortingTests

    {
        private Data _dataStorage;
        private Sorting _sortingObjects;
        private string _objects = "КЗССЗККЗСЗК";
        private string _greenColor = "З";
        private string _blueColor = "С";
        private string _redColor = "К";

        [TestInitialize]
        /// <summary>
        /// Тест, загружающийся перед каждым запуском теста
        /// </summary>
        public void TestInitialize()
        {
            Debug.WriteLine("Test Initialize");
            _dataStorage = new Data();
            _sortingObjects = new Sorting();
        }

        [TestMethod]
        /// <summary>
        /// Тест, проверяющий запись в поле _objects класса Sorting
        /// </summary>
        public void SetObjects_SetObjectsInField_RecordingSuccessful()
        {
            string expected = "КЗССЗККЗСЗК";

            _sortingObjects.SetObjects(_objects);

            Assert.AreEqual(expected, _sortingObjects._objects);
        }

        [TestMethod]
        /// <summary>
        /// Тест, проверяющий запись в поле _greenObject класса Sorting
        /// </summary>
        public void SetColorsOfObjects_SetFirstColor_RecordingSuccessful()
        {
            string expected = "З";

            _sortingObjects.SetColorsOfObjects(_greenColor, _blueColor, _redColor);

            Assert.AreEqual(expected, _sortingObjects._greenObject);
        }

        [TestMethod]
        /// <summary>
        /// Тест, проверяющий запись в поле _blueObject класса Sorting
        /// </summary>
        public void SetColorsOfObjects_SetSecondColor_RecordingSuccessful()
        {
            string expected = "С";

            _sortingObjects.SetColorsOfObjects(_greenColor, _blueColor, _redColor);

            Assert.AreEqual(expected, _sortingObjects._blueObject);
        }

        [TestMethod]
        /// <summary>
        /// Тест, проверяющий запись в поле _redObject класса Sorting
        /// </summary>
        public void SetColorsOfObjects_SetThirdColor_RecordingSuccessful()
        {
            string expected = "К";

            _sortingObjects.SetColorsOfObjects(_greenColor, _blueColor, _redColor);

            Assert.AreEqual(expected, _sortingObjects._redObject);
        }

        [TestMethod]
        /// <summary>
        /// Тест, проверяющий позицию зеленого объекта
        /// </summary>
        public void GetCondition_SetColors_GetPositionGreen()
        {
            int expected = 1;

            _sortingObjects.GetCondition(_greenColor, _blueColor, _redColor);

            Assert.AreEqual(expected, _sortingObjects._greenObjectPosition);
        }

        [TestMethod]
        /// <summary>
        /// Тест, проверяющий позицию синего объекта
        /// </summary>
        public void GetCondition_SetColors_GetPositionBlue()
        {
            int expected = 2;

            _sortingObjects.GetCondition(_greenColor, _blueColor, _redColor);

            Assert.AreEqual(expected, _sortingObjects._blueObjectPosition);
        }

        [TestMethod]
        /// <summary>
        /// Тест, проверяющий позицию красного объекта
        /// </summary>
        public void GetCondition_SetColors_GetPositionRed()
        {
            int expected = 3;

            _sortingObjects.GetCondition(_greenColor, _blueColor, _redColor);

            Assert.AreEqual(expected, _sortingObjects._redObjectPosition);
        }

        [TestMethod]
        /// <summary>
        /// Тест, проверяющий задание позиции зеленого объекта
        /// </summary>
        public void GetConditionHelper_SetColors_GetPositionGreen()
        {
            int colorPosition = 1;
            int expected = 1;

            _sortingObjects.GetConditionHelper(_greenColor, colorPosition);

            Assert.AreEqual(expected, _sortingObjects._greenObjectPosition);
        }

        [TestMethod]
        /// <summary>
        /// Тест, проверяющий задание позиции красного объекта
        /// </summary>
        public void GetConditionHelper_SetColors_GetPositionBlue()
        {
            int colorPosition = 2;
            int expected = 2;

            _sortingObjects.GetConditionHelper(_blueColor, colorPosition);

            Assert.AreEqual(expected, _sortingObjects._blueObjectPosition);
        }

        [TestMethod]
        /// <summary>
        /// Тест, проверяющий задание позиции синего объекта
        /// </summary>
        public void GetConditionHelper_SetColors_GetPositionRed()
        {
            int colorPosition = 3;
            int expected = 3;

            _sortingObjects.GetConditionHelper(_redColor, colorPosition);

            Assert.AreEqual(expected, _sortingObjects._redObjectPosition);
        }

        [TestMethod]
        /// <summary>
        /// Тест, проверающий возврат позиции зеленого объекта
        /// </summary>
        public void CheckObjectColor_SetGreenColor_ReturnPosition()
        {
            char _greenColorChar = 'З';
            int expected = 1;

            _sortingObjects.GetCondition(_greenColor, _blueColor, _redColor);
            int result = _sortingObjects.CheckObjectColor(_greenColorChar);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        /// <summary>
        /// Тест, проверающий возврат позиции Синего объекта
        /// </summary>
        public void CheckObjectColor_SetBlueColor_ReturnPosition()
        {
            char _BlueColorChar = 'С';
            int expected = 2;

            _sortingObjects.GetCondition(_greenColor, _blueColor, _redColor);
            int result = _sortingObjects.CheckObjectColor(_BlueColorChar);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        /// <summary>
        /// Тест, проверающий возврат позиции красаного объекта
        /// </summary>
        public void CheckObjectColor_SetRedColor_ReturnPosition()
        {
            char _redColorChar = 'К';
            int expected = 3;

            _sortingObjects.GetCondition(_greenColor, _blueColor, _redColor);
            int result = _sortingObjects.CheckObjectColor(_redColorChar);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        /// <summary>
        /// Тест, проверающий возврат позиции другого объекта
        /// </summary>
        public void CheckObjectColor_SetAbotherColor_ReturnPosition()
        {
            char _anotherColorChar = 'Щ';
            int expected = 100;

            _sortingObjects.GetCondition(_greenColor, _blueColor, _redColor);
            int result = _sortingObjects.CheckObjectColor(_anotherColorChar);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        /// <summary>
        /// Тест, проверающий правильность сортировки при заданных параметрах
        /// </summary>
        public void ObjectsSorting_SetParametrsObjectsAndColors_ReturnedSortedObject()
        {
            string expected = "ЗЗЗЗСССКККК";

            string result = _sortingObjects.ObjectsSorting(_objects, _greenColor, _blueColor, _redColor);

            Assert.AreEqual(expected, result);
        }

    }
}
