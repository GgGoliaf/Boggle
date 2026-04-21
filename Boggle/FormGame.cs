using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Boggle
{
    public partial class FormGame : Form
    {
        public FormGame()
        {
            InitializeComponent();
            MakeTransparent();
        }

        void MakeTransparent()
        {
            labelGameNameInMenu.Parent = pictureBoxMenuImage; // сделать label прозрачным
            labelGameNameInMenu.BackColor = Color.Transparent;
            buttonStartGameInMenu.Parent = pictureBoxMenuImage; // сделать button прозрачным
            buttonStartGameInMenu.BackColor = Color.Transparent;
            buttonAboutTheGame.Parent = pictureBoxMenuImage; // сделать button прозрачным
            buttonAboutTheGame.BackColor = Color.Transparent;
        }

        private void FormGame_Load(object sender, EventArgs e)
        {

        }

        private void buttonStartGameInMenu_Click(object sender, EventArgs e)
        {
            FormCategory form = new FormCategory();
            form.ShowDialog(this);

        }

        private void labelGameNameInMenu_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonAboutTheGame_Click(object sender, EventArgs e)
        {
            FormDevelopment form = new FormDevelopment();
            form.ShowDialog(this);
        }

        private void pictureBoxMenuImage_Click(object sender, EventArgs e)
        {

        }
    }
}
