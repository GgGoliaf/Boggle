    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;
    using System.IO;

namespace Boggle
{
    public partial class FormField : Form
    {
        Color[] wordColors = { Color.LightGreen, Color.LightBlue, Color.Orange, Color.Pink, Color.Cyan, Color.YellowGreen };

        string[] dictionary;
        int correctWordCount = 0;
        int timeLeft = 180;

        List<DataGridViewCell> selectedCells = new List<DataGridViewCell>(); // Список кликов

        Dictionary<DataGridViewCell, Color> memoryColors = new Dictionary<DataGridViewCell, Color>(); // Память цветов ячеек

        BoardController board = new BoardController(); // uенератор поля

        public FormField(string categoryName)
        {
            InitializeComponent();

            // Загружаем нужные слова из нашего класса-словаря
            dictionary = GameDictionary.GetWords(categoryName);

            FillField();
        }
        void StartGame()
        {
            timeLeft = 180;
            labelTimeInAnimals.Text = "3:00";
            timer1.Start();
        }

        void FillField()
        {
            // Генерируем матрицу букв без пересечений слов
            board.GenerateField(dictionary);

            dataGridViewFieldAnimals.Rows.Clear();

            // Заполняем DataGridView до 6 строк и столбцов
            for (int row = 0; row < 7; row++)
            {
                dataGridViewFieldAnimals.Rows.Add();
                for (int column = 0; column < 7; column++)
                {
                    dataGridViewFieldAnimals[column, row].Value = board.Grid[column, row];
                    memoryColors[dataGridViewFieldAnimals[column, row]] = Color.White;
                }
            }
            dataGridViewFieldAnimals.CurrentCell = null;
            //счетчик оставшихся слов
            labelWordsLeft.Text = dictionary.Length.ToString();
        }

        private void FormGameAnimals_Load(object sender, EventArgs e)
        {
            //dataGridViewFieldAnimals.Rows.Add(5);
            StartGame();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft--;
                int minutes = timeLeft / 60;
                int seconds = timeLeft % 60;

                labelTimeInAnimals.Text = $"{minutes}:{seconds:D2}"; //D2 добавляет "0" перед цифрой, если она одна
            }
            else
            {
                panelGameOver.Visible = true;
                panelKost.Visible = true;
                timer1.Stop();
                SaveResult("Поражение");
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void SelectCell(DataGridViewCell cell)
        {
            cell.Style.BackColor = Color.Yellow;
            cell.Style.SelectionBackColor = Color.Yellow;
            selectedCells.Add(cell);
        }

        private void dataGridViewFieldAnimals_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            DataGridViewCell clickedCell = dataGridViewFieldAnimals[e.ColumnIndex, e.RowIndex];

            // Запрет клика, если буква уже задействована в угаданном слове (цвет в памяти не белый)
            if (memoryColors[clickedCell] != Color.White)
            {
                MessageBox.Show("Эта буква уже задействована в угаданном слове!");
                dataGridViewFieldAnimals.CurrentCell = null;
                return;
            }

            if (selectedCells.Count == 0)
            {
                SelectCell(clickedCell);
            }
            // Отмена выделения последней буквы при повторном клике
            else if (selectedCells.Contains(clickedCell))
            {
                if (clickedCell == selectedCells.Last())
                {
                    clickedCell.Style.BackColor = Color.White;
                    clickedCell.Style.SelectionBackColor = Color.White;
                    selectedCells.Remove(clickedCell);
                }
            }
            // Добавление новой буквы в цепочку (проверка соседей)
            else
            {
                DataGridViewCell lastCell = selectedCells.Last();
                int rowDiff = Math.Abs(lastCell.RowIndex - clickedCell.RowIndex);
                int colDiff = Math.Abs(lastCell.ColumnIndex - clickedCell.ColumnIndex);

                // Строго по горизонтали или вертикали
                if ((rowDiff == 1 && colDiff == 0) || (rowDiff == 0 && colDiff == 1))
                {
                    SelectCell(clickedCell);
                }
                else
                {
                    MessageBox.Show("Можно выбирать только соседние буквы по горизонтали и вертикали");
                }
            }
            dataGridViewFieldAnimals.CurrentCell = null;
        }

        private void buttonCheckWordInAnimals_Click(object sender, EventArgs e)
        {
            // собираем буквы из выделенных ячеек в одно слово
            string currentWord = "";
            foreach (var cell in selectedCells)
            {
                currentWord += cell.Value.ToString();
            }

            // проверяем, есть ли собранное слово в словаре категории
            bool isCorrect = false;
            for (int i = 0; i < dictionary.Length; i++)
            {
                if (dictionary[i] == currentWord)
                {
                    isCorrect = true;
                    break;
                }
            }

            if (isCorrect)
            {

                //Проверка на повтор

                if (listBoxFoundWords.Items.Contains(currentWord))
                {
                    MessageBox.Show("Вы уже находили это слово!");
                    RestoreColorsFromMemory(); // Возвращаем старые цвета
                    return;
                }

                // Если слово правильное и новое, то красим и сохраняем

                Color finalColor = wordColors[correctWordCount];
                correctWordCount++;

                foreach (var cell in selectedCells)
                {
                    cell.Style.BackColor = finalColor;
                    cell.Style.SelectionBackColor = finalColor;

                    memoryColors[cell] = finalColor;

                }

                // Добавляем слово в список угаданных на экране
                listBoxFoundWords.Items.Add(currentWord);
                selectedCells.Clear();

                //обновляем счетчик (всего слов минус угаданные)
                int wordsLeft = dictionary.Length - listBoxFoundWords.Items.Count;
                labelWordsLeft.Text = wordsLeft.ToString();

                CheckForWin();
            }
            else
            {
                // Если слова нет в словаре
                MessageBox.Show("Такого слова нет!");
                RestoreColorsFromMemory();
            }

        }

        void RestoreColorsFromMemory()
        {
            foreach (var cell in selectedCells)
            {
                if (memoryColors.ContainsKey(cell))
                {
                    cell.Style.BackColor = memoryColors[cell];
                    cell.Style.SelectionBackColor = memoryColors[cell];
                }
            }
            selectedCells.Clear(); // очищаем выделение для следующего слова

        }

        void CheckForWin()
        {
            if (listBoxFoundWords.Items.Count == dictionary.Length) // Если количество строк в списке найденных слов совпало с размером словаря
            {
                timer1.Stop();
                SaveResult("Победа");
                panelWin.Visible = true;
            }

        }

        void SaveResult(string status)
        {
            string filePath = "scores.txt";
            int found = listBoxFoundWords.Items.Count;
            int total = dictionary.Length;

            // Дата | Категория | Угадано | Итог
            string record = $"{DateTime.Now:dd.MM.yyyy HH:mm} | Категория: {this.Text} | Угадано слов: {found} из {total} | Результат: {status}";

            File.AppendAllText(filePath, record + Environment.NewLine);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
