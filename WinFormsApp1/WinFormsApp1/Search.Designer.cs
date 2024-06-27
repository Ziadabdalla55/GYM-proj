namespace WinFormsApp1
{
    partial class Search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search));
            searchphonetxt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            deletbtn = new Button();
            existbtn = new Button();
            okbtn = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // searchphonetxt
            // 
            searchphonetxt.Location = new Point(126, 89);
            searchphonetxt.Margin = new Padding(3, 2, 3, 2);
            searchphonetxt.Name = "searchphonetxt";
            searchphonetxt.Size = new Size(176, 23);
            searchphonetxt.TabIndex = 0;
            searchphonetxt.TextChanged += searchphonetxt_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(10, 88);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 1;
            label1.Text = "Enter Phone";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(345, 19);
            label2.Name = "label2";
            label2.Size = new Size(102, 37);
            label2.TabIndex = 2;
            label2.Text = "Search";
            // 
            // deletbtn
            // 
            deletbtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            deletbtn.Location = new Point(496, 424);
            deletbtn.Margin = new Padding(3, 2, 3, 2);
            deletbtn.Name = "deletbtn";
            deletbtn.Size = new Size(136, 40);
            deletbtn.TabIndex = 3;
            deletbtn.Text = "DELET";
            deletbtn.UseVisualStyleBackColor = true;
            deletbtn.MouseDown += deletbtn_MouseDown;
            // 
            // existbtn
            // 
            existbtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            existbtn.Location = new Point(684, 424);
            existbtn.Margin = new Padding(3, 2, 3, 2);
            existbtn.Name = "existbtn";
            existbtn.Size = new Size(136, 40);
            existbtn.TabIndex = 4;
            existbtn.Text = "EXIT";
            existbtn.UseVisualStyleBackColor = true;
            existbtn.Click += existbtn_Click;
            existbtn.MouseDown += existbtn_MouseDown;
            // 
            // okbtn
            // 
            okbtn.Location = new Point(145, 143);
            okbtn.Margin = new Padding(3, 2, 3, 2);
            okbtn.Name = "okbtn";
            okbtn.Size = new Size(108, 22);
            okbtn.TabIndex = 5;
            okbtn.Text = "OK";
            okbtn.UseVisualStyleBackColor = true;
            okbtn.MouseDown += okbtn_MouseDown;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(318, 424);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(136, 40);
            button1.TabIndex = 6;
            button1.Text = "BACK";
            button1.UseVisualStyleBackColor = true;
            button1.MouseDown += button1_MouseDown;
            // 
            // Search
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(843, 485);
            Controls.Add(button1);
            Controls.Add(okbtn);
            Controls.Add(existbtn);
            Controls.Add(deletbtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(searchphonetxt);
            DoubleBuffered = true;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Search";
            Text = "Search";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox searchphonetxt;
        private Label label1;
        private Label label2;
        private Button deletbtn;
        private Button existbtn;
        private Button okbtn;
        private Button button1;
    }
}