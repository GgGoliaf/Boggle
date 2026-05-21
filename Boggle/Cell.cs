
namespace Boggle
{
    public class Cell
    {
        public int X; 
        public int Y;
        public string Letter;

        public Cell(int x, int y, string letter)
        {
            X = x;
            Y = y;
            Letter = letter;
        }
    }
}
