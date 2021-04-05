namespace DodoTimer
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainGroupBox = new System.Windows.Forms.GroupBox();
            this.MainGridView = new System.Windows.Forms.DataGridView();
            this.MainGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // MainGroupBox
            // 
            this.MainGroupBox.Controls.Add(this.MainGridView);
            this.MainGroupBox.Location = new System.Drawing.Point(12, 12);
            this.MainGroupBox.Name = "MainGroupBox";
            this.MainGroupBox.Padding = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.MainGroupBox.Size = new System.Drawing.Size(760, 437);
            this.MainGroupBox.TabIndex = 0;
            this.MainGroupBox.TabStop = false;
            // 
            // MainGridView
            // 
            this.MainGridView.AllowUserToAddRows = false;
            this.MainGridView.AllowUserToDeleteRows = false;
            this.MainGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MainGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.MainGridView.Location = new System.Drawing.Point(10, 18);
            this.MainGridView.Margin = new System.Windows.Forms.Padding(0);
            this.MainGridView.MultiSelect = false;
            this.MainGridView.Name = "MainGridView";
            this.MainGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MainGridView.Size = new System.Drawing.Size(740, 409);
            this.MainGridView.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.MainGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Учет обедов";
            this.MainGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox MainGroupBox;
        private System.Windows.Forms.DataGridView MainGridView;
    }
}

