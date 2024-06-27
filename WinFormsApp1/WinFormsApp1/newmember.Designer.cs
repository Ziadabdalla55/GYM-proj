namespace WinFormsApp1
{
    partial class newmember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(newmember));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            addbtn = new Button();
            nametxt = new TextBox();
            agetxt = new TextBox();
            phonetxt = new TextBox();
            weighttxt = new TextBox();
            lengthtxt = new TextBox();
            label9 = new Label();
            malerdn = new RadioButton();
            femalerdn = new RadioButton();
            label10 = new Label();
            coachbox = new ComboBox();
            label11 = new Label();
            planbox = new ComboBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(283, 28);
            label1.Name = "label1";
            label1.Size = new Size(243, 37);
            label1.TabIndex = 0;
            label1.Text = "New Subscription";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(10, 76);
            label2.Name = "label2";
            label2.Size = new Size(156, 30);
            label2.TabIndex = 1;
            label2.Text = "Member Data";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(10, 122);
            label3.Name = "label3";
            label3.Size = new Size(52, 21);
            label3.TabIndex = 2;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(10, 152);
            label4.Name = "label4";
            label4.Size = new Size(37, 21);
            label4.TabIndex = 3;
            label4.Text = "Age";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(10, 184);
            label5.Name = "label5";
            label5.Size = new Size(82, 21);
            label5.TabIndex = 4;
            label5.Text = "Phone NO";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.ForeColor = Color.White;
            label6.Location = new Point(10, 223);
            label6.Name = "label6";
            label6.Size = new Size(0, 15);
            label6.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(10, 216);
            label7.Name = "label7";
            label7.Size = new Size(59, 21);
            label7.TabIndex = 6;
            label7.Text = "Weight";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(10, 245);
            label8.Name = "label8";
            label8.Size = new Size(58, 21);
            label8.TabIndex = 7;
            label8.Text = "Length";
            // 
            // addbtn
            // 
            addbtn.BackColor = Color.White;
            addbtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            addbtn.Location = new Point(651, 422);
            addbtn.Margin = new Padding(3, 2, 3, 2);
            addbtn.Name = "addbtn";
            addbtn.Size = new Size(130, 38);
            addbtn.TabIndex = 8;
            addbtn.Text = "ADD";
            addbtn.UseVisualStyleBackColor = false;
            addbtn.MouseDown += addbtn_MouseDown;
            // 
            // nametxt
            // 
            nametxt.Location = new Point(105, 124);
            nametxt.Margin = new Padding(3, 2, 3, 2);
            nametxt.Name = "nametxt";
            nametxt.Size = new Size(163, 23);
            nametxt.TabIndex = 9;
            // 
            // agetxt
            // 
            agetxt.Location = new Point(105, 155);
            agetxt.Margin = new Padding(3, 2, 3, 2);
            agetxt.Name = "agetxt";
            agetxt.Size = new Size(163, 23);
            agetxt.TabIndex = 10;
            // 
            // phonetxt
            // 
            phonetxt.Location = new Point(105, 184);
            phonetxt.Margin = new Padding(3, 2, 3, 2);
            phonetxt.Name = "phonetxt";
            phonetxt.Size = new Size(163, 23);
            phonetxt.TabIndex = 11;
            // 
            // weighttxt
            // 
            weighttxt.Location = new Point(105, 216);
            weighttxt.Margin = new Padding(3, 2, 3, 2);
            weighttxt.Name = "weighttxt";
            weighttxt.Size = new Size(163, 23);
            weighttxt.TabIndex = 12;
            // 
            // lengthtxt
            // 
            lengthtxt.Location = new Point(105, 248);
            lengthtxt.Margin = new Padding(3, 2, 3, 2);
            lengthtxt.Name = "lengthtxt";
            lengthtxt.Size = new Size(163, 23);
            lengthtxt.TabIndex = 13;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(10, 307);
            label9.Name = "label9";
            label9.Size = new Size(89, 30);
            label9.TabIndex = 14;
            label9.Text = "Gender";
            // 
            // malerdn
            // 
            malerdn.AutoSize = true;
            malerdn.BackColor = SystemColors.ActiveCaptionText;
            malerdn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            malerdn.ForeColor = Color.White;
            malerdn.Location = new Point(23, 352);
            malerdn.Margin = new Padding(3, 2, 3, 2);
            malerdn.Name = "malerdn";
            malerdn.Size = new Size(66, 25);
            malerdn.TabIndex = 15;
            malerdn.Text = "Male";
            malerdn.UseVisualStyleBackColor = false;
            // 
            // femalerdn
            // 
            femalerdn.AutoSize = true;
            femalerdn.BackColor = Color.Black;
            femalerdn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            femalerdn.ForeColor = Color.White;
            femalerdn.Location = new Point(113, 352);
            femalerdn.Margin = new Padding(3, 2, 3, 2);
            femalerdn.Name = "femalerdn";
            femalerdn.Size = new Size(83, 25);
            femalerdn.TabIndex = 16;
            femalerdn.Text = "Female";
            femalerdn.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(633, 76);
            label10.Name = "label10";
            label10.Size = new Size(83, 32);
            label10.TabIndex = 17;
            label10.Text = "Coach";
            // 
            // coachbox
            // 
            coachbox.FormattingEnabled = true;
            coachbox.Items.AddRange(new object[] { "abdallah", "ali", "zeid", "mostafa" });
            coachbox.Location = new Point(633, 124);
            coachbox.Margin = new Padding(3, 2, 3, 2);
            coachbox.Name = "coachbox";
            coachbox.Size = new Size(148, 23);
            coachbox.TabIndex = 18;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.ButtonHighlight;
            label11.Location = new Point(633, 177);
            label11.Name = "label11";
            label11.Size = new Size(64, 32);
            label11.TabIndex = 19;
            label11.Text = "Plan";
            // 
            // planbox
            // 
            planbox.FormattingEnabled = true;
            planbox.Items.AddRange(new object[] { "1 Month 300 L.E", "3 Monath 800 L.E", "6 Monath 1500 L.E", "12 Monath 2500 L.E" });
            planbox.Location = new Point(633, 231);
            planbox.Margin = new Padding(3, 2, 3, 2);
            planbox.Name = "planbox";
            planbox.Size = new Size(148, 23);
            planbox.TabIndex = 20;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(478, 422);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(130, 38);
            button1.TabIndex = 21;
            button1.Text = "BACK";
            button1.UseVisualStyleBackColor = false;
            button1.MouseDown += button1_MouseDown;
            // 
            // newmember
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(843, 485);
            Controls.Add(button1);
            Controls.Add(planbox);
            Controls.Add(label11);
            Controls.Add(coachbox);
            Controls.Add(label10);
            Controls.Add(femalerdn);
            Controls.Add(malerdn);
            Controls.Add(label9);
            Controls.Add(lengthtxt);
            Controls.Add(weighttxt);
            Controls.Add(phonetxt);
            Controls.Add(agetxt);
            Controls.Add(nametxt);
            Controls.Add(addbtn);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "newmember";
            Text = "newmember";
            Load += newmember_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button addbtn;
        private TextBox nametxt;
        private TextBox agetxt;
        private TextBox phonetxt;
        private TextBox weighttxt;
        private TextBox lengthtxt;
        private Label label9;
        private RadioButton malerdn;
        private RadioButton femalerdn;
        private Label label10;
        private ComboBox coachbox;
        private Label label11;
        private ComboBox planbox;
        private Button button1;
    }
}