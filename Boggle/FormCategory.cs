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
    public partial class FormCategory : Form
    {
        public FormCategory()
        {
            InitializeComponent();
        }

        private void buttonAnimals_Click(object sender, EventArgs e)
        {
            FormGameAnimals form = new FormGameAnimals();
            form.ShowDialog(this);
        }

        private void buttonItems_Click(object sender, EventArgs e)
        {
            FormGameItems form = new FormGameItems();
            form.ShowDialog(this);
        }

        private void buttonFood_Click(object sender, EventArgs e)
        {
            FormGameFood form = new FormGameFood();
            form.ShowDialog(this);
        }

        private void FormCategory_Load(object sender, EventArgs e)
        {

        }
    }
}
