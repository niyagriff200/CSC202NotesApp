namespace CSC202NotesApp
{
    partial class Week4
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
            btnBack = new Button();
            lbCardGame = new Label();
            pnWeek4Body = new Panel();
            btnClearErrors = new Button();
            btnGenerateErrors = new Button();
            lbErrorLogs = new ListBox();
            lbErrorLogHeading = new Label();
            lbGuessHeading = new Label();
            btnAce = new Button();
            btnJack = new Button();
            btnQueen = new Button();
            btnKing = new Button();
            lbMessages = new ListBox();
            btnGenerateCard = new Button();
            pnWeek4Body.SuspendLayout();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Location = new Point(1045, 16);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(188, 58);
            btnBack.TabIndex = 0;
            btnBack.Text = "Go Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // lbCardGame
            // 
            lbCardGame.AutoSize = true;
            lbCardGame.Font = new Font("Freestyle Script", 15.9000006F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbCardGame.ForeColor = Color.FromArgb(217, 122, 122);
            lbCardGame.Location = new Point(123, 118);
            lbCardGame.Name = "lbCardGame";
            lbCardGame.Size = new Size(187, 64);
            lbCardGame.TabIndex = 1;
            lbCardGame.Text = "Card Game";
            // 
            // pnWeek4Body
            // 
            pnWeek4Body.AutoScroll = true;
            pnWeek4Body.BackColor = Color.FromArgb(247, 243, 238);
            pnWeek4Body.Controls.Add(btnClearErrors);
            pnWeek4Body.Controls.Add(btnGenerateErrors);
            pnWeek4Body.Controls.Add(lbErrorLogs);
            pnWeek4Body.Controls.Add(lbErrorLogHeading);
            pnWeek4Body.Controls.Add(lbGuessHeading);
            pnWeek4Body.Controls.Add(btnAce);
            pnWeek4Body.Controls.Add(btnJack);
            pnWeek4Body.Controls.Add(btnQueen);
            pnWeek4Body.Controls.Add(btnKing);
            pnWeek4Body.Controls.Add(lbMessages);
            pnWeek4Body.Controls.Add(btnGenerateCard);
            pnWeek4Body.Controls.Add(lbCardGame);
            pnWeek4Body.Controls.Add(btnBack);
            pnWeek4Body.Location = new Point(-2, -4);
            pnWeek4Body.Name = "pnWeek4Body";
            pnWeek4Body.Size = new Size(1387, 959);
            pnWeek4Body.TabIndex = 2;
            // 
            // btnClearErrors
            // 
            btnClearErrors.BackColor = Color.FromArgb(0, 192, 192);
            btnClearErrors.ForeColor = Color.OldLace;
            btnClearErrors.Location = new Point(552, 819);
            btnClearErrors.Name = "btnClearErrors";
            btnClearErrors.Size = new Size(247, 58);
            btnClearErrors.TabIndex = 13;
            btnClearErrors.Text = "Clear Errors";
            btnClearErrors.UseVisualStyleBackColor = false;
            btnClearErrors.Click += btnClearErrors_Click;
            // 
            // btnGenerateErrors
            // 
            btnGenerateErrors.BackColor = Color.FromArgb(192, 0, 192);
            btnGenerateErrors.ForeColor = Color.FloralWhite;
            btnGenerateErrors.Location = new Point(123, 819);
            btnGenerateErrors.Name = "btnGenerateErrors";
            btnGenerateErrors.Size = new Size(247, 58);
            btnGenerateErrors.TabIndex = 12;
            btnGenerateErrors.Text = "Generate Errors";
            btnGenerateErrors.UseVisualStyleBackColor = false;
            btnGenerateErrors.Click += btnGenerateErrors_Click;
            // 
            // lbErrorLogs
            // 
            lbErrorLogs.FormattingEnabled = true;
            lbErrorLogs.Location = new Point(123, 906);
            lbErrorLogs.Name = "lbErrorLogs";
            lbErrorLogs.Size = new Size(1218, 250);
            lbErrorLogs.TabIndex = 11;
            // 
            // lbErrorLogHeading
            // 
            lbErrorLogHeading.AutoSize = true;
            lbErrorLogHeading.Font = new Font("Freestyle Script", 15.9000006F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbErrorLogHeading.ForeColor = Color.FromArgb(217, 122, 122);
            lbErrorLogHeading.Location = new Point(123, 713);
            lbErrorLogHeading.Name = "lbErrorLogHeading";
            lbErrorLogHeading.Size = new Size(194, 64);
            lbErrorLogHeading.TabIndex = 10;
            lbErrorLogHeading.Text = "Error Logs";
            // 
            // lbGuessHeading
            // 
            lbGuessHeading.AutoSize = true;
            lbGuessHeading.Font = new Font("Freestyle Script", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbGuessHeading.ForeColor = Color.FromArgb(217, 122, 122);
            lbGuessHeading.Location = new Point(1028, 246);
            lbGuessHeading.Name = "lbGuessHeading";
            lbGuessHeading.Size = new Size(196, 47);
            lbGuessHeading.TabIndex = 9;
            lbGuessHeading.Text = "Guess the Card";
            // 
            // btnAce
            // 
            btnAce.BackColor = Color.Yellow;
            btnAce.Enabled = false;
            btnAce.ForeColor = Color.DarkSlateGray;
            btnAce.Location = new Point(1028, 543);
            btnAce.Name = "btnAce";
            btnAce.Size = new Size(188, 58);
            btnAce.TabIndex = 8;
            btnAce.Text = "Ace";
            btnAce.UseVisualStyleBackColor = false;
            btnAce.Click += btnAce_Click;
            // 
            // btnJack
            // 
            btnJack.BackColor = Color.Lime;
            btnJack.Enabled = false;
            btnJack.ForeColor = Color.Azure;
            btnJack.Location = new Point(1028, 469);
            btnJack.Name = "btnJack";
            btnJack.Size = new Size(188, 58);
            btnJack.TabIndex = 7;
            btnJack.Text = "Jack";
            btnJack.UseVisualStyleBackColor = false;
            btnJack.Click += btnJack_Click;
            // 
            // btnQueen
            // 
            btnQueen.BackColor = Color.FromArgb(255, 128, 0);
            btnQueen.Enabled = false;
            btnQueen.ForeColor = Color.MintCream;
            btnQueen.Location = new Point(1028, 391);
            btnQueen.Name = "btnQueen";
            btnQueen.Size = new Size(188, 58);
            btnQueen.TabIndex = 6;
            btnQueen.Text = "Queen";
            btnQueen.UseVisualStyleBackColor = false;
            btnQueen.Click += btnQueen_Click;
            // 
            // btnKing
            // 
            btnKing.BackColor = Color.Red;
            btnKing.Enabled = false;
            btnKing.ForeColor = Color.Honeydew;
            btnKing.Location = new Point(1028, 310);
            btnKing.Name = "btnKing";
            btnKing.Size = new Size(188, 58);
            btnKing.TabIndex = 5;
            btnKing.Text = "King";
            btnKing.UseVisualStyleBackColor = false;
            btnKing.Click += btnKing_Click;
            // 
            // lbMessages
            // 
            lbMessages.FormattingEnabled = true;
            lbMessages.Location = new Point(123, 310);
            lbMessages.Name = "lbMessages";
            lbMessages.Size = new Size(845, 332);
            lbMessages.TabIndex = 4;
            // 
            // btnGenerateCard
            // 
            btnGenerateCard.BackColor = Color.DarkMagenta;
            btnGenerateCard.ForeColor = Color.MistyRose;
            btnGenerateCard.Location = new Point(123, 214);
            btnGenerateCard.Name = "btnGenerateCard";
            btnGenerateCard.Size = new Size(273, 51);
            btnGenerateCard.TabIndex = 3;
            btnGenerateCard.Text = "Generate Card";
            btnGenerateCard.UseVisualStyleBackColor = false;
            btnGenerateCard.Click += btnGenerateCard_Click;
            // 
            // Week4
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1386, 957);
            Controls.Add(pnWeek4Body);
            Name = "Week4";
            Text = "Week 4 ";
            FormClosing += Week4_FormClosing;
            pnWeek4Body.ResumeLayout(false);
            pnWeek4Body.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnBack;
        private Label lbCardGame;
        private Panel pnWeek4Body;
        private Button btnGenerateCard;
        private Label lbGuessHeading;
        private Button btnAce;
        private Button btnJack;
        private Button btnQueen;
        private Button btnKing;
        private ListBox lbMessages;
        private Label lbErrorLogHeading;
        private ListBox lbErrorLogs;
        private Button btnGenerateErrors;
        private Button btnClearErrors;
    }
}