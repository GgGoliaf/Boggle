using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boggle
{
    public partial class FormGameItems : Form
    {
        Color[] wordColors = { Color.LightGreen, Color.LightBlue, Color.Orange, Color.Pink, Color.Cyan, Color.YellowGreen,Color.Plum};

        string[] dictionary = { "ахстон", "хур", "бæлас", "стъалы", "арт", "арв", "дымгæ",};
        string[] foundWords = new string[10];
        int correctWordCount = 0;

        List<DataGridViewCell> selectedCells = new List<DataGridViewCell>(); // Список для хранения выбранных ячеек и сбора слова

        int timeLeft = 180;

        public FormGameItems()
        {
            InitializeComponent();
            FillField();
        }
        void StartGame()
        {
            timeLeft = 180;
            labelTimeInItems.Text = "3:00";
            timer1.Start();
        }

        void FillField()
        {
            string[] letters = {
                "с", "а", "л", "æ", "б",
                "у", "х", "с", "тъ", "а",
                "р", "с", "а", "ы", "л",
                "о", "т", "р", "в", "æ",
                "н", "д", "ы", "м", "г"
            };
            int count = 0;

            for (int row = 0; row < 5; row++) // 5 строк
            {
                dataGridViewFieldItems.Rows.Add();
                for (int column = 0; column < 5; column++) // 5 столбцов
                {
                    memoryColors[dataGridViewFieldItems[column, row]] = Color.White; // - начальный цвет для ячейки
                    if (count < letters.Length)
                    {
                        dataGridViewFieldItems[column, row].Value = letters[count];
                        count++;
                    }
                }
            }
        }

        private void FormGameItems_Load(object sender, EventArgs e)
        {
            //dataGridViewFieldItems.Rows.Add(5);
            StartGame();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft--;
                int minutes = timeLeft / 60;
                int seconds = timeLeft % 60;

                labelTimeInItems.Text = $"{minutes}:{seconds:D2}"; //D2 добавляет "0" перед цифрой, если она одна
            }
            else
            {
                panelGameOver.Visible = true;
                panelKost.Visible = true;
                timer1.Stop();
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void SelectCell(DataGridViewCell cell)
        {
            cell.Style.BackColor = Color.Yellow;
            selectedCells.Add(cell);
        }

        private void dataGridViewFieldItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell clickedCell = dataGridViewFieldItems[e.ColumnIndex, e.RowIndex]; // нажатая ячейка

            if (selectedCells.Count == 0)
            {
                SelectCell(clickedCell);
                dataGridViewFieldItems.CurrentCell = null; //снять состояние активности с текущей ячейки

            }

            // проверка на то, последняя ли буква в сборке
            else if (selectedCells.Contains(clickedCell))
            {
                if (clickedCell == selectedCells.Last())
                {
                    // Вместо белого берем цвет из памяти

                    if (memoryColors.ContainsKey(clickedCell))
                    {
                        clickedCell.Style.BackColor = memoryColors[clickedCell];
                        clickedCell.Style.SelectionBackColor = memoryColors[clickedCell];
                    }
                    else
                    {
                        clickedCell.Style.BackColor = Color.White;
                        clickedCell.Style.SelectionBackColor = Color.White;
                    }

                    selectedCells.Remove(clickedCell);
                }
            }

            else
            {
                // узнаем рядом ли выделенная буквы с последней нажатой через разночть индексов

                DataGridViewCell lastCell = selectedCells.Last();
                int rowDiff = Math.Abs(lastCell.RowIndex - clickedCell.RowIndex);
                int colDiff = Math.Abs(lastCell.ColumnIndex - clickedCell.ColumnIndex);

                if ((rowDiff == 1 && colDiff == 0) || (rowDiff == 0 && colDiff == 1))
                {
                    SelectCell(clickedCell);
                }
                else
                {
                    MessageBox.Show("Можно выбирать только соседние буквы по горизонтали и вертикали");
                }
            }
            dataGridViewFieldItems.CurrentCell = null; // убирает системное выделение
        }

        private void buttonCheckWordInItems_Click(object sender, EventArgs e)
        {
            string currentWord = "";
            foreach (var cell in selectedCells)
            {
                currentWord += cell.Value.ToString();
            }

            // проверка массива слов
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
                listBoxFoundWords.Items.Add(currentWord);
                selectedCells.Clear();

                CheckForWin();
            }
            else
            {
                // Если слова нет в словаре
                MessageBox.Show("Такого слова нет!");
                RestoreColorsFromMemory();
            }

        }
        Dictionary<DataGridViewCell, Color> memoryColors = new Dictionary<DataGridViewCell, Color>(); // словарь с сохраненными цветами
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
                panelWin.Visible = true;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
