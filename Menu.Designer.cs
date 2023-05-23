
namespace Toy
{
    partial class Menu
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
            this.StartButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.NameInputBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.DiffLabel = new System.Windows.Forms.Label();
            this.DifficultyComboBox = new System.Windows.Forms.ComboBox();
            this.StatsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartButton.Location = new System.Drawing.Point(12, 202);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(169, 80);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CloseButton.Font = new System.Drawing.Font("Comic Sans MS", 24F);
            this.CloseButton.Location = new System.Drawing.Point(424, 202);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(169, 80);
            this.CloseButton.TabIndex = 2;
            this.CloseButton.Text = "Exit";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // NameInputBox
            // 
            this.NameInputBox.Font = new System.Drawing.Font("Comic Sans MS", 14F);
            this.NameInputBox.Location = new System.Drawing.Point(12, 48);
            this.NameInputBox.Name = "NameInputBox";
            this.NameInputBox.Size = new System.Drawing.Size(240, 34);
            this.NameInputBox.TabIndex = 3;
            this.NameInputBox.TextChanged += new System.EventHandler(this.NameInputBox_TextChanged);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Comic Sans MS", 24F);
            this.NameLabel.Location = new System.Drawing.Point(4, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(265, 45);
            this.NameLabel.TabIndex = 4;
            this.NameLabel.Text = "Input your name";
            // 
            // DiffLabel
            // 
            this.DiffLabel.AutoSize = true;
            this.DiffLabel.Font = new System.Drawing.Font("Comic Sans MS", 24F);
            this.DiffLabel.Location = new System.Drawing.Point(4, 80);
            this.DiffLabel.Name = "DiffLabel";
            this.DiffLabel.Size = new System.Drawing.Size(271, 45);
            this.DiffLabel.TabIndex = 5;
            this.DiffLabel.Text = "Select difficulty";
            // 
            // DifficultyComboBox
            // 
            this.DifficultyComboBox.Font = new System.Drawing.Font("Comic Sans MS", 14F);
            this.DifficultyComboBox.Items.AddRange(new object[] {
            "Easy",
            "Medium",
            "Hard"});
            this.DifficultyComboBox.Location = new System.Drawing.Point(12, 128);
            this.DifficultyComboBox.Name = "DifficultyComboBox";
            this.DifficultyComboBox.Size = new System.Drawing.Size(121, 34);
            this.DifficultyComboBox.TabIndex = 6;
            this.DifficultyComboBox.SelectionChangeCommitted += new System.EventHandler(this.DifficultyComboBox_SelectionChangeCommitted);
            // 
            // StatsButton
            // 
            this.StatsButton.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StatsButton.Location = new System.Drawing.Point(424, 17);
            this.StatsButton.Name = "StatsButton";
            this.StatsButton.Size = new System.Drawing.Size(169, 80);
            this.StatsButton.TabIndex = 7;
            this.StatsButton.Text = "Stats";
            this.StatsButton.UseVisualStyleBackColor = true;
            this.StatsButton.Click += new System.EventHandler(this.StatsButton_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DimGray;
            this.CancelButton = this.CloseButton;
            this.ClientSize = new System.Drawing.Size(605, 294);
            this.Controls.Add(this.StatsButton);
            this.Controls.Add(this.DifficultyComboBox);
            this.Controls.Add(this.DiffLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.NameInputBox);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.StartButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.TextBox NameInputBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label DiffLabel;
        private System.Windows.Forms.ComboBox DifficultyComboBox;
        private System.Windows.Forms.Button StatsButton;
    }
}