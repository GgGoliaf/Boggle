using System;
using System.Collections.Generic;

namespace Boggle
{
    public class WordOnField
    {
        public List<Cell> cells = new List<Cell>();
        public string word;

        public WordOnField(string word, int startX, int startY, bool isHorizontal)
        {
            this.word = word;
            List<string> letters = ParseWord(word);

            for (int i = 0; i < letters.Count; i++)
            {
                int x = startX;
                int y = startY;

                if (isHorizontal)
                    x = startX + i;
                else
                    y = startY + i;

                Cell c = new Cell(x, y, letters[i]);
                cells.Add(c);
            }
        }

        private List<string> ParseWord(string input)
        {
            List<string> result = new List<string>();
            string[] digraphs = { "гъ", "дж", "дз", "къ", "хъ", "цъ", "чъ", "тъ", "пъ" };
            int i = 0;

            while (i < input.Length)
            {
                if (i < input.Length - 1)
                {
                    string pair = input.Substring(i, 2).ToLower();
                    if (Array.Exists(digraphs, d => d == pair))
                    {
                        result.Add(input.Substring(i, 2)); // Забираем диграф целиком
                        i += 2;
                        continue;
                    }
                }
                result.Add(input[i].ToString()); // Обычная буква
                i++;
            }
            return result;
        }
    }
}
