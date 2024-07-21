namespace TicTacToe
{
    partial class FillingOutForm
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
            this.p1 = new System.Windows.Forms.Label();
            this.player1NameTextBox = new System.Windows.Forms.TextBox();
            this.player2NameTextBox = new System.Windows.Forms.TextBox();
            this.p2 = new System.Windows.Forms.Label();
            this.playButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // p1
            // 
            this.p1.AutoSize = true;
            this.p1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.p1.Location = new System.Drawing.Point(40, 54);
            this.p1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(138, 39);
            this.p1.TabIndex = 0;
            this.p1.Text = "Player 1:";
            // 
            // player1NameTextBox
            // 
            this.player1NameTextBox.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.player1NameTextBox.Location = new System.Drawing.Point(200, 44);
            this.player1NameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.player1NameTextBox.Name = "player1NameTextBox";
            this.player1NameTextBox.Size = new System.Drawing.Size(403, 46);
            this.player1NameTextBox.TabIndex = 1;
            this.player1NameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // player2NameTextBox
            // 
            this.player2NameTextBox.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.player2NameTextBox.Location = new System.Drawing.Point(200, 112);
            this.player2NameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.player2NameTextBox.Name = "player2NameTextBox";
            this.player2NameTextBox.Size = new System.Drawing.Size(403, 46);
            this.player2NameTextBox.TabIndex = 3;
            this.player2NameTextBox.Text = "Computer";
            this.player2NameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // p2
            // 
            this.p2.AutoSize = true;
            this.p2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.p2.Location = new System.Drawing.Point(40, 122);
            this.p2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(138, 39);
            this.p2.TabIndex = 2;
            this.p2.Text = "Player 2:";
            // 
            // playButton
            // 
            this.playButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.ForeColor = System.Drawing.Color.Red;
            this.playButton.Location = new System.Drawing.Point(421, 180);
            this.playButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(183, 54);
            this.playButton.TabIndex = 4;
            this.playButton.Text = "Fight!";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // FillingOutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 250);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.player2NameTextBox);
            this.Controls.Add(this.p2);
            this.Controls.Add(this.player1NameTextBox);
            this.Controls.Add(this.p1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(661, 297);
            this.MinimumSize = new System.Drawing.Size(661, 297);
            this.Name = "FillingOutForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicTacToe";
            this.Load += new System.EventHandler(this.FillingOutForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label p1;
        private System.Windows.Forms.TextBox player1NameTextBox;
        private System.Windows.Forms.TextBox player2NameTextBox;
        private System.Windows.Forms.Label p2;
        private System.Windows.Forms.Button playButton;
    }
}