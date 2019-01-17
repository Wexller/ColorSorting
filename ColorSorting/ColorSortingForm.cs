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
        private void SetData()
        {
            //Запись данных из полей в Data
            _dataStorage.ObjectsFromForm = ObjectsField.Text;    
            _dataStorage.FirstObject = FirstObfectColor.Text;
            _dataStorage.SecondObject = SecondObjectColor.Text;
            _dataStorage.ThirdObgect = ThirdObjectColor.Text;
        }

        /// <summary>
        /// Метод, проверяющий правильность ввода полей отношений
        /// </summary>
        private bool CheckObjectColors()
        {
            if((FirstObfectColor.SelectedIndex != SecondObjectColor.SelectedIndex) &&
               (FirstObfectColor.SelectedIndex != ThirdObjectColor.SelectedIndex) &&
               (SecondObjectColor.SelectedIndex != ThirdObjectColor.SelectedIndex))
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
        /// Метод, проверяющий поле ввода
        /// </summary>
        private bool CheckObjectsField()
        {
            if (ObjectsField.Text != "")
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
            if (CheckObjectsField() && CheckObjectColors())
             {
                    SetData();
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
