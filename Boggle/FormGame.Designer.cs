namespace Boggle
{
    partial class FormGame
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelGameNameInMenu = new System.Windows.Forms.Label();
            this.buttonStartGameInMenu = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.buttonAboutTheGame = new System.Windows.Forms.Button();
            this.pictureBoxMenuImage = new System.Windows.Forms.PictureBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenuImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelGameNameInMenu
            // 
            this.labelGameNameInMenu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelGameNameInMenu.AutoSize = true;
            this.labelGameNameInMenu.BackColor = System.Drawing.Color.IndianRed;
            this.labelGameNameInMenu.Font = new System.Drawing.Font("Harlow Solid Italic", 72F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGameNameInMenu.ForeColor = System.Drawing.Color.LightCoral;
            this.labelGameNameInMenu.Location = new System.Drawing.Point(190, 61);
            this.labelGameNameInMenu.Name = "labelGameNameInMenu";
            this.labelGameNameInMenu.Size = new System.Drawing.Size(322, 121);
            this.labelGameNameInMenu.TabIndex = 0;
            this.labelGameNameInMenu.Text = "Boggle";
            this.labelGameNameInMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelGameNameInMenu.Click += new System.EventHandler(this.labelGameNameInMenu_Click);
            // 
            // buttonStartGameInMenu
            // 
            this.buttonStartGameInMenu.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonStartGameInMenu.BackColor = System.Drawing.Color.IndianRed;
            this.buttonStartGameInMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonStartGameInMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStartGameInMenu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonStartGameInMenu.FlatAppearance.BorderSize = 0;
            this.buttonStartGameInMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonStartGameInMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonStartGameInMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStartGameInMenu.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStartGameInMenu.ForeColor = System.Drawing.Color.Transparent;
            this.buttonStartGameInMenu.Location = new System.Drawing.Point(250, 226);
            this.buttonStartGameInMenu.Name = "buttonStartGameInMenu";
            this.buttonStartGameInMenu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonStartGameInMenu.Size = new System.Drawing.Size(210, 92);
            this.buttonStartGameInMenu.TabIndex = 1;
            this.buttonStartGameInMenu.Text = "Играть";
            this.buttonStartGameInMenu.UseVisualStyleBackColor = false;
            this.buttonStartGameInMenu.Click += new System.EventHandler(this.buttonStartGameInMenu_Click);
            // 
            // buttonAboutTheGame
            // 
            this.buttonAboutTheGame.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonAboutTheGame.BackColor = System.Drawing.Color.IndianRed;
            this.buttonAboutTheGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAboutTheGame.FlatAppearance.BorderSize = 0;
            this.buttonAboutTheGame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonAboutTheGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonAboutTheGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAboutTheGame.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAboutTheGame.ForeColor = System.Drawing.Color.White;
            this.buttonAboutTheGame.Location = new System.Drawing.Point(309, 338);
            this.buttonAboutTheGame.Name = "buttonAboutTheGame";
            this.buttonAboutTheGame.Size = new System.Drawing.Size(80, 30);
            this.buttonAboutTheGame.TabIndex = 3;
            this.buttonAboutTheGame.Text = "О ИГРЕ";
            this.buttonAboutTheGame.UseVisualStyleBackColor = false;
            this.buttonAboutTheGame.Click += new System.EventHandler(this.buttonAboutTheGame_Click);
            // 
            // pictureBoxMenuImage
            // 
            this.pictureBoxMenuImage.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBoxMenuImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxMenuImage.Image = global::Boggle.Properties.Resources.brick_wall_branches;
            this.pictureBoxMenuImage.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxMenuImage.Name = "pictureBoxMenuImage";
            this.pictureBoxMenuImage.Size = new System.Drawing.Size(811, 450);
            this.pictureBoxMenuImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMenuImage.TabIndex = 2;
            this.pictureBoxMenuImage.TabStop = false;
            this.pictureBoxMenuImage.Click += new System.EventHandler(this.pictureBoxMenuImage_Click);
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(811, 450);
            this.Controls.Add(this.buttonAboutTheGame);
            this.Controls.Add(this.buttonStartGameInMenu);
            this.Controls.Add(this.labelGameNameInMenu);
            this.Controls.Add(this.pictureBoxMenuImage);
            this.Name = "FormGame";
            this.Text = "Ныхасджын";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenuImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelGameNameInMenu;
        private System.Windows.Forms.Button buttonStartGameInMenu;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.PictureBox pictureBoxMenuImage;
        private System.Windows.Forms.Button buttonAboutTheGame;
    }
}

