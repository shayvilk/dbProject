namespace DB_Project
{
    partial class MenuForm
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
            this.buttonMovieList = new System.Windows.Forms.Button();
            this.buttonManegeCat = new System.Windows.Forms.Button();
            this.buttonManegeMovies = new System.Windows.Forms.Button();
            this.buttonOpenYouTube = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonMovieList
            // 
            this.buttonMovieList.Location = new System.Drawing.Point(16, 66);
            this.buttonMovieList.Name = "buttonMovieList";
            this.buttonMovieList.Size = new System.Drawing.Size(120, 78);
            this.buttonMovieList.TabIndex = 0;
            this.buttonMovieList.Text = "Movies list";
            this.buttonMovieList.UseVisualStyleBackColor = true;
            this.buttonMovieList.Click += new System.EventHandler(this.buttonMovieList_Click);
            // 
            // buttonManegeCat
            // 
            this.buttonManegeCat.Location = new System.Drawing.Point(270, 66);
            this.buttonManegeCat.Name = "buttonManegeCat";
            this.buttonManegeCat.Size = new System.Drawing.Size(120, 78);
            this.buttonManegeCat.TabIndex = 4;
            this.buttonManegeCat.Text = "Manege categories";
            this.buttonManegeCat.UseVisualStyleBackColor = true;
            this.buttonManegeCat.Click += new System.EventHandler(this.buttonManegeCat_Click);
            // 
            // buttonManegeMovies
            // 
            this.buttonManegeMovies.Location = new System.Drawing.Point(143, 66);
            this.buttonManegeMovies.Name = "buttonManegeMovies";
            this.buttonManegeMovies.Size = new System.Drawing.Size(120, 78);
            this.buttonManegeMovies.TabIndex = 5;
            this.buttonManegeMovies.Text = "Manege movies";
            this.buttonManegeMovies.UseVisualStyleBackColor = true;
            this.buttonManegeMovies.Click += new System.EventHandler(this.buttonManegeMovies_Click);
            // 
            // buttonOpenYouTube
            // 
            this.buttonOpenYouTube.Location = new System.Drawing.Point(16, 14);
            this.buttonOpenYouTube.Name = "buttonOpenYouTube";
            this.buttonOpenYouTube.Size = new System.Drawing.Size(375, 35);
            this.buttonOpenYouTube.TabIndex = 6;
            this.buttonOpenYouTube.Text = "Open YouTube";
            this.buttonOpenYouTube.UseVisualStyleBackColor = true;
            this.buttonOpenYouTube.Click += new System.EventHandler(this.buttonOpenYouTube_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 158);
            this.Controls.Add(this.buttonOpenYouTube);
            this.Controls.Add(this.buttonManegeMovies);
            this.Controls.Add(this.buttonManegeCat);
            this.Controls.Add(this.buttonMovieList);
            this.Name = "MenuForm";
            this.Text = "YouTube app";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonMovieList;
        private System.Windows.Forms.Button buttonManegeCat;
        private System.Windows.Forms.Button buttonManegeMovies;
        private System.Windows.Forms.Button buttonOpenYouTube;
    }
}