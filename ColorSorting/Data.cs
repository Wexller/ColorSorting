using System;

namespace ColorSorting
{
    public class Data
    {

        /// <summary>
        /// Строка объектов
        /// </summary>
        private string _objectsFromForm;
        /// <summary>
        /// Метод, считывающий или возвращающий строку объектов
        /// </summary>
        public string ObjectsFromForm
        {
            get { return _objectsFromForm; }
            set
            {
                Check(value);
                _objectsFromForm = value;
            }
        }

        /// <summary>
        /// Первый объект отношения
        /// </summary>
        private string _firstObject;
        /// <summary>
        /// Метод, считывающий или возвращающий первый объект отношения
        /// </summary>
        public string FirstObject
        {
            get { return _firstObject; }
            set
            {

                Check(value);
                _firstObject = value;
            }
        }

        /// <summary>
        /// Второй объект отношения
        /// </summary>
        private string _secondObject;
        /// <summary>
        /// Метод, считывающий или возвращающий второй объект отношения
        /// </summary>
        public string SecondObject
        {
            get { return _secondObject; }
            set
            {
                Check(value);
                _secondObject = value;
            }
        }

        /// <summary>
        /// Третий объект отношения
        /// </summary>
        private string _thirdObject;
        /// <summary>
        /// Метод, считывающий или возвращающий третий объект отношения
        /// </summary>
        public string ThirdObgect
        {
            get { return _thirdObject; }
            set
            {
                Check(value);
                _thirdObject = value;
            }
        }

        /// <summary>
        /// Метод, делающий проверку на нужные символы
        /// </summary>
        /// <para name = "checkVar">Проверяемая переменная</para>
        private void Check(string checkVar)
        {
            //Переменные для проверки
            char firstSymbol = 'З';
            char secondSymbol = 'С';
            char thirdSymbol = 'К';

            //Если в проверяемой переменной нет нужных символов, то делается исключение
            if((checkVar.IndexOf(firstSymbol) < 0) && (checkVar.IndexOf(secondSymbol) < 0) && (checkVar.IndexOf(thirdSymbol) < 0))
            {
                throw new ArgumentException("Переменная не содержит символов З, С и К");
            }
        }

    }
}
