namespace Boggle
{
    partial class FormGameAnimals
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelTimeInAnimals = new System.Windows.Forms.Label();
            this.buttonCheckWordInAnimals = new System.Windows.Forms.Button();
            this.groupBoxGuessedWordsInAnimals = new System.Windows.Forms.GroupBox();
            this.listBoxFoundWords = new System.Windows.Forms.ListBox();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewFieldAnimals = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panelGameOver = new System.Windows.Forms.Panel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panelKost = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panelWin = new System.Windows.Forms.Panel();
            this.groupBoxGuessedWordsInAnimals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFieldAnimals)).BeginInit();
            this.panelGameOver.SuspendLayout();
            this.panelWin.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTimeInAnimals
            // 
            this.labelTimeInAnimals.AutoSize = true;
            this.labelTimeInAnimals.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTimeInAnimals.Location = new System.Drawing.Point(376, 17);
            this.labelTimeInAnimals.Name = "labelTimeInAnimals";
            this.labelTimeInAnimals.Size = new System.Drawing.Size(40, 20);
            this.labelTimeInAnimals.TabIndex = 1;
            this.labelTimeInAnimals.Text = "3:00";
            // 
            // buttonCheckWordInAnimals
            // 
            this.buttonCheckWordInAnimals.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCheckWordInAnimals.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCheckWordInAnimals.Location = new System.Drawing.Point(646, 339);
            this.buttonCheckWordInAnimals.Name = "buttonCheckWordInAnimals";
            this.buttonCheckWordInAnimals.Size = new System.Drawing.Size(147, 77);
            this.buttonCheckWordInAnimals.TabIndex = 5;
            this.buttonCheckWordInAnimals.Text = "Проверить";
            this.buttonCheckWordInAnimals.UseVisualStyleBackColor = true;
            this.buttonCheckWordInAnimals.Click += new System.EventHandler(this.buttonCheckWordInAnimals_Click);
            // 
            // groupBoxGuessedWordsInAnimals
            // 
            this.groupBoxGuessedWordsInAnimals.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBoxGuessedWordsInAnimals.Controls.Add(this.listBoxFoundWords);
            this.groupBoxGuessedWordsInAnimals.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxGuessedWordsInAnimals.Location = new System.Drawing.Point(646, 59);
            this.groupBoxGuessedWordsInAnimals.Name = "groupBoxGuessedWordsInAnimals";
            this.groupBoxGuessedWordsInAnimals.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBoxGuessedWordsInAnimals.Size = new System.Drawing.Size(157, 241);
            this.groupBoxGuessedWordsInAnimals.TabIndex = 4;
            this.groupBoxGuessedWordsInAnimals.TabStop = false;
            this.groupBoxGuessedWordsInAnimals.Text = "  Угаданные слова";
            // 
            // listBoxFoundWords
            // 
            this.listBoxFoundWords.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxFoundWords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxFoundWords.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxFoundWords.FormattingEnabled = true;
            this.listBoxFoundWords.ItemHeight = 21;
            this.listBoxFoundWords.Location = new System.Drawing.Point(3, 20);
            this.listBoxFoundWords.Name = "listBoxFoundWords";
            this.listBoxFoundWords.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxFoundWords.Size = new System.Drawing.Size(151, 218);
            this.listBoxFoundWords.TabIndex = 0;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 60;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 60;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 59;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 60;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 60;
            // 
            // dataGridViewFieldAnimals
            // 
            this.dataGridViewFieldAnimals.AllowUserToAddRows = false;
            this.dataGridViewFieldAnimals.AllowUserToDeleteRows = false;
            this.dataGridViewFieldAnimals.AllowUserToResizeColumns = false;
            this.dataGridViewFieldAnimals.AllowUserToResizeRows = false;
            this.dataGridViewFieldAnimals.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewFieldAnimals.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewFieldAnimals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFieldAnimals.ColumnHeadersVisible = false;
            this.dataGridViewFieldAnimals.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridViewFieldAnimals.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewFieldAnimals.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewFieldAnimals.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewFieldAnimals.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewFieldAnimals.Location = new System.Drawing.Point(207, 59);
            this.dataGridViewFieldAnimals.MultiSelect = false;
            this.dataGridViewFieldAnimals.Name = "dataGridViewFieldAnimals";
            this.dataGridViewFieldAnimals.ReadOnly = true;
            this.dataGridViewFieldAnimals.RowHeadersVisible = false;
            this.dataGridViewFieldAnimals.RowTemplate.Height = 60;
            this.dataGridViewFieldAnimals.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewFieldAnimals.Size = new System.Drawing.Size(301, 301);
            this.dataGridViewFieldAnimals.TabIndex = 6;
            this.dataGridViewFieldAnimals.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFieldAnimals_CellClick);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(298, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Время:";
            // 
            // panelGameOver
            // 
            this.panelGameOver.BackColor = System.Drawing.Color.Black;
            this.panelGameOver.Controls.Add(this.buttonClose);
            this.panelGameOver.Controls.Add(this.label2);
            this.panelGameOver.Location = new System.Drawing.Point(239, 116);
            this.panelGameOver.Name = "panelGameOver";
            this.panelGameOver.Size = new System.Drawing.Size(242, 166);
            this.panelGameOver.TabIndex = 8;
            this.panelGameOver.Visible = false;
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.Black;
            this.buttonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonClose.Location = new System.Drawing.Point(63, 76);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(107, 60);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "В меню";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(20, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 39);
            this.label2.TabIndex = 0;
            this.label2.Text = "GAME OVER";
            // 
            // panelKost
            // 
            this.panelKost.Location = new System.Drawing.Point(638, 339);
            this.panelKost.Name = "panelKost";
            this.panelKost.Size = new System.Drawing.Size(162, 78);
            this.panelKost.TabIndex = 9;
            this.panelKost.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(55, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 108);
            this.label4.TabIndex = 1;
            this.label4.Text = "П";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(652, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 108);
            this.label5.TabIndex = 2;
            this.label5.Text = "А";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 65.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Yellow;
            this.label6.Location = new System.Drawing.Point(537, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 98);
            this.label6.TabIndex = 3;
            this.label6.Text = "Д";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Yellow;
            this.label7.Location = new System.Drawing.Point(415, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 108);
            this.label7.TabIndex = 4;
            this.label7.Text = "Е";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.Yellow;
            this.label8.Location = new System.Drawing.Point(301, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 108);
            this.label8.TabIndex = 5;
            this.label8.Text = "Б";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.Yellow;
            this.label9.Location = new System.Drawing.Point(175, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 108);
            this.label9.TabIndex = 6;
            this.label9.Text = "О";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.IndianRed;
            this.button1.Location = new System.Drawing.Point(299, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 83);
            this.button1.TabIndex = 7;
            this.button1.Text = "В меню";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelWin
            // 
            this.panelWin.BackColor = System.Drawing.Color.DarkSalmon;
            this.panelWin.Controls.Add(this.button1);
            this.panelWin.Controls.Add(this.label9);
            this.panelWin.Controls.Add(this.label8);
            this.panelWin.Controls.Add(this.label7);
            this.panelWin.Controls.Add(this.label6);
            this.panelWin.Controls.Add(this.label5);
            this.panelWin.Controls.Add(this.label4);
            this.panelWin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWin.Location = new System.Drawing.Point(0, 0);
            this.panelWin.Name = "panelWin";
            this.panelWin.Size = new System.Drawing.Size(815, 450);
            this.panelWin.TabIndex = 12;
            this.panelWin.Visible = false;
            // 
            // FormGameAnimals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(815, 450);
            this.Controls.Add(this.panelWin);
            this.Controls.Add(this.panelKost);
            this.Controls.Add(this.panelGameOver);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewFieldAnimals);
            this.Controls.Add(this.buttonCheckWordInAnimals);
            this.Controls.Add(this.groupBoxGuessedWordsInAnimals);
            this.Controls.Add(this.labelTimeInAnimals);
            this.Name = "FormGameAnimals";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Животные";
            this.Load += new System.EventHandler(this.FormGameAnimals_Load);
            this.groupBoxGuessedWordsInAnimals.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFieldAnimals)).EndInit();
            this.panelGameOver.ResumeLayout(false);
            this.panelGameOver.PerformLayout();
            this.panelWin.ResumeLayout(false);
            this.panelWin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTimeInAnimals;
        private System.Windows.Forms.Button buttonCheckWordInAnimals;
        private System.Windows.Forms.GroupBox groupBoxGuessedWordsInAnimals;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridView dataGridViewFieldAnimals;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelGameOver;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelKost;
        private System.Windows.Forms.ListBox listBoxFoundWords;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelWin;
    }
}