namespace Web
{
    partial class FormBrowser
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
            this.searchBar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.urlSearchBar = new System.Windows.Forms.TextBox();
            this.stopPicture = new System.Windows.Forms.PictureBox();
            this.searchPicture = new System.Windows.Forms.PictureBox();
            this.addToFavPicture = new System.Windows.Forms.PictureBox();
            this.refreshPicture = new System.Windows.Forms.PictureBox();
            this.forwardPicture = new System.Windows.Forms.PictureBox();
            this.backPicture = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.закладкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.историяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.urlSearchPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.stopPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addToFavPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.forwardPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backPicture)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.urlSearchPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // searchBar
            // 
            this.searchBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBar.Location = new System.Drawing.Point(210, 171);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(408, 20);
            this.searchBar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(299, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Поиск и точка";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // urlSearchBar
            // 
            this.urlSearchBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.urlSearchBar.Location = new System.Drawing.Point(210, 12);
            this.urlSearchBar.Name = "urlSearchBar";
            this.urlSearchBar.Size = new System.Drawing.Size(452, 20);
            this.urlSearchBar.TabIndex = 6;
            // 
            // stopPicture
            // 
            this.stopPicture.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.stopPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stopPicture.Image = global::Web.Properties.Resources._352270_close_icon;
            this.stopPicture.Location = new System.Drawing.Point(111, 7);
            this.stopPicture.Name = "stopPicture";
            this.stopPicture.Size = new System.Drawing.Size(27, 26);
            this.stopPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.stopPicture.TabIndex = 10;
            this.stopPicture.TabStop = false;
            this.stopPicture.Click += new System.EventHandler(this.stopPicture_Click);
            // 
            // searchPicture
            // 
            this.searchPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchPicture.Image = global::Web.Properties.Resources._4801315_glass_magnifier_magnifying_search_searching_icon;
            this.searchPicture.Location = new System.Drawing.Point(650, 171);
            this.searchPicture.Name = "searchPicture";
            this.searchPicture.Size = new System.Drawing.Size(30, 28);
            this.searchPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.searchPicture.TabIndex = 9;
            this.searchPicture.TabStop = false;
            this.searchPicture.Click += new System.EventHandler(this.searchPicture_Click);
            // 
            // addToFavPicture
            // 
            this.addToFavPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addToFavPicture.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.addToFavPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addToFavPicture.Image = global::Web.Properties.Resources._2849817_favorite_star_favorites_favourite_multimedia_icon;
            this.addToFavPicture.Location = new System.Drawing.Point(718, 7);
            this.addToFavPicture.Name = "addToFavPicture";
            this.addToFavPicture.Size = new System.Drawing.Size(27, 26);
            this.addToFavPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.addToFavPicture.TabIndex = 7;
            this.addToFavPicture.TabStop = false;
            this.addToFavPicture.Click += new System.EventHandler(this.addToFavPicture_Click);
            // 
            // refreshPicture
            // 
            this.refreshPicture.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.refreshPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshPicture.Image = global::Web.Properties.Resources._352439_refresh_icon;
            this.refreshPicture.Location = new System.Drawing.Point(78, 7);
            this.refreshPicture.Name = "refreshPicture";
            this.refreshPicture.Size = new System.Drawing.Size(27, 26);
            this.refreshPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.refreshPicture.TabIndex = 5;
            this.refreshPicture.TabStop = false;
            this.refreshPicture.Click += new System.EventHandler(this.refreshPicture_Click);
            // 
            // forwardPicture
            // 
            this.forwardPicture.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.forwardPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.forwardPicture.Image = global::Web.Properties.Resources._4781858_arrow_arrows_back_direction_left_icon;
            this.forwardPicture.Location = new System.Drawing.Point(45, 7);
            this.forwardPicture.Name = "forwardPicture";
            this.forwardPicture.Size = new System.Drawing.Size(27, 26);
            this.forwardPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.forwardPicture.TabIndex = 4;
            this.forwardPicture.TabStop = false;
            this.forwardPicture.Click += new System.EventHandler(this.forwardPicture_Click);
            // 
            // backPicture
            // 
            this.backPicture.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.backPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backPicture.Image = global::Web.Properties.Resources._4781857_arrow_arrows_back_direction_left_icon;
            this.backPicture.Location = new System.Drawing.Point(12, 7);
            this.backPicture.Name = "backPicture";
            this.backPicture.Size = new System.Drawing.Size(27, 26);
            this.backPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backPicture.TabIndex = 3;
            this.backPicture.TabStop = false;
            this.backPicture.Click += new System.EventHandler(this.backPicture_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuStrip1.BackgroundImage = global::Web.Properties.Resources._9112583_ellipsis_v_solid_icon;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(800, 39);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.AutoSize = false;
            this.toolStripMenuItem1.BackgroundImage = global::Web.Properties.Resources._9112583_ellipsis_v_solid_icon;
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.закладкиToolStripMenuItem,
            this.историяToolStripMenuItem});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripMenuItem1.Image = global::Web.Properties.Resources._9112583_ellipsis_v_solid_icon;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(40, 40);
            // 
            // закладкиToolStripMenuItem
            // 
            this.закладкиToolStripMenuItem.Name = "закладкиToolStripMenuItem";
            this.закладкиToolStripMenuItem.Size = new System.Drawing.Size(180, 34);
            this.закладкиToolStripMenuItem.Text = "Закладки";
            this.закладкиToolStripMenuItem.Click += new System.EventHandler(this.закладкиToolStripMenuItem_Click);
            // 
            // историяToolStripMenuItem
            // 
            this.историяToolStripMenuItem.Name = "историяToolStripMenuItem";
            this.историяToolStripMenuItem.Size = new System.Drawing.Size(180, 34);
            this.историяToolStripMenuItem.Text = "История";
            this.историяToolStripMenuItem.Click += new System.EventHandler(this.историяToolStripMenuItem_Click);
            // 
            // urlSearchPicture
            // 
            this.urlSearchPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.urlSearchPicture.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.urlSearchPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.urlSearchPicture.Image = global::Web.Properties.Resources._4801315_glass_magnifier_magnifying_search_searching_icon;
            this.urlSearchPicture.Location = new System.Drawing.Point(668, 7);
            this.urlSearchPicture.Name = "urlSearchPicture";
            this.urlSearchPicture.Size = new System.Drawing.Size(27, 26);
            this.urlSearchPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.urlSearchPicture.TabIndex = 8;
            this.urlSearchPicture.TabStop = false;
            this.urlSearchPicture.Click += new System.EventHandler(this.urlSearchPicture_Click);
            // 
            // FormBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.stopPicture);
            this.Controls.Add(this.searchPicture);
            this.Controls.Add(this.urlSearchPicture);
            this.Controls.Add(this.addToFavPicture);
            this.Controls.Add(this.urlSearchBar);
            this.Controls.Add(this.refreshPicture);
            this.Controls.Add(this.forwardPicture);
            this.Controls.Add(this.backPicture);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchBar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormBrowser";
            this.Text = "Поиск и точка";
            this.Load += new System.EventHandler(this.FormBrowser_Load);
            this.Resize += new System.EventHandler(this.FormBrowser_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.stopPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addToFavPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.forwardPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backPicture)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.urlSearchPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TextBox searchBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox backPicture;
        private System.Windows.Forms.PictureBox forwardPicture;
        private System.Windows.Forms.PictureBox refreshPicture;
        private System.Windows.Forms.TextBox urlSearchBar;
        private System.Windows.Forms.PictureBox addToFavPicture;
        private System.Windows.Forms.PictureBox searchPicture;
        private System.Windows.Forms.PictureBox stopPicture;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem закладкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem историяToolStripMenuItem;
        private System.Windows.Forms.PictureBox urlSearchPicture;
    }
}

