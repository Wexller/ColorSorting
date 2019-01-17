using System;
using System.Windows.Forms;

namespace ColorSorting
{
    public partial class ColorSortingForm : Form
    {
        /// <summary>
        /// Параметры данных
        /// </summary>
        private Data _dataStorage = new Data();

        /// <summary>
        /// Параметры сортировки
        /// </summary>
        private Sorting _sortingObjects = new Sorting();
       
        
        /// <summary>
        /// Конструктор формы
        /// </summary>
        public ColorSortingForm()
        {
            InitializeComponent();

            //Установка значений ComboBoxes по умолчанию
            FirstObfectColor.SelectedIndex = 0;
            SecondObjectColor.SelectedIndex = 1;
            ThirdObjectColor.SelectedIndex = 2;
        }

        /// <summary>
        /// Метод, записывающий данные
        /// </summary>
        /// <param name="dataObject">Ссылка на объект класса Data</param>
        /// <param name="textFromField">Строка объектов</param>
        /// <param name="firstColor">Первый цвет отношения</param>
        /// <param name="secondColor">Второй цвет отношения</param>
        /// <param name="thirdColor">Третий цвет отношения</param>
        public void SetData(Data dataObject, string textFromField, string firstColor, string secondColor, string thirdColor)
        {
            //Запись данных из полей в Data
            dataObject.ObjectsFromForm = textFromField;
            dataObject.FirstObject = firstColor;
            dataObject.SecondObject = secondColor;
            dataObject.ThirdObgect = thirdColor;
        }

        /// <summary>
        /// Метод, проверяющий правильность ввода полей отношений
        /// </summary>
        /// <param name="firstObject">Первый объект отношения</param>
        /// <param name="firstObject">Второй объект отношения</param>
        /// <param name="firstObject">Третий объект отношения</param>
        public bool CheckObjectColors(int firstObject, int secondObject, int thirdObject)
        {
            if((firstObject != secondObject) &&
               (firstObject != thirdObject) &&
               (secondObject != thirdObject))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Нельзя выбирать одинаковые отношения! Исправьте отношения", "Ошибка");
                return false;
            }
        }

        /// <summary>
        /// Метод, проверяющий поле ввода на пустоту
        /// </summary>
        public bool CheckObjectsField(string checkedText)
        {
            if (checkedText != "")
            {
                return true;
            }
            else
            {
                MessageBox.Show("Нельзя оставлять поле пустым! Заполните поле", "Ошибка");
                return false;
            }
        }

        /// <summary>
        /// Сортировка объектов
        /// </summary>
        /// <param name="sender">Отправитель события</param>
        /// <param name="e">Параметры</param>
        private void SortButton_Click(object sender, EventArgs e)
        {

            //Если поле заполенено и нет одинаковых отношений, то записывам данные и выполняем сортировку с записью в поле вывода
            if (CheckObjectsField(ObjectsField.Text) && CheckObjectColors(FirstObfectColor.SelectedIndex, SecondObjectColor.SelectedIndex, ThirdObjectColor.SelectedIndex))
             {
                    SetData(_dataStorage, ObjectsField.Text, FirstObfectColor.Text, SecondObjectColor.Text, ThirdObjectColor.Text);
                    ResultBox.Text = _sortingObjects.ObjectsSorting(_dataStorage.ObjectsFromForm, _dataStorage.FirstObject, _dataStorage.SecondObject, _dataStorage.ThirdObgect);
             }
                       
        }

        /// <summary>
        /// Закрытие программы
        /// </summary>
        /// <param name="sender">Отправитель события</param>
        /// <param name="e">Параметры</param>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Вводимые символы в поле набора объетов
        /// </summary>
        /// <param name="sender">Отправитель события</param>
        /// <param name="e">Параметры</param>
        private void ObjectsField_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Если допустимых символов нет, то ввод запрещен
            if (e.KeyChar != 'З' && e.KeyChar != 'С' && e.KeyChar != 'К')
                e.Handled = true;
        }

        /// <summary>
        /// Отчистка поля набора объектов
        /// </summary>
        /// <param name="sender">Отправитель события</param>
        /// <param name="e">Параметры</param>
        private void CleanObjectsField_Click(object sender, EventArgs e)
        {
            ObjectsField.Clear();
        }

        /// <summary>
        /// Добавить "З" в поле набора объетов
        /// </summary>
        /// <param name="sender">Отправитель события</param>
        /// <param name="e">Параметры</param>
        private void AddGreenButton_Click(object sender, EventArgs e)
        {
            ObjectsField.Text = ObjectsField.Text + "З";
        }

        /// Добавить "С" в поле набора объетов
        /// </summary>
        /// <param name="sender">Отправитель события</param>
        /// <param name="e">Параметры</param>
        private void AddBlueButton_Click(object sender, EventArgs e)
        {
            ObjectsField.Text = ObjectsField.Text + "С";
        }

        /// Добавить "К" в поле набора объетов
        /// </summary>
        /// <param name="sender">Отправитель события</param>
        /// <param name="e">Параметры</param>
        private void AddRedButton_Click(object sender, EventArgs e)
        {
            ObjectsField.Text = ObjectsField.Text + "К";
        }

    }
}
