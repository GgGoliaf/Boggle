using System;
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
            FormField form = new FormField("animals");
            form.ShowDialog(this);
        }

        private void buttonItems_Click(object sender, EventArgs e)
        {
            FormField form = new FormField("items");
            form.ShowDialog(this);
        }

        private void buttonFood_Click(object sender, EventArgs e)
        {
            FormField form = new FormField("food");
            form.ShowDialog(this);
        }

        private void FormCategory_Load(object sender, EventArgs e)
        {

        }
    }
}
