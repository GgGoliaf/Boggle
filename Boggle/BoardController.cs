using System;
using System.Collections.Generic;

namespace Boggle
{
    public class BoardController
    {
        // Поле теперь 7 на 7 ячеек
        public string[,] Grid = new string[7, 7];
        private Random rand = new Random();

        public void GenerateField(string[] dictionary)
        {
            bool success = false;

            while (success == false)
            {
                Grid = new string[7, 7]; // Очищаем поле 7х7
                success = true;

                foreach (string word in dictionary)
                {
                    if (PlaceWord(word) == false)
                    {
                        success = false;
                        break;
                    }
                }
            }

            FillEmpty(); // Заполняем пустоту буквами
        }

        private bool PlaceWord(string word)
        {
            // Создаем список всех возможных стартовых позиций на поле
            List<WordOnField> allPositions = new List<WordOnField>();

            for (int x = 0; x < 7; x++)
            {
                for (int y = 0; y < 7; y++)
                {
                    allPositions.Add(new WordOnField(word, x, y, true));  // Вбок
                    allPositions.Add(new WordOnField(word, x, y, false)); // Вниз
                }
            }

            // Перемешиваем список позиций случайным образом
            for (int i = allPositions.Count - 1; i > 0; i--)
            {
                int j = rand.Next(i + 1);
                var temp = allPositions[i];
                allPositions[i] = allPositions[j];
                allPositions[j] = temp;
            }

            // Ищем первую свободную позицию, куда слово влезло целиком
            foreach (var pos in allPositions)
            {
                if (IsInsideBoard(pos) && CheckFree(pos))
                {
                    foreach (Cell c in pos.cells)
                    {
                        Grid[c.X, c.Y] = c.Letter;
                    }
                    return true;
                }
            }

            return false;
        }

        // Проверка: не вылетело ли слово за края поля 7х7?
        private bool IsInsideBoard(WordOnField word)
        {
            foreach (Cell c in word.cells)
            {
                if (c.X >= 7 || c.Y >= 7) return false;
            }
            return true;
        }

        private bool CheckFree(WordOnField word)
        {
            foreach (Cell c in word.cells)
            {
                if (Grid[c.X, c.Y] != null) return false;
            }
            return true;
        }

        private void FillEmpty()
        {
            string[] alphabet = { "а", "æ", "б", "в", "г", "гъ", "д", "дж", "дз", "е", "ж", "з", "и", "й", "к", "къ", "л", "м", "н", "о", "п", "пъ", "р", "с", "т", "тъ", "у", "ф", "х", "хъ", "ц", "цъ", "ч", "чъ", "ш", "ы" };

            for (int x = 0; x < 7; x++)
            {
                for (int y = 0; y < 7; y++)
                {
                    if (Grid[x, y] == null)
                    {
                        Grid[x, y] = alphabet[rand.Next(alphabet.Length)];
                    }
                }
            }
        }
    }
}
