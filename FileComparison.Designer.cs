namespace Test
{
    partial class FileComparison
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
            this.firstFileSelectButton = new System.Windows.Forms.Button();
            this.secondFileSelectButton = new System.Windows.Forms.Button();
            this.FindDifference = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstFileSelectButton
            // 
            this.firstFileSelectButton.Location = new System.Drawing.Point(13, 25);
            this.firstFileSelectButton.Name = "firstFileSelectButton";
            this.firstFileSelectButton.Size = new System.Drawing.Size(75, 23);
            this.firstFileSelectButton.TabIndex = 0;
            this.firstFileSelectButton.Text = "First File";
            this.firstFileSelectButton.UseVisualStyleBackColor = true;
            // 
            // secondFileSelectButton
            // 
            this.secondFileSelectButton.Location = new System.Drawing.Point(571, 25);
            this.secondFileSelectButton.Name = "secondFileSelectButton";
            this.secondFileSelectButton.Size = new System.Drawing.Size(75, 23);
            this.secondFileSelectButton.TabIndex = 1;
            this.secondFileSelectButton.Text = "Second File";
            this.secondFileSelectButton.UseVisualStyleBackColor = true;
            // 
            // FindDifference
            // 
            this.FindDifference.Location = new System.Drawing.Point(277, 186);
            this.FindDifference.Name = "FindDifference";
            this.FindDifference.Size = new System.Drawing.Size(112, 23);
            this.FindDifference.TabIndex = 2;
            this.FindDifference.Text = "Find Difference";
            this.FindDifference.UseVisualStyleBackColor = true;
            // 
            // FileComparison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 352);
            this.Controls.Add(this.FindDifference);
            this.Controls.Add(this.secondFileSelectButton);
            this.Controls.Add(this.firstFileSelectButton);
            this.Name = "FileComparison";
            this.Text = "FileComparison";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button firstFileSelectButton;
        private System.Windows.Forms.Button secondFileSelectButton;
        private System.Windows.Forms.Button FindDifference;
    }
}