namespace Boggle
{
    partial class FormCategory
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
            this.labelSelectCategory = new System.Windows.Forms.Label();
            this.buttonAnimals = new System.Windows.Forms.Button();
            this.buttonItems = new System.Windows.Forms.Button();
            this.buttonFood = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelSelectCategory
            // 
            this.labelSelectCategory.AutoSize = true;
            this.labelSelectCategory.BackColor = System.Drawing.Color.White;
            this.labelSelectCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSelectCategory.ForeColor = System.Drawing.Color.IndianRed;
            this.labelSelectCategory.Location = new System.Drawing.Point(12, 9);
            this.labelSelectCategory.Name = "labelSelectCategory";
            this.labelSelectCategory.Size = new System.Drawing.Size(294, 31);
            this.labelSelectCategory.TabIndex = 0;
            this.labelSelectCategory.Text = "Выберите категорию";
            // 
            // buttonAnimals
            // 
            this.buttonAnimals.BackColor = System.Drawing.Color.IndianRed;
            this.buttonAnimals.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAnimals.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAnimals.ForeColor = System.Drawing.Color.Transparent;
            this.buttonAnimals.Location = new System.Drawing.Point(64, 64);
            this.buttonAnimals.Name = "buttonAnimals";
            this.buttonAnimals.Size = new System.Drawing.Size(179, 50);
            this.buttonAnimals.TabIndex = 1;
            this.buttonAnimals.Text = "Животные";
            this.buttonAnimals.UseVisualStyleBackColor = false;
            this.buttonAnimals.Click += new System.EventHandler(this.buttonAnimals_Click);
            // 
            // buttonItems
            // 
            this.buttonItems.BackColor = System.Drawing.Color.IndianRed;
            this.buttonItems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonItems.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonItems.ForeColor = System.Drawing.Color.Transparent;
            this.buttonItems.Location = new System.Drawing.Point(64, 120);
            this.buttonItems.Name = "buttonItems";
            this.buttonItems.Size = new System.Drawing.Size(179, 51);
            this.buttonItems.TabIndex = 2;
            this.buttonItems.Text = "Предметы";
            this.buttonItems.UseVisualStyleBackColor = false;
            this.buttonItems.Click += new System.EventHandler(this.buttonItems_Click);
            // 
            // buttonFood
            // 
            this.buttonFood.BackColor = System.Drawing.Color.IndianRed;
            this.buttonFood.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFood.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFood.ForeColor = System.Drawing.Color.Transparent;
            this.buttonFood.Location = new System.Drawing.Point(64, 177);
            this.buttonFood.Name = "buttonFood";
            this.buttonFood.Size = new System.Drawing.Size(179, 48);
            this.buttonFood.TabIndex = 3;
            this.buttonFood.Text = "ЕДА";
            this.buttonFood.UseVisualStyleBackColor = false;
            this.buttonFood.Click += new System.EventHandler(this.buttonFood_Click);
            // 
            // FormCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(312, 261);
            this.Controls.Add(this.buttonFood);
            this.Controls.Add(this.buttonItems);
            this.Controls.Add(this.buttonAnimals);
            this.Controls.Add(this.labelSelectCategory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.FormCategory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSelectCategory;
        private System.Windows.Forms.Button buttonAnimals;
        private System.Windows.Forms.Button buttonItems;
        private System.Windows.Forms.Button buttonFood;
    }
}