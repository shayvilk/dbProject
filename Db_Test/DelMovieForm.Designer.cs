namespace DB_Project
{
    partial class DelMovieForm
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
            this.labelChoose = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.comboBoxMovieName = new System.Windows.Forms.ComboBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelChoose
            // 
            this.labelChoose.AutoSize = true;
            this.labelChoose.Font = new System.Drawing.Font("Forte", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChoose.Location = new System.Drawing.Point(12, 15);
            this.labelChoose.Name = "labelChoose";
            this.labelChoose.Size = new System.Drawing.Size(167, 17);
            this.labelChoose.TabIndex = 3;
            this.labelChoose.Text = "Choose movie to delete";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Forte", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(231, 49);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(117, 42);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // comboBoxMovieName
            // 
            this.comboBoxMovieName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMovieName.FormattingEnabled = true;
            this.comboBoxMovieName.Location = new System.Drawing.Point(185, 12);
            this.comboBoxMovieName.Name = "comboBoxMovieName";
            this.comboBoxMovieName.Size = new System.Drawing.Size(188, 24);
            this.comboBoxMovieName.TabIndex = 1;
            this.comboBoxMovieName.ValueMember = "MovieName";
            this.comboBoxMovieName.DropDown += new System.EventHandler(this.comboBoxName_DropDown);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Forte", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(38, 49);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(117, 42);
            this.buttonDelete.TabIndex = 0;
            this.buttonDelete.Text = "Delete movie";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // DelMovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 103);
            this.Controls.Add(this.labelChoose);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.comboBoxMovieName);
            this.Controls.Add(this.buttonDelete);
            this.Name = "DelMovieForm";
            this.Text = "DelMovieForm";
            this.Load += new System.EventHandler(this.DelMovieForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.ComboBox comboBoxMovieName;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelChoose;
    }
}