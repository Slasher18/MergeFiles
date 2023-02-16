namespace MergeFiles
{
    partial class MergeFilesForm
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
            this.buttonSelectFile1 = new System.Windows.Forms.Button();
            this.buttonSelectFile2 = new System.Windows.Forms.Button();
            this.buttonSelectOutput = new System.Windows.Forms.Button();
            this.buttonMergeFiles = new System.Windows.Forms.Button();
            this.listBoxFirstFile = new System.Windows.Forms.ListBox();
            this.listBoxSecondFile = new System.Windows.Forms.ListBox();
            this.listBoxOutputFile = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSelectFile1
            // 
            this.buttonSelectFile1.Location = new System.Drawing.Point(12, 12);
            this.buttonSelectFile1.Name = "buttonSelectFile1";
            this.buttonSelectFile1.Size = new System.Drawing.Size(76, 30);
            this.buttonSelectFile1.TabIndex = 0;
            this.buttonSelectFile1.Text = "File1";
            this.buttonSelectFile1.UseVisualStyleBackColor = true;
            this.buttonSelectFile1.Visible = false;
            this.buttonSelectFile1.Click += new System.EventHandler(this.buttonSelectFile1_Click);
            // 
            // buttonSelectFile2
            // 
            this.buttonSelectFile2.Location = new System.Drawing.Point(104, 10);
            this.buttonSelectFile2.Name = "buttonSelectFile2";
            this.buttonSelectFile2.Size = new System.Drawing.Size(87, 34);
            this.buttonSelectFile2.TabIndex = 1;
            this.buttonSelectFile2.Text = "File2";
            this.buttonSelectFile2.UseVisualStyleBackColor = true;
            this.buttonSelectFile2.Visible = false;
            this.buttonSelectFile2.Click += new System.EventHandler(this.buttonSelectFile2_Click);
            // 
            // buttonSelectOutput
            // 
            this.buttonSelectOutput.Location = new System.Drawing.Point(209, 5);
            this.buttonSelectOutput.Name = "buttonSelectOutput";
            this.buttonSelectOutput.Size = new System.Drawing.Size(87, 44);
            this.buttonSelectOutput.TabIndex = 2;
            this.buttonSelectOutput.Text = "OutputFile";
            this.buttonSelectOutput.UseVisualStyleBackColor = true;
            this.buttonSelectOutput.Visible = false;
            this.buttonSelectOutput.Click += new System.EventHandler(this.buttonSelectOutput_Click);
            // 
            // buttonMergeFiles
            // 
            this.buttonMergeFiles.Location = new System.Drawing.Point(12, 90);
            this.buttonMergeFiles.Name = "buttonMergeFiles";
            this.buttonMergeFiles.Size = new System.Drawing.Size(109, 60);
            this.buttonMergeFiles.TabIndex = 3;
            this.buttonMergeFiles.Text = "MergeFiles";
            this.buttonMergeFiles.UseVisualStyleBackColor = true;
            this.buttonMergeFiles.Click += new System.EventHandler(this.buttonMergeFiles_Click);
            // 
            // listBoxFirstFile
            // 
            this.listBoxFirstFile.FormattingEnabled = true;
            this.listBoxFirstFile.ItemHeight = 16;
            this.listBoxFirstFile.Location = new System.Drawing.Point(127, 90);
            this.listBoxFirstFile.Name = "listBoxFirstFile";
            this.listBoxFirstFile.Size = new System.Drawing.Size(350, 84);
            this.listBoxFirstFile.TabIndex = 4;
            // 
            // listBoxSecondFile
            // 
            this.listBoxSecondFile.FormattingEnabled = true;
            this.listBoxSecondFile.ItemHeight = 16;
            this.listBoxSecondFile.Location = new System.Drawing.Point(509, 90);
            this.listBoxSecondFile.Name = "listBoxSecondFile";
            this.listBoxSecondFile.Size = new System.Drawing.Size(350, 84);
            this.listBoxSecondFile.TabIndex = 5;
            // 
            // listBoxOutputFile
            // 
            this.listBoxOutputFile.FormattingEnabled = true;
            this.listBoxOutputFile.ItemHeight = 16;
            this.listBoxOutputFile.Location = new System.Drawing.Point(321, 233);
            this.listBoxOutputFile.Name = "listBoxOutputFile";
            this.listBoxOutputFile.Size = new System.Drawing.Size(350, 84);
            this.listBoxOutputFile.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(422, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = " |\r\nv";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(542, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = " |\r\nv";
            // 
            // MergeFilesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxOutputFile);
            this.Controls.Add(this.listBoxSecondFile);
            this.Controls.Add(this.listBoxFirstFile);
            this.Controls.Add(this.buttonMergeFiles);
            this.Controls.Add(this.buttonSelectOutput);
            this.Controls.Add(this.buttonSelectFile2);
            this.Controls.Add(this.buttonSelectFile1);
            this.Name = "MergeFilesForm";
            this.Text = "FormMergeFiles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSelectFile1;
        private System.Windows.Forms.Button buttonSelectFile2;
        private System.Windows.Forms.Button buttonSelectOutput;
        private System.Windows.Forms.Button buttonMergeFiles;
        private System.Windows.Forms.ListBox listBoxFirstFile;
        private System.Windows.Forms.ListBox listBoxSecondFile;
        private System.Windows.Forms.ListBox listBoxOutputFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

