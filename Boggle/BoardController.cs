using System;
using System.Collections.Generic;

namespace Boggle
{
    public class BoardController
    {
        public string[,] Grid = new string[5, 5];
        private Random rand = new Random();

        public void GenerateField(string[] dictionary)
        {
            Grid = new string[5, 5];

            foreach (string word in dictionary)
            {
                PlaceWord(word);
            }

            FillEmpty();
        }

        private void PlaceWord(string word)
        {
            for (int attempt = 0; attempt < 111; attempt++)
            {
                bool isHorizontal = rand.Next(0, 2) == 0;

                WordOnField test = new WordOnField(word, 0, 0, isHorizontal);
                int len = test.cells.Count;

                int maxX = isHorizontal ? 5 - len : 4;
                int maxY = isHorizontal ? 4 : 5 - len;

                if (maxX < 0 || maxY < 0) continue;

                int startX = rand.Next(0, maxX + 1);
                int startY = rand.Next(0, maxY + 1);

                WordOnField finalWord = new WordOnField(word, startX, startY, isHorizontal);

                if (CheckFree(finalWord))
                {
                    foreach (Cell c in finalWord.cells)
                    {
                        Grid[c.X, c.Y] = c.Letter;
                    }
                    return;
                }
            }
        }

        private bool CheckFree(WordOnField word)
        {
            foreach (Cell c in word.cells)
            {
                if (Grid[c.X, c.Y] != null)
                    return false;
            }
            return true;
        }

        private void FillEmpty()
        {
            string[] alphabet = { "а", "æ", "б", "в", "г", "гъ", "д", "дж", "дз", "е", "ж", "з", "и", "й", "к", "къ", "л", "м", "н", "о", "п", "пъ", "р", "с", "т", "тъ", "у", "ф", "х", "хъ", "ц", "цъ", "ч", "чъ", "ш", "ы" };

            for (int x = 0; x < 5; x++)
            {
                for (int y = 0; y < 5; y++)
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
