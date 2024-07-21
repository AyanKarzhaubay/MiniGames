namespace MiniGames
{
    partial class MainMenu
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
            this.buttonTicTacToe = new System.Windows.Forms.Button();
            this.buttonSnake = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonTicTacToe
            // 
            this.buttonTicTacToe.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTicTacToe.Location = new System.Drawing.Point(62, 80);
            this.buttonTicTacToe.Name = "buttonTicTacToe";
            this.buttonTicTacToe.Size = new System.Drawing.Size(202, 48);
            this.buttonTicTacToe.TabIndex = 0;
            this.buttonTicTacToe.Text = "TicTacToe";
            this.buttonTicTacToe.UseVisualStyleBackColor = true;
            this.buttonTicTacToe.Click += new System.EventHandler(this.buttonTicTacToe_Click);
            // 
            // buttonSnake
            // 
            this.buttonSnake.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSnake.Location = new System.Drawing.Point(62, 154);
            this.buttonSnake.Name = "buttonSnake";
            this.buttonSnake.Size = new System.Drawing.Size(202, 48);
            this.buttonSnake.TabIndex = 1;
            this.buttonSnake.Text = "Snake";
            this.buttonSnake.UseVisualStyleBackColor = true;
            this.buttonSnake.Click += new System.EventHandler(this.buttonSnake_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.Location = new System.Drawing.Point(62, 230);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(202, 48);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonSnake);
            this.Controls.Add(this.buttonTicTacToe);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonTicTacToe;
        private System.Windows.Forms.Button buttonSnake;
        private System.Windows.Forms.Button buttonExit;
    }
}