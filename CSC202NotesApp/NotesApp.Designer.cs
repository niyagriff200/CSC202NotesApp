namespace CSC202NotesApp
{
    partial class NotesApp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotesApp));
            lb_Title = new Label();
            lb_Week1Heading = new Label();
            rtb_Week1Notes = new RichTextBox();
            pn_Body = new Panel();
            textBox1 = new TextBox();
            pictureBox2 = new PictureBox();
            rtb_PictureBoxNote = new RichTextBox();
            pictureBox1 = new PictureBox();
            btn_MistyOrchid = new Button();
            richTextBox1 = new RichTextBox();
            btn_MidnightGhost = new Button();
            tb_buttons = new TextBox();
            tb_userTextbox = new TextBox();
            pn_Navigation = new Panel();
            llb_Week1Nav = new LinkLabel();
            lb_NavTitle = new Label();
            pn_Body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pn_Navigation.SuspendLayout();
            SuspendLayout();
            // 
            // lb_Title
            // 
            lb_Title.AutoSize = true;
            lb_Title.BackColor = Color.Transparent;
            lb_Title.Font = new Font("Freestyle Script", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_Title.ForeColor = Color.FromArgb(217, 122, 122);
            lb_Title.Location = new Point(506, 24);
            lb_Title.Name = "lb_Title";
            lb_Title.Size = new Size(366, 95);
            lb_Title.TabIndex = 0;
            lb_Title.Text = "CSC202 Notes";
            // 
            // lb_Week1Heading
            // 
            lb_Week1Heading.AutoSize = true;
            lb_Week1Heading.Font = new Font("Freestyle Script", 15.9000006F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_Week1Heading.ForeColor = Color.FromArgb(217, 122, 122);
            lb_Week1Heading.Location = new Point(106, 98);
            lb_Week1Heading.Name = "lb_Week1Heading";
            lb_Week1Heading.Size = new Size(145, 64);
            lb_Week1Heading.TabIndex = 1;
            lb_Week1Heading.Text = "Week 1";
            lb_Week1Heading.Click += lb_Week1_Click;
            // 
            // rtb_Week1Notes
            // 
            rtb_Week1Notes.BackColor = Color.FromArgb(247, 243, 238);
            rtb_Week1Notes.Font = new Font("Freestyle Script", 11.1F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rtb_Week1Notes.ForeColor = Color.FromArgb(46, 46, 46);
            rtb_Week1Notes.Location = new Point(106, 175);
            rtb_Week1Notes.Name = "rtb_Week1Notes";
            rtb_Week1Notes.ReadOnly = true;
            rtb_Week1Notes.Size = new Size(1123, 141);
            rtb_Week1Notes.TabIndex = 2;
            rtb_Week1Notes.Text = resources.GetString("rtb_Week1Notes.Text");
            // 
            // pn_Body
            // 
            pn_Body.AutoScroll = true;
            pn_Body.BackColor = Color.FromArgb(247, 243, 238);
            pn_Body.Controls.Add(textBox1);
            pn_Body.Controls.Add(pictureBox2);
            pn_Body.Controls.Add(rtb_PictureBoxNote);
            pn_Body.Controls.Add(pictureBox1);
            pn_Body.Controls.Add(btn_MistyOrchid);
            pn_Body.Controls.Add(richTextBox1);
            pn_Body.Controls.Add(btn_MidnightGhost);
            pn_Body.Controls.Add(tb_buttons);
            pn_Body.Controls.Add(tb_userTextbox);
            pn_Body.Controls.Add(lb_Title);
            pn_Body.Controls.Add(lb_Week1Heading);
            pn_Body.Controls.Add(rtb_Week1Notes);
            pn_Body.Location = new Point(426, 4);
            pn_Body.Name = "pn_Body";
            pn_Body.Size = new Size(1359, 1020);
            pn_Body.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(247, 243, 238);
            textBox1.Font = new Font("Freestyle Script", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(178, 1129);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(497, 55);
            textBox1.TabIndex = 11;
            textBox1.Text = "I made this in Krita, how did I do? ->";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.BW_Waterview;
            pictureBox2.Location = new Point(693, 1053);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(579, 387);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // rtb_PictureBoxNote
            // 
            rtb_PictureBoxNote.BackColor = Color.FromArgb(247, 243, 238);
            rtb_PictureBoxNote.Font = new Font("Freestyle Script", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rtb_PictureBoxNote.ForeColor = Color.FromArgb(46, 46, 46);
            rtb_PictureBoxNote.Location = new Point(707, 724);
            rtb_PictureBoxNote.Name = "rtb_PictureBoxNote";
            rtb_PictureBoxNote.ReadOnly = true;
            rtb_PictureBoxNote.Size = new Size(536, 305);
            rtb_PictureBoxNote.TabIndex = 9;
            rtb_PictureBoxNote.Text = resources.GetString("rtb_PictureBoxNote.Text");
            rtb_PictureBoxNote.TextChanged += rtb_PictureBoxNote_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.AppleSceneCycles;
            pictureBox1.Location = new Point(106, 665);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(569, 383);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // btn_MistyOrchid
            // 
            btn_MistyOrchid.BackColor = Color.MistyRose;
            btn_MistyOrchid.ForeColor = Color.Orchid;
            btn_MistyOrchid.Location = new Point(1058, 613);
            btn_MistyOrchid.Name = "btn_MistyOrchid";
            btn_MistyOrchid.Size = new Size(239, 58);
            btn_MistyOrchid.TabIndex = 7;
            btn_MistyOrchid.Text = "MistyOrchid";
            btn_MistyOrchid.UseVisualStyleBackColor = false;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.FromArgb(247, 243, 238);
            richTextBox1.Font = new Font("Freestyle Script", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            richTextBox1.ForeColor = Color.FromArgb(46, 46, 46);
            richTextBox1.Location = new Point(106, 524);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(924, 147);
            richTextBox1.TabIndex = 6;
            richTextBox1.Text = "The button is named MidnightBlue because of the colors MidnightBlue and GhostWhite, which are the colors the button uses. Can you guess why I named that button MistyOrchid? ->";
            // 
            // btn_MidnightGhost
            // 
            btn_MidnightGhost.BackColor = Color.MidnightBlue;
            btn_MidnightGhost.ForeColor = Color.GhostWhite;
            btn_MidnightGhost.Location = new Point(803, 436);
            btn_MidnightGhost.Name = "btn_MidnightGhost";
            btn_MidnightGhost.Size = new Size(273, 58);
            btn_MidnightGhost.TabIndex = 5;
            btn_MidnightGhost.Text = "MidnightGhost";
            btn_MidnightGhost.UseVisualStyleBackColor = false;
            // 
            // tb_buttons
            // 
            tb_buttons.BackColor = Color.FromArgb(247, 243, 238);
            tb_buttons.Font = new Font("Freestyle Script", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tb_buttons.ForeColor = Color.FromArgb(46, 46, 46);
            tb_buttons.Location = new Point(106, 436);
            tb_buttons.Name = "tb_buttons";
            tb_buttons.ReadOnly = true;
            tb_buttons.Size = new Size(641, 55);
            tb_buttons.TabIndex = 4;
            tb_buttons.Text = "Something else that's cool are the buttons ->\r\n";
            // 
            // tb_userTextbox
            // 
            tb_userTextbox.Font = new Font("Freestyle Script", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_userTextbox.Location = new Point(106, 322);
            tb_userTextbox.Name = "tb_userTextbox";
            tb_userTextbox.PlaceholderText = "Here's a textbox for you to type in...";
            tb_userTextbox.Size = new Size(526, 55);
            tb_userTextbox.TabIndex = 3;
            // 
            // pn_Navigation
            // 
            pn_Navigation.BackColor = Color.FromArgb(199, 184, 166);
            pn_Navigation.Controls.Add(llb_Week1Nav);
            pn_Navigation.Controls.Add(lb_NavTitle);
            pn_Navigation.Location = new Point(1, 4);
            pn_Navigation.Name = "pn_Navigation";
            pn_Navigation.Size = new Size(429, 1017);
            pn_Navigation.TabIndex = 4;
            // 
            // llb_Week1Nav
            // 
            llb_Week1Nav.ActiveLinkColor = Color.FromArgb(79, 111, 163);
            llb_Week1Nav.AutoSize = true;
            llb_Week1Nav.BackColor = Color.Transparent;
            llb_Week1Nav.Font = new Font("Freestyle Script", 15.9000006F, FontStyle.Bold, GraphicsUnit.Point, 0);
            llb_Week1Nav.ForeColor = Color.FromArgb(46, 46, 46);
            llb_Week1Nav.LinkColor = Color.FromArgb(106, 143, 191);
            llb_Week1Nav.Location = new Point(64, 111);
            llb_Week1Nav.Name = "llb_Week1Nav";
            llb_Week1Nav.Size = new Size(145, 64);
            llb_Week1Nav.TabIndex = 1;
            llb_Week1Nav.TabStop = true;
            llb_Week1Nav.Text = "Week 1";
            llb_Week1Nav.VisitedLinkColor = Color.FromArgb(140, 127, 191);
            // 
            // lb_NavTitle
            // 
            lb_NavTitle.AutoSize = true;
            lb_NavTitle.Font = new Font("Freestyle Script", 24F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lb_NavTitle.ForeColor = Color.FromArgb(46, 46, 46);
            lb_NavTitle.Location = new Point(50, 24);
            lb_NavTitle.Name = "lb_NavTitle";
            lb_NavTitle.Size = new Size(181, 95);
            lb_NavTitle.TabIndex = 0;
            lb_NavTitle.Text = "Weeks";
            // 
            // NotesApp
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1783, 1017);
            Controls.Add(pn_Navigation);
            Controls.Add(pn_Body);
            Name = "NotesApp";
            Text = "CSC202 Notes App";
            pn_Body.ResumeLayout(false);
            pn_Body.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pn_Navigation.ResumeLayout(false);
            pn_Navigation.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lb_Title;
        private Label lb_Week1Heading;
        private RichTextBox rtb_Week1Notes;
        private Panel pn_Body;
        private Panel pn_Navigation;
        private Label lb_NavTitle;
        private LinkLabel llb_Week1Nav;
        private TextBox tb_userTextbox;
        private TextBox tb_buttons;
        private Button btn_MidnightGhost;
        private Button btn_MistyOrchid;
        private RichTextBox richTextBox1;
        private PictureBox pictureBox1;
        private RichTextBox rtb_PictureBoxNote;
        private PictureBox pictureBox2;
        private TextBox textBox1;
    }
}
