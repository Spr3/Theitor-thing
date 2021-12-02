
namespace WindowsFormsApp12
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
            this.ApplicationTitle = new System.Windows.Forms.Label();
            this.MovieNameLabel = new System.Windows.Forms.Label();
            this.MovieNameTextBox = new System.Windows.Forms.TextBox();
            this.FindMoveButton = new System.Windows.Forms.Button();
            this.Location = new System.Windows.Forms.Label();
            this.theatername = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ApplicationTitle
            // 
            this.ApplicationTitle.AutoSize = true;
            this.ApplicationTitle.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplicationTitle.ForeColor = System.Drawing.Color.White;
            this.ApplicationTitle.Location = new System.Drawing.Point(-2, 7);
            this.ApplicationTitle.Name = "ApplicationTitle";
            this.ApplicationTitle.Size = new System.Drawing.Size(195, 36);
            this.ApplicationTitle.TabIndex = 0;
            this.ApplicationTitle.Text = "Movie Finder";
            // 
            // MovieNameLabel
            // 
            this.MovieNameLabel.AutoSize = true;
            this.MovieNameLabel.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieNameLabel.ForeColor = System.Drawing.Color.White;
            this.MovieNameLabel.Location = new System.Drawing.Point(3, 87);
            this.MovieNameLabel.Name = "MovieNameLabel";
            this.MovieNameLabel.Size = new System.Drawing.Size(191, 36);
            this.MovieNameLabel.TabIndex = 1;
            this.MovieNameLabel.Text = "Movie Name";
            // 
            // MovieNameTextBox
            // 
            this.MovieNameTextBox.Location = new System.Drawing.Point(10, 126);
            this.MovieNameTextBox.Name = "MovieNameTextBox";
            this.MovieNameTextBox.Size = new System.Drawing.Size(174, 20);
            this.MovieNameTextBox.TabIndex = 2;
            // 
            // FindMoveButton
            // 
            this.FindMoveButton.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindMoveButton.Location = new System.Drawing.Point(11, 271);
            this.FindMoveButton.Name = "FindMoveButton";
            this.FindMoveButton.Size = new System.Drawing.Size(166, 41);
            this.FindMoveButton.TabIndex = 3;
            this.FindMoveButton.Text = "Find Movie";
            this.FindMoveButton.UseVisualStyleBackColor = true;
            this.FindMoveButton.Click += new System.EventHandler(this.FindMoveButton_Click);
            // 
            // Location
            // 
            this.Location.AutoSize = true;
            this.Location.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location.ForeColor = System.Drawing.Color.White;
            this.Location.Location = new System.Drawing.Point(5, 140);
            this.Location.Name = "Location";
            this.Location.Size = new System.Drawing.Size(70, 19);
            this.Location.TabIndex = 4;
            this.Location.Text = "Location:";
            this.Location.Visible = false;
            // 
            // theatername
            // 
            this.theatername.AutoSize = true;
            this.theatername.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.theatername.ForeColor = System.Drawing.Color.White;
            this.theatername.Location = new System.Drawing.Point(7, 172);
            this.theatername.Name = "theatername";
            this.theatername.Size = new System.Drawing.Size(108, 19);
            this.theatername.TabIndex = 5;
            this.theatername.Text = "Theater Name:";
            this.theatername.Visible = false;
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Font = new System.Drawing.Font("Microsoft YaHei", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time.ForeColor = System.Drawing.Color.White;
            this.Time.Location = new System.Drawing.Point(5, 203);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(58, 24);
            this.Time.TabIndex = 6;
            this.Time.Text = "Time:";
            this.Time.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(190, 324);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.theatername);
            this.Controls.Add(this.Location);
            this.Controls.Add(this.FindMoveButton);
            this.Controls.Add(this.MovieNameTextBox);
            this.Controls.Add(this.MovieNameLabel);
            this.Controls.Add(this.ApplicationTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ApplicationTitle;
        private System.Windows.Forms.Label MovieNameLabel;
        private System.Windows.Forms.TextBox MovieNameTextBox;
        private System.Windows.Forms.Button FindMoveButton;
        private System.Windows.Forms.Label Location;
        private System.Windows.Forms.Label theatername;
        private System.Windows.Forms.Label Time;
    }
}

