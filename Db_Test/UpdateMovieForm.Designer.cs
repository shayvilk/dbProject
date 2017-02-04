namespace DB_Project
{
    partial class UpdateMovieForm
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
            this.buttonSave = new System.Windows.Forms.Button();
            this.comboBoxCategoryName = new System.Windows.Forms.ComboBox();
            this.comboBoxMin = new System.Windows.Forms.ComboBox();
            this.comboBoxSec = new System.Windows.Forms.ComboBox();
            this.comboBoxHour = new System.Windows.Forms.ComboBox();
            this.textBoxLink = new System.Windows.Forms.TextBox();
            this.labelLInk = new System.Windows.Forms.Label();
            this.labelCategory = new System.Windows.Forms.Label();
            this.labelDuration = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxNewName = new System.Windows.Forms.TextBox();
            this.labelNewName = new System.Windows.Forms.Label();
            this.comboBoxMovieName = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(52, 180);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(122, 39);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Save Changes";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // comboBoxCategoryName
            // 
            this.comboBoxCategoryName.DisplayMember = "CategoryName";
            this.comboBoxCategoryName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategoryName.FormattingEnabled = true;
            this.comboBoxCategoryName.Location = new System.Drawing.Point(134, 139);
            this.comboBoxCategoryName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxCategoryName.MaxDropDownItems = 100;
            this.comboBoxCategoryName.Name = "comboBoxCategoryName";
            this.comboBoxCategoryName.Size = new System.Drawing.Size(237, 24);
            this.comboBoxCategoryName.TabIndex = 36;
            this.comboBoxCategoryName.ValueMember = "CategoryName";
            this.comboBoxCategoryName.DropDown += new System.EventHandler(this.comboBoxCategoryName_DropDown);
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
            this.comboBoxMin.Location = new System.Drawing.Point(215, 81);
            this.comboBoxMin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxMin.Name = "comboBoxMin";
            this.comboBoxMin.Size = new System.Drawing.Size(75, 24);
            this.comboBoxMin.TabIndex = 35;
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
            this.comboBoxSec.Location = new System.Drawing.Point(296, 80);
            this.comboBoxSec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxSec.Name = "comboBoxSec";
            this.comboBoxSec.Size = new System.Drawing.Size(75, 24);
            this.comboBoxSec.TabIndex = 34;
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
            this.comboBoxHour.Location = new System.Drawing.Point(134, 81);
            this.comboBoxHour.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxHour.Name = "comboBoxHour";
            this.comboBoxHour.Size = new System.Drawing.Size(75, 24);
            this.comboBoxHour.TabIndex = 33;
            // 
            // textBoxLink
            // 
            this.textBoxLink.Font = new System.Drawing.Font("Forte", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLink.Location = new System.Drawing.Point(134, 110);
            this.textBoxLink.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxLink.Name = "textBoxLink";
            this.textBoxLink.Size = new System.Drawing.Size(237, 25);
            this.textBoxLink.TabIndex = 32;
            // 
            // labelLInk
            // 
            this.labelLInk.AutoSize = true;
            this.labelLInk.Location = new System.Drawing.Point(14, 113);
            this.labelLInk.Name = "labelLInk";
            this.labelLInk.Size = new System.Drawing.Size(78, 16);
            this.labelLInk.TabIndex = 31;
            this.labelLInk.Text = "Movie Link";
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(14, 142);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(65, 16);
            this.labelCategory.TabIndex = 30;
            this.labelCategory.Text = "Category";
            // 
            // labelDuration
            // 
            this.labelDuration.AutoSize = true;
            this.labelDuration.Location = new System.Drawing.Point(14, 84);
            this.labelDuration.Name = "labelDuration";
            this.labelDuration.Size = new System.Drawing.Size(108, 16);
            this.labelDuration.TabIndex = 29;
            this.labelDuration.Text = "Movie Duration";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 20);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(163, 16);
            this.labelName.TabIndex = 27;
            this.labelName.Text = "Choose Movie to update";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(199, 180);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(122, 39);
            this.buttonCancel.TabIndex = 37;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textBoxNewName
            // 
            this.textBoxNewName.Font = new System.Drawing.Font("Forte", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNewName.Location = new System.Drawing.Point(182, 47);
            this.textBoxNewName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNewName.Name = "textBoxNewName";
            this.textBoxNewName.Size = new System.Drawing.Size(189, 25);
            this.textBoxNewName.TabIndex = 39;
            // 
            // labelNewName
            // 
            this.labelNewName.AutoSize = true;
            this.labelNewName.Location = new System.Drawing.Point(12, 48);
            this.labelNewName.Name = "labelNewName";
            this.labelNewName.Size = new System.Drawing.Size(128, 16);
            this.labelNewName.TabIndex = 38;
            this.labelNewName.Text = "Movie\'s new name:";
            // 
            // comboBoxMovieName
            // 
            this.comboBoxMovieName.DisplayMember = "MovieName";
            this.comboBoxMovieName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMovieName.FormattingEnabled = true;
            this.comboBoxMovieName.Location = new System.Drawing.Point(182, 17);
            this.comboBoxMovieName.Name = "comboBoxMovieName";
            this.comboBoxMovieName.Size = new System.Drawing.Size(189, 24);
            this.comboBoxMovieName.TabIndex = 40;
            this.comboBoxMovieName.ValueMember = "MovieName";
            this.comboBoxMovieName.SelectionChangeCommitted += new System.EventHandler(this.comboBoxMovieName_SelectionChangeCommitted);
            // 
            // UpdateMovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 223);
            this.Controls.Add(this.comboBoxMovieName);
            this.Controls.Add(this.textBoxNewName);
            this.Controls.Add(this.labelNewName);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.comboBoxCategoryName);
            this.Controls.Add(this.comboBoxMin);
            this.Controls.Add(this.comboBoxSec);
            this.Controls.Add(this.comboBoxHour);
            this.Controls.Add(this.textBoxLink);
            this.Controls.Add(this.labelLInk);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.labelDuration);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonSave);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UpdateMovieForm";
            this.Text = "UpdateMovieForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.ComboBox comboBoxCategoryName;
        private System.Windows.Forms.ComboBox comboBoxMin;
        private System.Windows.Forms.ComboBox comboBoxSec;
        private System.Windows.Forms.ComboBox comboBoxHour;
        private System.Windows.Forms.TextBox textBoxLink;
        private System.Windows.Forms.Label labelLInk;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label labelDuration;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxNewName;
        private System.Windows.Forms.Label labelNewName;
        private System.Windows.Forms.ComboBox comboBoxMovieName;
    }
}