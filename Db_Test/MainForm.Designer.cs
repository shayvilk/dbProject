namespace DB_Project
{
    partial class MainForm
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
            this.dataGridViewMovies = new System.Windows.Forms.DataGridView();
            this.Watch = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewCategories = new System.Windows.Forms.DataGridView();
            this.editManagerBtn = new System.Windows.Forms.Button();
            this.moviesListBtn = new System.Windows.Forms.Button();
            this.openBrowser_btn = new System.Windows.Forms.Button();
            this.webBrowserCtl = new System.Windows.Forms.WebBrowser();
            this.ExitBrowserBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMovies
            // 
            this.dataGridViewMovies.AllowDrop = true;
            this.dataGridViewMovies.AllowUserToDeleteRows = false;
            this.dataGridViewMovies.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMovies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMovies.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewMovies.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridViewMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMovies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Watch});
            this.dataGridViewMovies.Location = new System.Drawing.Point(163, 41);
            this.dataGridViewMovies.Name = "dataGridViewMovies";
            this.dataGridViewMovies.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewMovies.Size = new System.Drawing.Size(789, 220);
            this.dataGridViewMovies.TabIndex = 1;
            this.dataGridViewMovies.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMovies_CellContentClick_1);
            this.dataGridViewMovies.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridViewMovies_DataError);
            this.dataGridViewMovies.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridViewMovies_RowsAdded);
            // 
            // Watch
            // 
            this.Watch.HeaderText = "Watch";
            this.Watch.Name = "Watch";
            this.Watch.ReadOnly = true;
            this.Watch.Text = "Click to watch";
            this.Watch.UseColumnTextForButtonValue = true;
            // 
            // dataGridViewCategories
            // 
            this.dataGridViewCategories.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridViewCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCategories.Location = new System.Drawing.Point(163, 274);
            this.dataGridViewCategories.Name = "dataGridViewCategories";
            this.dataGridViewCategories.Size = new System.Drawing.Size(788, 203);
            this.dataGridViewCategories.TabIndex = 2;
            this.dataGridViewCategories.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCategories_CellEndEdit);
            // 
            // editManagerBtn
            // 
            this.editManagerBtn.BackColor = System.Drawing.Color.Azure;
            this.editManagerBtn.BackgroundImage = global::DB_Project.Properties.Resources.editListIcon;
            this.editManagerBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editManagerBtn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.editManagerBtn.FlatAppearance.BorderSize = 10;
            this.editManagerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.editManagerBtn.Font = new System.Drawing.Font("Poor Richard", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editManagerBtn.ForeColor = System.Drawing.Color.LawnGreen;
            this.editManagerBtn.Location = new System.Drawing.Point(12, 274);
            this.editManagerBtn.Name = "editManagerBtn";
            this.editManagerBtn.Size = new System.Drawing.Size(145, 220);
            this.editManagerBtn.TabIndex = 0;
            this.editManagerBtn.Text = "Manager";
            this.editManagerBtn.UseVisualStyleBackColor = false;
            this.editManagerBtn.Click += new System.EventHandler(this.editManagerBtn_Click);
            // 
            // moviesListBtn
            // 
            this.moviesListBtn.BackColor = System.Drawing.Color.SlateBlue;
            this.moviesListBtn.BackgroundImage = global::DB_Project.Properties.Resources.miviesListLogo;
            this.moviesListBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.moviesListBtn.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.moviesListBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.moviesListBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.moviesListBtn.Font = new System.Drawing.Font("Poor Richard", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moviesListBtn.ForeColor = System.Drawing.Color.LawnGreen;
            this.moviesListBtn.Location = new System.Drawing.Point(12, 41);
            this.moviesListBtn.Name = "moviesListBtn";
            this.moviesListBtn.Size = new System.Drawing.Size(145, 220);
            this.moviesListBtn.TabIndex = 0;
            this.moviesListBtn.Text = "Movies List";
            this.moviesListBtn.UseVisualStyleBackColor = false;
            this.moviesListBtn.Click += new System.EventHandler(this.moviesListBtn_Click);
            // 
            // openBrowser_btn
            // 
            this.openBrowser_btn.BackColor = System.Drawing.Color.Azure;
            this.openBrowser_btn.BackgroundImage = global::DB_Project.Properties.Resources.YouTube_logo_full_color;
            this.openBrowser_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.openBrowser_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.openBrowser_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.openBrowser_btn.Font = new System.Drawing.Font("Poor Richard", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openBrowser_btn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.openBrowser_btn.Location = new System.Drawing.Point(12, 4);
            this.openBrowser_btn.Name = "openBrowser_btn";
            this.openBrowser_btn.Size = new System.Drawing.Size(939, 33);
            this.openBrowser_btn.TabIndex = 0;
            this.openBrowser_btn.UseVisualStyleBackColor = false;
            this.openBrowser_btn.Click += new System.EventHandler(this.openBrowser_btn_Click);
            // 
            // webBrowserCtl
            // 
            this.webBrowserCtl.Location = new System.Drawing.Point(164, 44);
            this.webBrowserCtl.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserCtl.Name = "webBrowserCtl";
            this.webBrowserCtl.Size = new System.Drawing.Size(787, 433);
            this.webBrowserCtl.TabIndex = 3;
            // 
            // ExitBrowserBtn
            // 
            this.ExitBrowserBtn.BackColor = System.Drawing.Color.Black;
            this.ExitBrowserBtn.ForeColor = System.Drawing.Color.Azure;
            this.ExitBrowserBtn.Location = new System.Drawing.Point(875, 484);
            this.ExitBrowserBtn.Name = "ExitBrowserBtn";
            this.ExitBrowserBtn.Size = new System.Drawing.Size(75, 23);
            this.ExitBrowserBtn.TabIndex = 4;
            this.ExitBrowserBtn.Text = "Close Movie";
            this.ExitBrowserBtn.UseVisualStyleBackColor = false;
            this.ExitBrowserBtn.Click += new System.EventHandler(this.ExitBrowserBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(964, 506);
            this.Controls.Add(this.ExitBrowserBtn);
            this.Controls.Add(this.dataGridViewCategories);
            this.Controls.Add(this.dataGridViewMovies);
            this.Controls.Add(this.editManagerBtn);
            this.Controls.Add(this.moviesListBtn);
            this.Controls.Add(this.openBrowser_btn);
            this.Controls.Add(this.webBrowserCtl);
            this.Name = "MainForm";
            this.Text = "youtube viewer";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategories)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openBrowser_btn;
        private System.Windows.Forms.Button moviesListBtn;
        private System.Windows.Forms.Button editManagerBtn;
        private System.Windows.Forms.DataGridView dataGridViewMovies;
        private System.Windows.Forms.DataGridViewButtonColumn Watch;
        private System.Windows.Forms.DataGridView dataGridViewCategories;
        private System.Windows.Forms.WebBrowser webBrowserCtl;
        private System.Windows.Forms.Button ExitBrowserBtn;

    }
}