﻿namespace MainForm
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
            this.button6 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.editorGroupBox = new System.Windows.Forms.GroupBox();
            this.editorField = new System.Windows.Forms.RichTextBox();
            this.editorSaveButton = new System.Windows.Forms.Button();
            this.editorOpenButton = new System.Windows.Forms.Button();
            this.editorNewButton = new System.Windows.Forms.Button();
            this.algorithmPlaybackGroupBox = new System.Windows.Forms.GroupBox();
            this.stepInButton = new System.Windows.Forms.Button();
            this.stepBackButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.algorithmPicker = new System.Windows.Forms.ComboBox();
            this.algorithmPickerGroupBox = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.algorithmOptionsGroupBox = new System.Windows.Forms.GroupBox();
            this.noOptionsLabel = new System.Windows.Forms.Label();
            this.algorithmInfoLabel = new System.Windows.Forms.Label();
            this.editorGroupBox.SuspendLayout();
            this.algorithmPlaybackGroupBox.SuspendLayout();
            this.algorithmPickerGroupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.algorithmOptionsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(7, 574);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(132, 30);
            this.button6.TabIndex = 7;
            this.button6.Text = "Run";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(246, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(258, 219);
            this.panel2.TabIndex = 8;
            // 
            // editorGroupBox
            // 
            this.editorGroupBox.Controls.Add(this.editorField);
            this.editorGroupBox.Controls.Add(this.editorSaveButton);
            this.editorGroupBox.Controls.Add(this.editorOpenButton);
            this.editorGroupBox.Controls.Add(this.editorNewButton);
            this.editorGroupBox.Location = new System.Drawing.Point(12, 12);
            this.editorGroupBox.Name = "editorGroupBox";
            this.editorGroupBox.Size = new System.Drawing.Size(282, 537);
            this.editorGroupBox.TabIndex = 9;
            this.editorGroupBox.TabStop = false;
            this.editorGroupBox.Text = "Graph source";
            // 
            // editorField
            // 
            this.editorField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.editorField.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editorField.Location = new System.Drawing.Point(7, 49);
            this.editorField.Name = "editorField";
            this.editorField.Size = new System.Drawing.Size(269, 481);
            this.editorField.TabIndex = 3;
            this.editorField.Text = "";
            this.editorField.WordWrap = false;
            // 
            // editorSaveButton
            // 
            this.editorSaveButton.Enabled = false;
            this.editorSaveButton.Location = new System.Drawing.Point(169, 19);
            this.editorSaveButton.Name = "editorSaveButton";
            this.editorSaveButton.Size = new System.Drawing.Size(75, 23);
            this.editorSaveButton.TabIndex = 2;
            this.editorSaveButton.Text = "Save";
            this.editorSaveButton.UseVisualStyleBackColor = true;
            // 
            // editorOpenButton
            // 
            this.editorOpenButton.Location = new System.Drawing.Point(88, 19);
            this.editorOpenButton.Name = "editorOpenButton";
            this.editorOpenButton.Size = new System.Drawing.Size(75, 23);
            this.editorOpenButton.TabIndex = 1;
            this.editorOpenButton.Text = "Open";
            this.editorOpenButton.UseVisualStyleBackColor = true;
            this.editorOpenButton.Click += new System.EventHandler(this.editorOpenButton_Click);
            // 
            // editorNewButton
            // 
            this.editorNewButton.Location = new System.Drawing.Point(6, 19);
            this.editorNewButton.Name = "editorNewButton";
            this.editorNewButton.Size = new System.Drawing.Size(75, 23);
            this.editorNewButton.TabIndex = 0;
            this.editorNewButton.Text = "New";
            this.editorNewButton.UseVisualStyleBackColor = true;
            this.editorNewButton.Click += new System.EventHandler(this.editorNewButton_Click);
            // 
            // algorithmPlaybackGroupBox
            // 
            this.algorithmPlaybackGroupBox.Controls.Add(this.stepInButton);
            this.algorithmPlaybackGroupBox.Controls.Add(this.stepBackButton);
            this.algorithmPlaybackGroupBox.Controls.Add(this.startButton);
            this.algorithmPlaybackGroupBox.Controls.Add(this.panel2);
            this.algorithmPlaybackGroupBox.Enabled = false;
            this.algorithmPlaybackGroupBox.Location = new System.Drawing.Point(300, 132);
            this.algorithmPlaybackGroupBox.Name = "algorithmPlaybackGroupBox";
            this.algorithmPlaybackGroupBox.Size = new System.Drawing.Size(696, 417);
            this.algorithmPlaybackGroupBox.TabIndex = 10;
            this.algorithmPlaybackGroupBox.TabStop = false;
            this.algorithmPlaybackGroupBox.Text = "Algorithm playback";
            // 
            // stepInButton
            // 
            this.stepInButton.Location = new System.Drawing.Point(88, 19);
            this.stepInButton.Name = "stepInButton";
            this.stepInButton.Size = new System.Drawing.Size(75, 23);
            this.stepInButton.TabIndex = 6;
            this.stepInButton.Text = "Step in";
            this.stepInButton.UseVisualStyleBackColor = true;
            // 
            // stepBackButton
            // 
            this.stepBackButton.Location = new System.Drawing.Point(169, 19);
            this.stepBackButton.Name = "stepBackButton";
            this.stepBackButton.Size = new System.Drawing.Size(75, 23);
            this.stepBackButton.TabIndex = 7;
            this.stepBackButton.Text = "Step back";
            this.stepBackButton.UseVisualStyleBackColor = true;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(7, 20);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 5;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // algorithmPicker
            // 
            this.algorithmPicker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.algorithmPicker.FormattingEnabled = true;
            this.algorithmPicker.Location = new System.Drawing.Point(6, 20);
            this.algorithmPicker.Name = "algorithmPicker";
            this.algorithmPicker.Size = new System.Drawing.Size(184, 21);
            this.algorithmPicker.TabIndex = 4;
            this.algorithmPicker.SelectedIndexChanged += new System.EventHandler(this.algorithmPicker_SelectedIndexChanged);
            // 
            // algorithmPickerGroupBox
            // 
            this.algorithmPickerGroupBox.Controls.Add(this.panel1);
            this.algorithmPickerGroupBox.Controls.Add(this.algorithmPicker);
            this.algorithmPickerGroupBox.Location = new System.Drawing.Point(301, 13);
            this.algorithmPickerGroupBox.Name = "algorithmPickerGroupBox";
            this.algorithmPickerGroupBox.Size = new System.Drawing.Size(323, 113);
            this.algorithmPickerGroupBox.TabIndex = 11;
            this.algorithmPickerGroupBox.TabStop = false;
            this.algorithmPickerGroupBox.Text = "Algorithm picker";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.algorithmInfoLabel);
            this.panel1.Location = new System.Drawing.Point(6, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 63);
            this.panel1.TabIndex = 11;
            // 
            // algorithmOptionsGroupBox
            // 
            this.algorithmOptionsGroupBox.Controls.Add(this.noOptionsLabel);
            this.algorithmOptionsGroupBox.Location = new System.Drawing.Point(630, 13);
            this.algorithmOptionsGroupBox.Name = "algorithmOptionsGroupBox";
            this.algorithmOptionsGroupBox.Size = new System.Drawing.Size(366, 113);
            this.algorithmOptionsGroupBox.TabIndex = 12;
            this.algorithmOptionsGroupBox.TabStop = false;
            this.algorithmOptionsGroupBox.Text = "Algorithm options";
            // 
            // noOptionsLabel
            // 
            this.noOptionsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.noOptionsLabel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.noOptionsLabel.Location = new System.Drawing.Point(3, 16);
            this.noOptionsLabel.Name = "noOptionsLabel";
            this.noOptionsLabel.Size = new System.Drawing.Size(360, 94);
            this.noOptionsLabel.TabIndex = 0;
            this.noOptionsLabel.Text = "No algorithm selected.";
            this.noOptionsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // algorithmInfoLabel
            // 
            this.algorithmInfoLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.algorithmInfoLabel.Location = new System.Drawing.Point(0, 0);
            this.algorithmInfoLabel.Name = "algorithmInfoLabel";
            this.algorithmInfoLabel.Size = new System.Drawing.Size(311, 63);
            this.algorithmInfoLabel.TabIndex = 11;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.Controls.Add(this.algorithmOptionsGroupBox);
            this.Controls.Add(this.algorithmPickerGroupBox);
            this.Controls.Add(this.algorithmPlaybackGroupBox);
            this.Controls.Add(this.editorGroupBox);
            this.Controls.Add(this.button6);
            this.Name = "MainForm";
            this.Text = "Graph Algorithms";
            this.editorGroupBox.ResumeLayout(false);
            this.algorithmPlaybackGroupBox.ResumeLayout(false);
            this.algorithmPickerGroupBox.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.algorithmOptionsGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox editorGroupBox;
        private System.Windows.Forms.RichTextBox editorField;
        private System.Windows.Forms.Button editorSaveButton;
        private System.Windows.Forms.Button editorOpenButton;
        private System.Windows.Forms.Button editorNewButton;
        private System.Windows.Forms.GroupBox algorithmPlaybackGroupBox;
        internal System.Windows.Forms.ComboBox algorithmPicker;
        private System.Windows.Forms.GroupBox algorithmPickerGroupBox;
        private System.Windows.Forms.GroupBox algorithmOptionsGroupBox;
        private System.Windows.Forms.Label noOptionsLabel;
        private System.Windows.Forms.Button stepInButton;
        private System.Windows.Forms.Button stepBackButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label algorithmInfoLabel;
    }
}
