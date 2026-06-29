
namespace Boggle
{
    public class Cell
    {
        public int X; // строка
        public int Y; // столбец
        public string Letter;// буква

        public Cell(int x, int y, string letter)
        {
            X = x;
            Y = y;
            Letter = letter;
        }
    }
}
