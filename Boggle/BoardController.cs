using System;
using System.Collections.Generic;

namespace Boggle
{
    public class BoardController
    {
        // поле 7 на 7 ячеек
        public string[,] Grid = new string[7, 7];
        private Random rand = new Random();

        public void GenerateField(string[] dictionary)
        {
            bool success = false;

            while (success == false)
            {
                Grid = new string[7, 7]; // очищаем поле перед попыткой
                success = true;

                foreach (string word in dictionary)
                {
                    // пытаемся поставить слово. Если какое-то не влезло, то запускаем генерацию заново
                    if (PlaceWord(word) == false)
                    {
                        success = false;
                        break;
                    }
                }
            }

            FillEmpty(); // заполняем оставшиеся ячейки буквами
        }

        private bool PlaceWord(string word)
        {
            // создаем список всех возможных стартовых позиций на поле
            List<WordOnField> allPositions = new List<WordOnField>();

            for (int x = 0; x < 7; x++)
            {
                for (int y = 0; y < 7; y++)
                {
                    allPositions.Add(new WordOnField(word, x, y, true));  // вбок
                    allPositions.Add(new WordOnField(word, x, y, false)); // вниз
                }
            }

            // перемешиваем список позиций случайным образом
            for (int i = allPositions.Count - 1; i > 0; i--)
            {
                int j = rand.Next(i + 1);
                var temp = allPositions[i];
                allPositions[i] = allPositions[j];
                allPositions[j] = temp;
            }

            // ищем первую свободную позицию, куда слово влезло целиком
            foreach (var pos in allPositions)
            {
                if (IsInsideBoard(pos) && CheckFree(pos))
                {
                    foreach (Cell c in pos.cells)
                    {
                        Grid[c.X, c.Y] = c.Letter; // записываем буквы слова на поле
                    }
                    return true; // успешно уложили слово
                }
            }

            return false; // ни одно место на поле не подошло
        }

        // проверка не вылетело ли слово за края поля
        private bool IsInsideBoard(WordOnField word)
        {
            foreach (Cell c in word.cells)
            {
                if (c.X >= 7 || c.Y >= 7) return false; // вылетело за границы
            }
            return true;
        }

        private bool CheckFree(WordOnField word)
        {
            foreach (Cell c in word.cells)
            {
                if (Grid[c.X, c.Y] != null) return false; // клетка уже занята другим словом
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
                        Grid[x, y] = alphabet[rand.Next(alphabet.Length)]; // ставим случайную букву
                    }
                }
            }
        }
    }
}
