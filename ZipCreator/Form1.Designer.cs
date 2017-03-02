namespace ZipCreator
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_File_Chooser = new System.Windows.Forms.Button();
            this.lbl_filePath = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn_File_Chooser
            // 
            this.btn_File_Chooser.Location = new System.Drawing.Point(75, 35);
            this.btn_File_Chooser.Name = "btn_File_Chooser";
            this.btn_File_Chooser.Size = new System.Drawing.Size(172, 43);
            this.btn_File_Chooser.TabIndex = 1;
            this.btn_File_Chooser.Text = "Choose File";
            this.btn_File_Chooser.UseVisualStyleBackColor = true;
            this.btn_File_Chooser.Click += new System.EventHandler(this.btn_File_Chooser_Click);
            // 
            // lbl_filePath
            // 
            this.lbl_filePath.AutoSize = true;
            this.lbl_filePath.Location = new System.Drawing.Point(331, 48);
            this.lbl_filePath.Name = "lbl_filePath";
            this.lbl_filePath.Size = new System.Drawing.Size(0, 13);
            this.lbl_filePath.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(75, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 43);
            this.button1.TabIndex = 3;
            this.button1.Text = "Produce Zip";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 428);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_filePath);
            this.Controls.Add(this.btn_File_Chooser);
            this.Name = "Form1";
            this.Text = "Zip Creator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_File_Chooser;
        private System.Windows.Forms.Label lbl_filePath;
        private System.Windows.Forms.Button button1;
    }
}

