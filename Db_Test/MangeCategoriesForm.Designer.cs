namespace DB_Project
{
    partial class MangeCategoriesForm
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
            this.buttonDelCAtegory = new System.Windows.Forms.Button();
            this.buttonUpdateCat = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCatLIst = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDelCAtegory
            // 
            this.buttonDelCAtegory.Location = new System.Drawing.Point(238, 12);
            this.buttonDelCAtegory.Name = "buttonDelCAtegory";
            this.buttonDelCAtegory.Size = new System.Drawing.Size(107, 69);
            this.buttonDelCAtegory.TabIndex = 7;
            this.buttonDelCAtegory.Text = "Delete category";
            this.buttonDelCAtegory.UseVisualStyleBackColor = true;
            this.buttonDelCAtegory.Click += new System.EventHandler(this.buttonDelCAtegory_Click);
            // 
            // buttonUpdateCat
            // 
            this.buttonUpdateCat.Location = new System.Drawing.Point(125, 12);
            this.buttonUpdateCat.Name = "buttonUpdateCat";
            this.buttonUpdateCat.Size = new System.Drawing.Size(107, 69);
            this.buttonUpdateCat.TabIndex = 6;
            this.buttonUpdateCat.Text = "Update category";
            this.buttonUpdateCat.UseVisualStyleBackColor = true;
            this.buttonUpdateCat.Click += new System.EventHandler(this.buttonUpdateCat_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(12, 12);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(107, 69);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "Add new category";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonCatLIst
            // 
            this.buttonCatLIst.Location = new System.Drawing.Point(351, 12);
            this.buttonCatLIst.Name = "buttonCatLIst";
            this.buttonCatLIst.Size = new System.Drawing.Size(107, 69);
            this.buttonCatLIst.TabIndex = 9;
            this.buttonCatLIst.Text = "Category list";
            this.buttonCatLIst.UseVisualStyleBackColor = true;
            this.buttonCatLIst.Click += new System.EventHandler(this.buttonCatLIst_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(464, 12);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(107, 69);
            this.buttonExit.TabIndex = 10;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // MangeCategoriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 91);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonCatLIst);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonDelCAtegory);
            this.Controls.Add(this.buttonUpdateCat);
            this.Name = "MangeCategoriesForm";
            this.Text = "MangeCategoriesForm1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDelCAtegory;
        private System.Windows.Forms.Button buttonUpdateCat;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCatLIst;
        private System.Windows.Forms.Button buttonExit;
    }
}