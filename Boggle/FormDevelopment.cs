using System;
using System.IO;
using System.Windows.Forms;

namespace Boggle
{
    public partial class FormDevelopment : Form
    {
        public FormDevelopment()
        {
            InitializeComponent();
        }

        private void FormDevelopment_Load(object sender, EventArgs e)
        {
            string filePath = "scores.txt";

            // Если файл есть — читаем строки и загружаем в ListBox
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);

                foreach (string line in lines)
                {
                    listBoxHistory.Items.Add(line);
                }
            }
        }
    }
}
