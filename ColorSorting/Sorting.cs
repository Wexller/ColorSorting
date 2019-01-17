namespace ColorSorting
{
    class Sorting
    {
        /// <summary>
        /// Поле объектов для сортировки
        /// </summary>
        private string _objects;

        /// <summary>
        /// Зеленая переменная отношения
        /// </summary>
        private string _greenObject;

        /// <summary>
        /// Синяя переменная отношения
        /// </summary>
        private string _blueObject;

        /// <summary>
        /// Красная переменная отношения
        /// </summary>
        private string _redObject;

        /// <summary>
        /// Позиия зелёной переменной отношения
        /// </summary>
        private int _greenObjectPosition;

        /// <summary>
        /// Позиия синей переменной отношения
        /// </summary>
        private int _blueObjectPosition;

        /// <summary>
        /// Позиия красной переменной отношения
        /// </summary>
        private int _redObjectPosition;

        /// <summary>
        /// Метод, переносящий значения объеков в поле класса
        /// </summary>
        /// <param name="objects">Переменная объектов</param>
        private void SetObjects(string objects)
        {
            _objects = objects;
        }

        /// <summary>
        /// Метод, переносящий отношения в поля класса
        /// </summary>
        /// <param name="green">Зеленая переменная отношения</param>
        /// <param name="blue">Синяя переменная отношения</param>
        /// <param name="red">Красная переменная отношения</param>
        private void SetColorsOfObjects(string green, string blue, string red)
        {
            _greenObject = green;
            _blueObject = blue;
            _redObject = red;
        }
        
        /// <summary>
        /// Метод, опеределяющий заданное условие сортировки
        /// </summary>
        /// <param name="firstObject">Первая определяющая переменная</param>
        /// <param name="secondObject">Вторая определяющая переменная</param>
        /// <param name="thirdObject">Третья определяющая переменная</param>
        private void GetCondition(string firstObject, string secondObject, string thirdObject)
        {
            //Начальное значение позиции
            int posotion = 1;

            GetConditionHelper(firstObject, posotion++);
            GetConditionHelper(secondObject, posotion++);
            GetConditionHelper(thirdObject, posotion);

        }

        /// <summary>
        /// Метод, помогающий опеределить заданное условие сортировки
        /// </summary>
        /// <param name="checkObject">Текущая определяющая переменная</param>
        /// <param name="position">Позиция переменной</param>
        private void GetConditionHelper(string checkObject, int position)
        {
            switch (checkObject)
            {
                case "З":
                    _greenObjectPosition = position;
                    break;
                case "С":
                    _blueObjectPosition = position;
                    break;
                case "К":
                    _redObjectPosition = position;
                    break;
            }
        }
        
        /// <summary>
        /// Метод, проверяющий цвет объекта
        /// </summary>
        /// <param name="chekingObject">Проверяемый цвет</param>
        private int CheckObjectColor(char chekingObject)
        {
            //Большое значение для остальных объектов
            int bigValue = 100;

            //Если есть совпадение, то возвращаем позицию отношения
            switch (chekingObject)
            {
                case 'З': return _greenObjectPosition;
                case 'С': return _blueObjectPosition;
                case 'К': return _redObjectPosition;
            }

            return bigValue;
        }
        
        /// <summary>
        /// Метод сортировки, возвращающий результат в виде строки
        /// </summary>
        /// <param name="sortingObjects">Полученная строка</param>
        /// <param name="firstColor">Полученная первая определяющая отношение переменная</param>
        /// <param name="secondColor">Полученная вторая определяющая отношение переменная</param>
        /// <param name="thirdColor">Полученная третья определяющая отношение переменная</param>
        public string ObjectsSorting(string sortingObjects, string firstColor, string secondColor, string thirdColor)
        {
            
            //Размерность массива-помощника
            int sizeOfArrayHelper = 1;

            //Перенос значений в поля класса
            SetObjects(sortingObjects);
            SetColorsOfObjects(firstColor, secondColor, thirdColor);

            //Перевод строки в массив
            char[] objectsArray = _objects.ToCharArray();

            //Создание вспомогательного массива
            char[] arrayHelper = new char[sizeOfArrayHelper];

            //Определяем условие сортировки
            GetCondition(firstColor, secondColor, thirdColor);

            //Сортировка методом "Пузырька"
            for (int i = 0; i < _objects.Length - 1; i++)
            {
                for (int j = i + 1 ; j < _objects.Length; j++)
                {
                    //Если значение текущей позиции больше следующей, то меняем их местами
                    if(CheckObjectColor(objectsArray[i]) > CheckObjectColor(objectsArray[j]))
                    {
                        arrayHelper[0] = objectsArray[i];
                        objectsArray[i] = objectsArray[j];
                        objectsArray[j] = arrayHelper[0];
                    }
                }
            }

            //Перевод массива символов в строку
            string finalText = new string(objectsArray);

            //Возвращаем результат сортировки
            return finalText;
        }

    }
}
