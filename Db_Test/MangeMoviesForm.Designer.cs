namespace DB_Project
{
    partial class MangeMoviesForm
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
            this.buttonDelMovie = new System.Windows.Forms.Button();
            this.buttonAddMovie = new System.Windows.Forms.Button();
            this.buttonUpdateMovie = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDelMovie
            // 
            this.buttonDelMovie.Location = new System.Drawing.Point(239, 12);
            this.buttonDelMovie.Name = "buttonDelMovie";
            this.buttonDelMovie.Size = new System.Drawing.Size(107, 69);
            this.buttonDelMovie.TabIndex = 3;
            this.buttonDelMovie.Text = "Delete movie";
            this.buttonDelMovie.UseVisualStyleBackColor = true;
            this.buttonDelMovie.Click += new System.EventHandler(this.buttonDelMovie_Click);
            // 
            // buttonAddMovie
            // 
            this.buttonAddMovie.Location = new System.Drawing.Point(13, 12);
            this.buttonAddMovie.Name = "buttonAddMovie";
            this.buttonAddMovie.Size = new System.Drawing.Size(107, 69);
            this.buttonAddMovie.TabIndex = 1;
            this.buttonAddMovie.Text = "Add new movie";
            this.buttonAddMovie.UseVisualStyleBackColor = true;
            this.buttonAddMovie.Click += new System.EventHandler(this.buttonAddMovie_Click);
            // 
            // buttonUpdateMovie
            // 
            this.buttonUpdateMovie.Location = new System.Drawing.Point(126, 12);
            this.buttonUpdateMovie.Name = "buttonUpdateMovie";
            this.buttonUpdateMovie.Size = new System.Drawing.Size(107, 69);
            this.buttonUpdateMovie.TabIndex = 2;
            this.buttonUpdateMovie.Text = "Update movie";
            this.buttonUpdateMovie.UseVisualStyleBackColor = true;
            this.buttonUpdateMovie.Click += new System.EventHandler(this.buttonUpdateMovie_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(352, 12);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(107, 69);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // MangeMoviesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 96);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonDelMovie);
            this.Controls.Add(this.buttonAddMovie);
            this.Controls.Add(this.buttonUpdateMovie);
            this.Name = "MangeMoviesForm";
            this.Text = "MangeMoviesForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDelMovie;
        private System.Windows.Forms.Button buttonAddMovie;
        private System.Windows.Forms.Button buttonUpdateMovie;
        private System.Windows.Forms.Button buttonExit;
    }
}