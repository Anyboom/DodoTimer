namespace DodoTimer
{
    partial class DinnerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DinnerForm));
            this.MainGroupBox = new System.Windows.Forms.GroupBox();
            this.MainStatusMenu = new System.Windows.Forms.StatusStrip();
            this.MainGrid = new System.Windows.Forms.DataGridView();
            this.CountLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.NumberCountLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.MainGroupBox.SuspendLayout();
            this.MainStatusMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // MainGroupBox
            // 
            this.MainGroupBox.Controls.Add(this.MainGrid);
            this.MainGroupBox.Location = new System.Drawing.Point(12, 12);
            this.MainGroupBox.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.MainGroupBox.Name = "MainGroupBox";
            this.MainGroupBox.Padding = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.MainGroupBox.Size = new System.Drawing.Size(723, 504);
            this.MainGroupBox.TabIndex = 0;
            this.MainGroupBox.TabStop = false;
            // 
            // MainStatusMenu
            // 
            this.MainStatusMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CountLabel,
            this.NumberCountLabel});
            this.MainStatusMenu.Location = new System.Drawing.Point(0, 519);
            this.MainStatusMenu.Name = "MainStatusMenu";
            this.MainStatusMenu.Size = new System.Drawing.Size(747, 22);
            this.MainStatusMenu.TabIndex = 1;
            this.MainStatusMenu.Text = "statusStrip1";
            // 
            // MainGrid
            // 
            this.MainGrid.AllowUserToAddRows = false;
            this.MainGrid.AllowUserToDeleteRows = false;
            this.MainGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MainGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.MainGrid.Location = new System.Drawing.Point(10, 18);
            this.MainGrid.Margin = new System.Windows.Forms.Padding(0);
            this.MainGrid.MultiSelect = false;
            this.MainGrid.Name = "MainGrid";
            this.MainGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MainGrid.Size = new System.Drawing.Size(703, 476);
            this.MainGrid.TabIndex = 0;
            // 
            // CountLabel
            // 
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Size = new System.Drawing.Size(92, 17);
            this.CountLabel.Text = "Всего времени:";
            // 
            // NumberCountLabel
            // 
            this.NumberCountLabel.Name = "NumberCountLabel";
            this.NumberCountLabel.Size = new System.Drawing.Size(13, 17);
            this.NumberCountLabel.Text = "0";
            // 
            // DinnerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 541);
            this.Controls.Add(this.MainStatusMenu);
            this.Controls.Add(this.MainGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DinnerForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Учет обедов";
            this.MainGroupBox.ResumeLayout(false);
            this.MainStatusMenu.ResumeLayout(false);
            this.MainStatusMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox MainGroupBox;
        private System.Windows.Forms.DataGridView MainGrid;
        private System.Windows.Forms.StatusStrip MainStatusMenu;
        private System.Windows.Forms.ToolStripStatusLabel CountLabel;
        private System.Windows.Forms.ToolStripStatusLabel NumberCountLabel;
    }
}