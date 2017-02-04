namespace DB_Project
{
    partial class AddMovieForm
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
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonAddMovie = new System.Windows.Forms.Button();
            this.buttonUpdateCat = new System.Windows.Forms.Button();
            this.buttonDeleteCat = new System.Windows.Forms.Button();
            this.buttonAddCategory = new System.Windows.Forms.Button();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.comboBoxMin = new System.Windows.Forms.ComboBox();
            this.comboBoxSec = new System.Windows.Forms.ComboBox();
            this.comboBoxHour = new System.Windows.Forms.ComboBox();
            this.textBoxLink = new System.Windows.Forms.TextBox();
            this.labelLInk = new System.Windows.Forms.Label();
            this.labelCategory = new System.Windows.Forms.Label();
            this.labelDuration = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(234, 201);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(115, 51);
            this.buttonExit.TabIndex = 31;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonAddMovie
            // 
            this.buttonAddMovie.Location = new System.Drawing.Point(63, 201);
            this.buttonAddMovie.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddMovie.Name = "buttonAddMovie";
            this.buttonAddMovie.Size = new System.Drawing.Size(115, 51);
            this.buttonAddMovie.TabIndex = 30;
            this.buttonAddMovie.Text = "Add Movie";
            this.buttonAddMovie.UseVisualStyleBackColor = true;
            this.buttonAddMovie.Click += new System.EventHandler(this.buttonAddMovie_Click);
            // 
            // buttonUpdateCat
            // 
            this.buttonUpdateCat.Location = new System.Drawing.Point(149, 138);
            this.buttonUpdateCat.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUpdateCat.Name = "buttonUpdateCat";
            this.buttonUpdateCat.Size = new System.Drawing.Size(131, 36);
            this.buttonUpdateCat.TabIndex = 29;
            this.buttonUpdateCat.Text = "Update Category";
            this.buttonUpdateCat.UseVisualStyleBackColor = true;
            this.buttonUpdateCat.Click += new System.EventHandler(this.buttonUpdateCat_Click);
            // 
            // buttonDeleteCat
            // 
            this.buttonDeleteCat.Location = new System.Drawing.Point(284, 138);
            this.buttonDeleteCat.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDeleteCat.Name = "buttonDeleteCat";
            this.buttonDeleteCat.Size = new System.Drawing.Size(131, 36);
            this.buttonDeleteCat.TabIndex = 28;
            this.buttonDeleteCat.Text = "Delete Category";
            this.buttonDeleteCat.UseVisualStyleBackColor = true;
            this.buttonDeleteCat.Click += new System.EventHandler(this.buttonDeleteCat_Click);
            // 
            // buttonAddCategory
            // 
            this.buttonAddCategory.Location = new System.Drawing.Point(14, 138);
            this.buttonAddCategory.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddCategory.Name = "buttonAddCategory";
            this.buttonAddCategory.Size = new System.Drawing.Size(131, 37);
            this.buttonAddCategory.TabIndex = 27;
            this.buttonAddCategory.Text = "Add new category";
            this.buttonAddCategory.UseVisualStyleBackColor = true;
            this.buttonAddCategory.Click += new System.EventHandler(this.buttonAddCategory_Click);
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(121, 110);
            this.comboBoxCategory.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxCategory.MaxDropDownItems = 100;
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(294, 24);
            this.comboBoxCategory.TabIndex = 26;
            this.comboBoxCategory.ValueMember = "CategoryName";
            this.comboBoxCategory.DropDown += new System.EventHandler(this.comboBoxCategory_DropDown);
            // 
            // comboBoxMin
            // 
            this.comboBoxMin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMin.FormattingEnabled = true;
            this.comboBoxMin.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.comboBoxMin.Location = new System.Drawing.Point(220, 50);
            this.comboBoxMin.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxMin.Name = "comboBoxMin";
            this.comboBoxMin.Size = new System.Drawing.Size(95, 24);
            this.comboBoxMin.TabIndex = 25;
            // 
            // comboBoxSec
            // 
            this.comboBoxSec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSec.FormattingEnabled = true;
            this.comboBoxSec.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.comboBoxSec.Location = new System.Drawing.Point(320, 50);
            this.comboBoxSec.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxSec.Name = "comboBoxSec";
            this.comboBoxSec.Size = new System.Drawing.Size(95, 24);
            this.comboBoxSec.TabIndex = 24;
            // 
            // comboBoxHour
            // 
            this.comboBoxHour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHour.FormattingEnabled = true;
            this.comboBoxHour.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.comboBoxHour.Location = new System.Drawing.Point(121, 50);
            this.comboBoxHour.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxHour.Name = "comboBoxHour";
            this.comboBoxHour.Size = new System.Drawing.Size(95, 24);
            this.comboBoxHour.TabIndex = 23;
            // 
            // textBoxLink
            // 
            this.textBoxLink.Location = new System.Drawing.Point(121, 78);
            this.textBoxLink.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxLink.Name = "textBoxLink";
            this.textBoxLink.Size = new System.Drawing.Size(294, 28);
            this.textBoxLink.TabIndex = 22;
            // 
            // labelLInk
            // 
            this.labelLInk.AutoSize = true;
            this.labelLInk.Location = new System.Drawing.Point(11, 81);
            this.labelLInk.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLInk.Name = "labelLInk";
            this.labelLInk.Size = new System.Drawing.Size(78, 16);
            this.labelLInk.TabIndex = 21;
            this.labelLInk.Text = "Movie Link";
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(11, 112);
            this.labelCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(65, 16);
            this.labelCategory.TabIndex = 20;
            this.labelCategory.Text = "Category";
            // 
            // labelDuration
            // 
            this.labelDuration.AutoSize = true;
            this.labelDuration.Location = new System.Drawing.Point(11, 53);
            this.labelDuration.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDuration.Name = "labelDuration";
            this.labelDuration.Size = new System.Drawing.Size(108, 16);
            this.labelDuration.TabIndex = 19;
            this.labelDuration.Text = "Movie Duration";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(121, 17);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(294, 28);
            this.textBoxName.TabIndex = 18;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(11, 20);
            this.labelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(90, 16);
            this.labelName.TabIndex = 17;
            this.labelName.Text = "Movie Name";
            // 
            // AddMovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 259);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonAddMovie);
            this.Controls.Add(this.buttonUpdateCat);
            this.Controls.Add(this.buttonDeleteCat);
            this.Controls.Add(this.buttonAddCategory);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.comboBoxMin);
            this.Controls.Add(this.comboBoxSec);
            this.Controls.Add(this.comboBoxHour);
            this.Controls.Add(this.textBoxLink);
            this.Controls.Add(this.labelLInk);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.labelDuration);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Name = "AddMovieForm";
            this.Text = "AddMovieForm";
            this.Load += new System.EventHandler(this.AddMovieForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonAddMovie;
        private System.Windows.Forms.Button buttonUpdateCat;
        private System.Windows.Forms.Button buttonDeleteCat;
        private System.Windows.Forms.Button buttonAddCategory;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.ComboBox comboBoxMin;
        private System.Windows.Forms.ComboBox comboBoxSec;
        private System.Windows.Forms.ComboBox comboBoxHour;
        private System.Windows.Forms.TextBox textBoxLink;
        private System.Windows.Forms.Label labelLInk;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label labelDuration;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
    }
}