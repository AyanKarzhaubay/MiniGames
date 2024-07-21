namespace Snake
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
            this.components = new System.ComponentModel.Container();
            this.labelScoreText = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.labelGameResult = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.highScoreTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToPlayItToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelEatYourself = new System.Windows.Forms.Label();
            this.pictureBoxBG = new System.Windows.Forms.PictureBox();
            this.pictureBoxCanvas = new System.Windows.Forms.PictureBox();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // labelScoreText
            // 
            this.labelScoreText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelScoreText.AutoSize = true;
            this.labelScoreText.BackColor = System.Drawing.Color.OliveDrab;
            this.labelScoreText.Font = new System.Drawing.Font("Consolas", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelScoreText.ForeColor = System.Drawing.Color.Gold;
            this.labelScoreText.Location = new System.Drawing.Point(508, 193);
            this.labelScoreText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelScoreText.Name = "labelScoreText";
            this.labelScoreText.Size = new System.Drawing.Size(180, 55);
            this.labelScoreText.TabIndex = 1;
            this.labelScoreText.Text = "Score:";
            // 
            // labelScore
            // 
            this.labelScore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelScore.AutoSize = true;
            this.labelScore.BackColor = System.Drawing.Color.OliveDrab;
            this.labelScore.Font = new System.Drawing.Font("Consolas", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelScore.ForeColor = System.Drawing.Color.Gold;
            this.labelScore.Location = new System.Drawing.Point(833, 160);
            this.labelScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(50, 55);
            this.labelScore.TabIndex = 2;
            this.labelScore.Text = "0";
            // 
            // labelGameResult
            // 
            this.labelGameResult.AutoSize = true;
            this.labelGameResult.BackColor = System.Drawing.Color.Olive;
            this.labelGameResult.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGameResult.Location = new System.Drawing.Point(580, 315);
            this.labelGameResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGameResult.Name = "labelGameResult";
            this.labelGameResult.Size = new System.Drawing.Size(350, 47);
            this.labelGameResult.TabIndex = 3;
            this.labelGameResult.Text = "labelGameResult";
            this.labelGameResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelGameResult.Visible = false;
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1600, 35);
            this.menuStrip.TabIndex = 4;
            this.menuStrip.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.highScoreTableToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(83, 31);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(315, 32);
            this.newGameToolStripMenuItem.Text = "New game               F2";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // highScoreTableToolStripMenuItem
            // 
            this.highScoreTableToolStripMenuItem.Name = "highScoreTableToolStripMenuItem";
            this.highScoreTableToolStripMenuItem.Size = new System.Drawing.Size(315, 32);
            this.highScoreTableToolStripMenuItem.Text = "High score table";
            this.highScoreTableToolStripMenuItem.Click += new System.EventHandler(this.highScoreTableToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(315, 32);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.howToPlayItToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(72, 31);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // howToPlayItToolStripMenuItem
            // 
            this.howToPlayItToolStripMenuItem.Name = "howToPlayItToolStripMenuItem";
            this.howToPlayItToolStripMenuItem.Size = new System.Drawing.Size(245, 32);
            this.howToPlayItToolStripMenuItem.Text = "How to play it?";
            this.howToPlayItToolStripMenuItem.Click += new System.EventHandler(this.howToPlayItToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(245, 32);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // labelEatYourself
            // 
            this.labelEatYourself.AutoSize = true;
            this.labelEatYourself.BackColor = System.Drawing.Color.Olive;
            this.labelEatYourself.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEatYourself.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelEatYourself.Location = new System.Drawing.Point(1005, 215);
            this.labelEatYourself.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEatYourself.Name = "labelEatYourself";
            this.labelEatYourself.Size = new System.Drawing.Size(246, 27);
            this.labelEatYourself.TabIndex = 7;
            this.labelEatYourself.Text = "Fu, I\'m not tasty!";
            // 
            // pictureBoxBG
            // 
            this.pictureBoxBG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxBG.Image = global::Snake.Properties.Resources.grass;
            this.pictureBoxBG.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxBG.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxBG.Name = "pictureBoxBG";
            this.pictureBoxBG.Size = new System.Drawing.Size(1600, 869);
            this.pictureBoxBG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBG.TabIndex = 8;
            this.pictureBoxBG.TabStop = false;
            // 
            // pictureBoxCanvas
            // 
            this.pictureBoxCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxCanvas.Location = new System.Drawing.Point(156, 105);
            this.pictureBoxCanvas.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxCanvas.Name = "pictureBoxCanvas";
            this.pictureBoxCanvas.Size = new System.Drawing.Size(1291, 668);
            this.pictureBoxCanvas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxCanvas.TabIndex = 0;
            this.pictureBoxCanvas.TabStop = false;
            this.pictureBoxCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxCanvas_Paint);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 869);
            this.Controls.Add(this.labelEatYourself);
            this.Controls.Add(this.labelScoreText);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.labelGameResult);
            this.Controls.Add(this.pictureBoxCanvas);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.pictureBoxBG);
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Snake";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyUp);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelScoreText;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label labelGameResult;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem highScoreTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howToPlayItToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label labelEatYourself;
        private System.Windows.Forms.PictureBox pictureBoxBG;
        private System.Windows.Forms.PictureBox pictureBoxCanvas;
    }
}

