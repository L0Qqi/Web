namespace Web
{
    partial class HistoryPage
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelHistory = new System.Windows.Forms.Label();
            this.closeHPButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelHistory
            // 
            this.labelHistory.AutoEllipsis = true;
            this.labelHistory.AutoSize = true;
            this.labelHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHistory.Location = new System.Drawing.Point(16, 20);
            this.labelHistory.Name = "labelHistory";
            this.labelHistory.Size = new System.Drawing.Size(135, 33);
            this.labelHistory.TabIndex = 3;
            this.labelHistory.Text = "История";
            this.labelHistory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // closeHPButton
            // 
            this.closeHPButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closeHPButton.Location = new System.Drawing.Point(541, 380);
            this.closeHPButton.Name = "closeHPButton";
            this.closeHPButton.Size = new System.Drawing.Size(101, 23);
            this.closeHPButton.TabIndex = 4;
            this.closeHPButton.Text = "Закрыть";
            this.closeHPButton.UseVisualStyleBackColor = true;
            this.closeHPButton.Click += new System.EventHandler(this.closeHPButton_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(668, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 35);
            this.button1.TabIndex = 5;
            this.button1.Text = "Очистить историю";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // HistoryPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.closeHPButton);
            this.Controls.Add(this.labelHistory);
            this.Name = "HistoryPage";
            this.Size = new System.Drawing.Size(800, 425);
            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHistory;
        private System.Windows.Forms.Button closeHPButton;
        private System.Windows.Forms.Button button1;
    }
}
