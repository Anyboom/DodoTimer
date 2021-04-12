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
            this.DateTimeLabel = new System.Windows.Forms.Label();
            this.mainDatePicker = new System.Windows.Forms.DateTimePicker();
            this.MainGrid = new System.Windows.Forms.DataGridView();
            this.MainStatusMenu = new System.Windows.Forms.StatusStrip();
            this.CountLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.NumberCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.MinuteLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.MainGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainGrid)).BeginInit();
            this.MainStatusMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainGroupBox
            // 
            this.MainGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainGroupBox.Controls.Add(this.DateTimeLabel);
            this.MainGroupBox.Controls.Add(this.mainDatePicker);
            this.MainGroupBox.Controls.Add(this.MainGrid);
            this.MainGroupBox.Location = new System.Drawing.Point(12, 12);
            this.MainGroupBox.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.MainGroupBox.Name = "MainGroupBox";
            this.MainGroupBox.Padding = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.MainGroupBox.Size = new System.Drawing.Size(410, 269);
            this.MainGroupBox.TabIndex = 0;
            this.MainGroupBox.TabStop = false;
            // 
            // DateTimeLabel
            // 
            this.DateTimeLabel.AutoSize = true;
            this.DateTimeLabel.Location = new System.Drawing.Point(7, 18);
            this.DateTimeLabel.Name = "DateTimeLabel";
            this.DateTimeLabel.Size = new System.Drawing.Size(36, 13);
            this.DateTimeLabel.TabIndex = 2;
            this.DateTimeLabel.Text = "Дата:";
            // 
            // mainDatePicker
            // 
            this.mainDatePicker.Location = new System.Drawing.Point(10, 34);
            this.mainDatePicker.Name = "mainDatePicker";
            this.mainDatePicker.Size = new System.Drawing.Size(137, 20);
            this.mainDatePicker.TabIndex = 1;
            // 
            // MainGrid
            // 
            this.MainGrid.AllowUserToAddRows = false;
            this.MainGrid.AllowUserToDeleteRows = false;
            this.MainGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MainGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.MainGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.MainGrid.Location = new System.Drawing.Point(10, 57);
            this.MainGrid.Margin = new System.Windows.Forms.Padding(0);
            this.MainGrid.MultiSelect = false;
            this.MainGrid.Name = "MainGrid";
            this.MainGrid.ReadOnly = true;
            this.MainGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.MainGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MainGrid.ShowCellErrors = false;
            this.MainGrid.ShowCellToolTips = false;
            this.MainGrid.ShowEditingIcon = false;
            this.MainGrid.ShowRowErrors = false;
            this.MainGrid.Size = new System.Drawing.Size(390, 202);
            this.MainGrid.TabIndex = 0;
            // 
            // MainStatusMenu
            // 
            this.MainStatusMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CountLabel,
            this.NumberCount,
            this.MinuteLabel});
            this.MainStatusMenu.Location = new System.Drawing.Point(0, 284);
            this.MainStatusMenu.Name = "MainStatusMenu";
            this.MainStatusMenu.Size = new System.Drawing.Size(434, 22);
            this.MainStatusMenu.TabIndex = 1;
            this.MainStatusMenu.Text = "statusStrip1";
            // 
            // CountLabel
            // 
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Size = new System.Drawing.Size(92, 17);
            this.CountLabel.Text = "Всего времени:";
            // 
            // NumberCount
            // 
            this.NumberCount.Name = "NumberCount";
            this.NumberCount.Size = new System.Drawing.Size(13, 17);
            this.NumberCount.Text = "0";
            // 
            // MinuteLabel
            // 
            this.MinuteLabel.Name = "MinuteLabel";
            this.MinuteLabel.Size = new System.Drawing.Size(41, 17);
            this.MinuteLabel.Text = "минут";
            // 
            // DinnerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 306);
            this.Controls.Add(this.MainStatusMenu);
            this.Controls.Add(this.MainGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DinnerForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Учет обедов";
            this.MainGroupBox.ResumeLayout(false);
            this.MainGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainGrid)).EndInit();
            this.MainStatusMenu.ResumeLayout(false);
            this.MainStatusMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox MainGroupBox;
        private System.Windows.Forms.DataGridView MainGrid;
        private System.Windows.Forms.StatusStrip MainStatusMenu;
        private System.Windows.Forms.ToolStripStatusLabel CountLabel;
        private System.Windows.Forms.ToolStripStatusLabel NumberCount;
        private System.Windows.Forms.ToolStripStatusLabel MinuteLabel;
        private System.Windows.Forms.Label DateTimeLabel;
        private System.Windows.Forms.DateTimePicker mainDatePicker;
    }
}