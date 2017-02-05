namespace DB_Project
{
    partial class Form1
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
            this.openBrowser_btn = new System.Windows.Forms.Button();
            this.moviesListBtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridViewMovies = new System.Windows.Forms.DataGridView();
            this.Watch = new System.Windows.Forms.DataGridViewButtonColumn();
            this.manageMoviesBtn = new System.Windows.Forms.Button();
            this.manageCatagoriesBtn = new System.Windows.Forms.Button();
            this.dataGridViewCategories = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // openBrowser_btn
            // 
            this.openBrowser_btn.BackColor = System.Drawing.Color.DarkTurquoise;
            this.openBrowser_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.openBrowser_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.openBrowser_btn.Font = new System.Drawing.Font("Poor Richard", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openBrowser_btn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.openBrowser_btn.Location = new System.Drawing.Point(12, 4);
            this.openBrowser_btn.Name = "openBrowser_btn";
            this.openBrowser_btn.Size = new System.Drawing.Size(145, 33);
            this.openBrowser_btn.TabIndex = 0;
            this.openBrowser_btn.Text = "Open YouTube";
            this.openBrowser_btn.UseVisualStyleBackColor = false;
            // 
            // moviesListBtn
            // 
            this.moviesListBtn.BackColor = System.Drawing.Color.SlateBlue;
            this.moviesListBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.moviesListBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.moviesListBtn.Font = new System.Drawing.Font("Poor Richard", 10F, System.Drawing.FontStyle.Italic);
            this.moviesListBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.moviesListBtn.Location = new System.Drawing.Point(12, 41);
            this.moviesListBtn.Name = "moviesListBtn";
            this.moviesListBtn.Size = new System.Drawing.Size(145, 220);
            this.moviesListBtn.TabIndex = 0;
            this.moviesListBtn.Text = "Movies List";
            this.moviesListBtn.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkTurquoise;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(12, 274);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(145, 220);
            this.button3.TabIndex = 0;
            this.button3.Text = "Manager";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // dataGridViewMovies
            // 
            this.dataGridViewMovies.AllowUserToAddRows = false;
            this.dataGridViewMovies.AllowUserToDeleteRows = false;
            this.dataGridViewMovies.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMovies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMovies.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMovies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Watch});
            this.dataGridViewMovies.Location = new System.Drawing.Point(163, 41);
            this.dataGridViewMovies.Name = "dataGridViewMovies";
            this.dataGridViewMovies.ReadOnly = true;
            this.dataGridViewMovies.Size = new System.Drawing.Size(761, 81);
            this.dataGridViewMovies.TabIndex = 1;
            this.dataGridViewMovies.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMovies_CellContentClick_1);
            // 
            // Watch
            // 
            this.Watch.HeaderText = "Watch";
            this.Watch.Name = "Watch";
            this.Watch.ReadOnly = true;
            this.Watch.Text = "Click to watch";
            this.Watch.UseColumnTextForButtonValue = true;
            // 
            // manageMoviesBtn
            // 
            this.manageMoviesBtn.BackColor = System.Drawing.Color.DarkTurquoise;
            this.manageMoviesBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.manageMoviesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.manageMoviesBtn.Font = new System.Drawing.Font("Poor Richard", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageMoviesBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.manageMoviesBtn.Location = new System.Drawing.Point(163, 4);
            this.manageMoviesBtn.Name = "manageMoviesBtn";
            this.manageMoviesBtn.Size = new System.Drawing.Size(145, 33);
            this.manageMoviesBtn.TabIndex = 0;
            this.manageMoviesBtn.Text = "Manage Movies";
            this.manageMoviesBtn.UseVisualStyleBackColor = false;
            // 
            // manageCatagoriesBtn
            // 
            this.manageCatagoriesBtn.BackColor = System.Drawing.Color.DarkTurquoise;
            this.manageCatagoriesBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.manageCatagoriesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.manageCatagoriesBtn.Font = new System.Drawing.Font("Poor Richard", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageCatagoriesBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.manageCatagoriesBtn.Location = new System.Drawing.Point(314, 4);
            this.manageCatagoriesBtn.Name = "manageCatagoriesBtn";
            this.manageCatagoriesBtn.Size = new System.Drawing.Size(145, 33);
            this.manageCatagoriesBtn.TabIndex = 0;
            this.manageCatagoriesBtn.Text = "Manage Catagories";
            this.manageCatagoriesBtn.UseVisualStyleBackColor = false;
            // 
            // dataGridViewCategories
            // 
            this.dataGridViewCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCategories.Location = new System.Drawing.Point(164, 158);
            this.dataGridViewCategories.Name = "dataGridViewCategories";
            this.dataGridViewCategories.Size = new System.Drawing.Size(760, 150);
            this.dataGridViewCategories.TabIndex = 2;
            this.dataGridViewCategories.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCategories_CellEndEdit);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(964, 506);
            this.Controls.Add(this.dataGridViewCategories);
            this.Controls.Add(this.dataGridViewMovies);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.moviesListBtn);
            this.Controls.Add(this.manageCatagoriesBtn);
            this.Controls.Add(this.manageMoviesBtn);
            this.Controls.Add(this.openBrowser_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategories)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openBrowser_btn;
        private System.Windows.Forms.Button moviesListBtn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridViewMovies;
        private System.Windows.Forms.DataGridViewButtonColumn Watch;
        private System.Windows.Forms.Button manageMoviesBtn;
        private System.Windows.Forms.Button manageCatagoriesBtn;
        private System.Windows.Forms.DataGridView dataGridViewCategories;

    }
}