using System;
using System.Collections.Generic;

namespace Boggle
{
    public class WordOnField
    {
        public List<Cell> cells = new List<Cell>(); // список ячеек, из которых состоит слово
        public string word; // само слово

        // принимаем слово, начальное положение и направление
        public WordOnField(string word, int startX, int startY, bool isHorizontal)
        {
            this.word = word;
            List<string> letters = ParseWord(word); // режем слово на буквы

            for (int i = 0; i < letters.Count; i++)
            {
                int x = startX;
                int y = startY;

                 //если вбок, то увеличиваем X, если вниз - увеличиваем Y
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
                // если впереди еще есть буквы, проверяем пару символов
                if (i < input.Length - 1)
                {
                    string pair = input.Substring(i, 2).ToLower();
                    if (Array.Exists(digraphs, d => d == pair))
                    {
                        result.Add(input.Substring(i, 2)); // забираем диграф целиком
                        i += 2;
                        continue;
                    }
                }
                result.Add(input[i].ToString()); // иначе берем обычную одну букву
                i++;
            }
            return result;
        }
    }
}
