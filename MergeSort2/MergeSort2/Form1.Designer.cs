﻿namespace MergeSort2
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
            this.labelFilePath = new System.Windows.Forms.Label();
            this.loadFileButton = new System.Windows.Forms.Button();
            this.textMainFilePath = new System.Windows.Forms.TextBox();
            this.listMainFile = new System.Windows.Forms.ListBox();
            this.listAddFile = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelFilePath
            // 
            this.labelFilePath.Location = new System.Drawing.Point(12, 12);
            this.labelFilePath.Name = "labelFilePath";
            this.labelFilePath.Size = new System.Drawing.Size(74, 23);
            this.labelFilePath.TabIndex = 1;
            this.labelFilePath.Text = "Path main file";
            // 
            // loadFileButton
            // 
            this.loadFileButton.Location = new System.Drawing.Point(475, 7);
            this.loadFileButton.Name = "loadFileButton";
            this.loadFileButton.Size = new System.Drawing.Size(75, 23);
            this.loadFileButton.TabIndex = 2;
            this.loadFileButton.Text = "...";
            this.loadFileButton.UseVisualStyleBackColor = true;
            this.loadFileButton.Click += new System.EventHandler(this.loadFileButton_Click);
            // 
            // textMainFilePath
            // 
            this.textMainFilePath.Location = new System.Drawing.Point(83, 9);
            this.textMainFilePath.Name = "textMainFilePath";
            this.textMainFilePath.ReadOnly = true;
            this.textMainFilePath.Size = new System.Drawing.Size(386, 20);
            this.textMainFilePath.TabIndex = 3;
            // 
            // listMainFile
            // 
            this.listMainFile.FormattingEnabled = true;
            this.listMainFile.Location = new System.Drawing.Point(6, 19);
            this.listMainFile.Name = "listMainFile";
            this.listMainFile.Size = new System.Drawing.Size(245, 277);
            this.listMainFile.TabIndex = 4;
            // 
            // listAddFile
            // 
            this.listAddFile.FormattingEnabled = true;
            this.listAddFile.Location = new System.Drawing.Point(12, 19);
            this.listAddFile.Name = "listAddFile";
            this.listAddFile.Size = new System.Drawing.Size(245, 277);
            this.listAddFile.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listMainFile);
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 311);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listAddFile);
            this.groupBox2.Location = new System.Drawing.Point(287, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(263, 311);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 693);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textMainFilePath);
            this.Controls.Add(this.loadFileButton);
            this.Controls.Add(this.labelFilePath);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ListBox listAddFile;

        private System.Windows.Forms.ListBox listMainFile;

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;

        private System.Windows.Forms.TextBox textMainFilePath;

        private System.Windows.Forms.Button loadFileButton;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelFilePath;

        #endregion
    }
}