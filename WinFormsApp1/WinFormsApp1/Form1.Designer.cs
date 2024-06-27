namespace WinFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            newmemberbtn = new Button();
            searchbtn = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // newmemberbtn
            // 
            newmemberbtn.BackColor = Color.White;
            newmemberbtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            newmemberbtn.ForeColor = Color.Black;
            newmemberbtn.Location = new Point(429, 524);
            newmemberbtn.Name = "newmemberbtn";
            newmemberbtn.Size = new Size(183, 54);
            newmemberbtn.TabIndex = 0;
            newmemberbtn.Text = "New Member";
            newmemberbtn.UseVisualStyleBackColor = false;
            newmemberbtn.Click += button1_Click;
            newmemberbtn.MouseDown += newmemberbtn_MouseDown;
            // 
            // searchbtn
            // 
            searchbtn.BackColor = Color.White;
            searchbtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            searchbtn.ForeColor = Color.Black;
            searchbtn.Location = new Point(649, 524);
            searchbtn.Name = "searchbtn";
            searchbtn.Size = new Size(183, 54);
            searchbtn.TabIndex = 1;
            searchbtn.Text = "Search";
            searchbtn.UseVisualStyleBackColor = false;
            searchbtn.Click += searchbtn_Click;
            searchbtn.MouseDown += searchbtn_MouseDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(236, 61);
            label1.Name = "label1";
            label1.Size = new Size(389, 41);
            label1.TabIndex = 2;
            label1.Text = "GYM Management System";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(866, 618);
            Controls.Add(label1);
            Controls.Add(searchbtn);
            Controls.Add(newmemberbtn);
            Name = "Form1";
            Text = "GYM SYSTEM";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button newmemberbtn;
        private Button searchbtn;
        private Label label1;
    }
}