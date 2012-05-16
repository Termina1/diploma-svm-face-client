namespace svmFaceClient
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
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.start = new System.Windows.Forms.Button();
            this.selectPath = new System.Windows.Forms.Button();
            this.faceDir = new System.Windows.Forms.TextBox();
            this.train = new System.Windows.Forms.Button();
            this.flistingFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(31, 49);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 23);
            this.start.TabIndex = 9;
            this.start.Text = "Train";
            this.start.UseVisualStyleBackColor = true;
            // 
            // selectPath
            // 
            this.selectPath.Location = new System.Drawing.Point(237, 12);
            this.selectPath.Name = "selectPath";
            this.selectPath.Size = new System.Drawing.Size(75, 23);
            this.selectPath.TabIndex = 8;
            this.selectPath.Text = "Browse";
            this.selectPath.UseVisualStyleBackColor = true;
            this.selectPath.Click += new System.EventHandler(this.selectPath_Click);
            // 
            // faceDir
            // 
            this.faceDir.Enabled = false;
            this.faceDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.faceDir.Location = new System.Drawing.Point(31, 12);
            this.faceDir.Name = "faceDir";
            this.faceDir.Size = new System.Drawing.Size(185, 22);
            this.faceDir.TabIndex = 7;
            // 
            // train
            // 
            this.train.Location = new System.Drawing.Point(240, 97);
            this.train.Name = "train";
            this.train.Size = new System.Drawing.Size(75, 23);
            this.train.TabIndex = 6;
            this.train.Text = "ClickMe";
            this.train.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 129);
            this.Controls.Add(this.start);
            this.Controls.Add(this.selectPath);
            this.Controls.Add(this.faceDir);
            this.Controls.Add(this.train);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button selectPath;
        private System.Windows.Forms.TextBox faceDir;
        private System.Windows.Forms.Button train;
        private System.Windows.Forms.FolderBrowserDialog flistingFolder;
    }
}

