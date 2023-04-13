namespace Web
{
    partial class FavPage
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
            this.closeFavButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // closeFavButton
            // 
            this.closeFavButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closeFavButton.Location = new System.Drawing.Point(679, 367);
            this.closeFavButton.Name = "closeFavButton";
            this.closeFavButton.Size = new System.Drawing.Size(102, 27);
            this.closeFavButton.TabIndex = 0;
            this.closeFavButton.Text = "Закрыть";
            this.closeFavButton.UseVisualStyleBackColor = true;
            this.closeFavButton.Click += new System.EventHandler(this.closeFavButton_Click);
            // 
            // FavPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.closeFavButton);
            this.Name = "FavPage";
            this.Size = new System.Drawing.Size(800, 407);
            this.Load += new System.EventHandler(this.FavPage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button closeFavButton;
    }
}
