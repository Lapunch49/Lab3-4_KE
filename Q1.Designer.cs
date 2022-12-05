
namespace Lab3_4_KE
{
    partial class Q1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Q1));
            this.lb_question = new System.Windows.Forms.Label();
            this.rbtn1 = new System.Windows.Forms.RadioButton();
            this.rbtn2 = new System.Windows.Forms.RadioButton();
            this.rbtn3 = new System.Windows.Forms.RadioButton();
            this.rbtn4 = new System.Windows.Forms.RadioButton();
            this.rbtn5 = new System.Windows.Forms.RadioButton();
            this.rbtn6 = new System.Windows.Forms.RadioButton();
            this.btn_start = new System.Windows.Forms.Button();
            this.rbt0 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbx3 = new System.Windows.Forms.PictureBox();
            this.pbx2 = new System.Windows.Forms.PictureBox();
            this.pbx1 = new System.Windows.Forms.PictureBox();
            this.lb_text = new System.Windows.Forms.Label();
            this.lb_title = new System.Windows.Forms.Label();
            this.btn_st = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_question
            // 
            this.lb_question.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_question.Location = new System.Drawing.Point(59, 22);
            this.lb_question.Name = "lb_question";
            this.lb_question.Size = new System.Drawing.Size(539, 62);
            this.lb_question.TabIndex = 1;
            this.lb_question.Text = "What do you need more?";
            this.lb_question.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_question.Click += new System.EventHandler(this.label1_Click);
            // 
            // rbtn1
            // 
            this.rbtn1.AutoSize = true;
            this.rbtn1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtn1.Location = new System.Drawing.Point(192, 87);
            this.rbtn1.Name = "rbtn1";
            this.rbtn1.Size = new System.Drawing.Size(78, 32);
            this.rbtn1.TabIndex = 2;
            this.rbtn1.Text = "sleep";
            this.rbtn1.UseVisualStyleBackColor = true;
            this.rbtn1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbtn2
            // 
            this.rbtn2.AutoSize = true;
            this.rbtn2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtn2.Location = new System.Drawing.Point(192, 125);
            this.rbtn2.Name = "rbtn2";
            this.rbtn2.Size = new System.Drawing.Size(110, 32);
            this.rbtn2.TabIndex = 3;
            this.rbtn2.Text = "free time";
            this.rbtn2.UseVisualStyleBackColor = true;
            this.rbtn2.CheckedChanged += new System.EventHandler(this.rbtn2_CheckedChanged);
            // 
            // rbtn3
            // 
            this.rbtn3.AutoSize = true;
            this.rbtn3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtn3.Location = new System.Drawing.Point(192, 163);
            this.rbtn3.Name = "rbtn3";
            this.rbtn3.Size = new System.Drawing.Size(169, 32);
            this.rbtn3.TabIndex = 4;
            this.rbtn3.Text = "communication";
            this.rbtn3.UseVisualStyleBackColor = true;
            this.rbtn3.CheckedChanged += new System.EventHandler(this.rbtn3_CheckedChanged);
            // 
            // rbtn4
            // 
            this.rbtn4.AutoSize = true;
            this.rbtn4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtn4.Location = new System.Drawing.Point(192, 201);
            this.rbtn4.Name = "rbtn4";
            this.rbtn4.Size = new System.Drawing.Size(162, 32);
            this.rbtn4.TabIndex = 5;
            this.rbtn4.Text = "self-expression";
            this.rbtn4.UseVisualStyleBackColor = true;
            this.rbtn4.CheckedChanged += new System.EventHandler(this.rbtn4_CheckedChanged);
            // 
            // rbtn5
            // 
            this.rbtn5.AutoSize = true;
            this.rbtn5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtn5.Location = new System.Drawing.Point(192, 239);
            this.rbtn5.Name = "rbtn5";
            this.rbtn5.Size = new System.Drawing.Size(113, 32);
            this.rbtn5.TabIndex = 6;
            this.rbtn5.Text = "attention";
            this.rbtn5.UseVisualStyleBackColor = true;
            this.rbtn5.CheckedChanged += new System.EventHandler(this.rbtn5_CheckedChanged);
            // 
            // rbtn6
            // 
            this.rbtn6.AutoSize = true;
            this.rbtn6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtn6.Location = new System.Drawing.Point(192, 277);
            this.rbtn6.Name = "rbtn6";
            this.rbtn6.Size = new System.Drawing.Size(177, 32);
            this.rbtn6.TabIndex = 7;
            this.rbtn6.Text = "strong emotions";
            this.rbtn6.UseVisualStyleBackColor = true;
            this.rbtn6.CheckedChanged += new System.EventHandler(this.rbtn6_CheckedChanged);
            // 
            // btn_start
            // 
            this.btn_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_start.Location = new System.Drawing.Point(515, 299);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(112, 35);
            this.btn_start.TabIndex = 8;
            this.btn_start.Text = "start over";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // rbt0
            // 
            this.rbt0.AutoSize = true;
            this.rbt0.Checked = true;
            this.rbt0.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbt0.Location = new System.Drawing.Point(88, 87);
            this.rbt0.Name = "rbt0";
            this.rbt0.Size = new System.Drawing.Size(78, 32);
            this.rbt0.TabIndex = 9;
            this.rbt0.TabStop = true;
            this.rbt0.Text = "sleep";
            this.rbt0.UseVisualStyleBackColor = true;
            this.rbt0.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pbx3);
            this.panel1.Controls.Add(this.pbx2);
            this.panel1.Controls.Add(this.pbx1);
            this.panel1.Controls.Add(this.lb_text);
            this.panel1.Controls.Add(this.lb_title);
            this.panel1.Controls.Add(this.btn_st);
            this.panel1.Location = new System.Drawing.Point(2, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(811, 449);
            this.panel1.TabIndex = 10;
            this.panel1.Visible = false;
            // 
            // pbx3
            // 
            this.pbx3.Location = new System.Drawing.Point(287, 308);
            this.pbx3.Name = "pbx3";
            this.pbx3.Size = new System.Drawing.Size(245, 152);
            this.pbx3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx3.TabIndex = 7;
            this.pbx3.TabStop = false;
            // 
            // pbx2
            // 
            this.pbx2.Location = new System.Drawing.Point(25, 308);
            this.pbx2.Name = "pbx2";
            this.pbx2.Size = new System.Drawing.Size(245, 152);
            this.pbx2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx2.TabIndex = 6;
            this.pbx2.TabStop = false;
            // 
            // pbx1
            // 
            this.pbx1.InitialImage = null;
            this.pbx1.Location = new System.Drawing.Point(540, 56);
            this.pbx1.Name = "pbx1";
            this.pbx1.Size = new System.Drawing.Size(246, 338);
            this.pbx1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx1.TabIndex = 5;
            this.pbx1.TabStop = false;
            // 
            // lb_text
            // 
            this.lb_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_text.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_text.Location = new System.Drawing.Point(25, 56);
            this.lb_text.Name = "lb_text";
            this.lb_text.Size = new System.Drawing.Size(509, 241);
            this.lb_text.TabIndex = 4;
            this.lb_text.Text = "Text";
            this.lb_text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_title
            // 
            this.lb_title.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_title.Location = new System.Drawing.Point(25, 9);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(761, 39);
            this.lb_title.TabIndex = 2;
            this.lb_title.Text = "Title";
            this.lb_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_st
            // 
            this.btn_st.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_st.Location = new System.Drawing.Point(582, 400);
            this.btn_st.Name = "btn_st";
            this.btn_st.Size = new System.Drawing.Size(174, 60);
            this.btn_st.TabIndex = 3;
            this.btn_st.Text = "Start over";
            this.btn_st.UseVisualStyleBackColor = true;
            this.btn_st.Click += new System.EventHandler(this.btn_st_Click);
            // 
            // Q1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(241)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(813, 472);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rbt0);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.rbtn6);
            this.Controls.Add(this.rbtn5);
            this.Controls.Add(this.rbtn4);
            this.Controls.Add(this.rbtn3);
            this.Controls.Add(this.rbtn2);
            this.Controls.Add(this.rbtn1);
            this.Controls.Add(this.lb_question);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Q1";
            this.Text = "Quiz";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Q1_FormClosed);
            this.Load += new System.EventHandler(this.Q1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbx3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_question;
        private System.Windows.Forms.RadioButton rbtn1;
        private System.Windows.Forms.RadioButton rbtn2;
        private System.Windows.Forms.RadioButton rbtn3;
        private System.Windows.Forms.RadioButton rbtn4;
        private System.Windows.Forms.RadioButton rbtn5;
        private System.Windows.Forms.RadioButton rbtn6;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.RadioButton rbt0;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbx1;
        private System.Windows.Forms.Label lb_text;
        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.Button btn_st;
        private System.Windows.Forms.PictureBox pbx2;
        private System.Windows.Forms.PictureBox pbx3;
    }
}