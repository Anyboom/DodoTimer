namespace DodoTimer
{
    partial class ActionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActionForm));
            this.MainGroupBox = new System.Windows.Forms.GroupBox();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.ActionButton = new System.Windows.Forms.Button();
            this.MainGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainGroupBox
            // 
            this.MainGroupBox.Controls.Add(this.ActionButton);
            this.MainGroupBox.Controls.Add(this.LastNameTextBox);
            this.MainGroupBox.Controls.Add(this.LastNameLabel);
            this.MainGroupBox.Controls.Add(this.FirstNameTextBox);
            this.MainGroupBox.Controls.Add(this.FirstNameLabel);
            this.MainGroupBox.Location = new System.Drawing.Point(12, 12);
            this.MainGroupBox.Name = "MainGroupBox";
            this.MainGroupBox.Padding = new System.Windows.Forms.Padding(10);
            this.MainGroupBox.Size = new System.Drawing.Size(250, 141);
            this.MainGroupBox.TabIndex = 0;
            this.MainGroupBox.TabStop = false;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(10, 23);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(32, 13);
            this.FirstNameLabel.TabIndex = 0;
            this.FirstNameLabel.Text = "Имя:";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(13, 39);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(224, 20);
            this.FirstNameTextBox.TabIndex = 1;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(13, 78);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(224, 20);
            this.LastNameTextBox.TabIndex = 3;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(10, 62);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(59, 13);
            this.LastNameLabel.TabIndex = 2;
            this.LastNameLabel.Text = "Фамилия:";
            // 
            // ActionButton
            // 
            this.ActionButton.Location = new System.Drawing.Point(162, 104);
            this.ActionButton.Name = "ActionButton";
            this.ActionButton.Size = new System.Drawing.Size(75, 23);
            this.ActionButton.TabIndex = 4;
            this.ActionButton.Text = "Добавить";
            this.ActionButton.UseVisualStyleBackColor = true;
            // 
            // ActionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 162);
            this.Controls.Add(this.MainGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ActionForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавить сотрудника";
            this.MainGroupBox.ResumeLayout(false);
            this.MainGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox MainGroupBox;
        private System.Windows.Forms.Button ActionButton;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.Label FirstNameLabel;
    }
}