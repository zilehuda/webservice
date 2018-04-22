namespace WindowApp
{
    partial class AddAssesmentForm
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.totalmarks = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.asstype = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.assdate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(54, 178);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "BACK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(157, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "INSERT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_insert);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "TOTAL MARKS:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // totalmarks
            // 
            this.totalmarks.Location = new System.Drawing.Point(134, 71);
            this.totalmarks.Name = "totalmarks";
            this.totalmarks.Size = new System.Drawing.Size(100, 20);
            this.totalmarks.TabIndex = 9;
            this.totalmarks.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "TYPE:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // asstype
            // 
            this.asstype.Location = new System.Drawing.Point(132, 22);
            this.asstype.Name = "asstype";
            this.asstype.Size = new System.Drawing.Size(100, 20);
            this.asstype.TabIndex = 7;
            this.asstype.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "DATE:";
            // 
            // assdate
            // 
            this.assdate.Location = new System.Drawing.Point(133, 120);
            this.assdate.Name = "assdate";
            this.assdate.Size = new System.Drawing.Size(100, 20);
            this.assdate.TabIndex = 13;
            this.assdate.Text = "02-01-2014";
            this.assdate.TextChanged += new System.EventHandler(this.assdate_TextChanged);
            this.assdate.Enter += new System.EventHandler(this.assdate_Enter_1);
            this.assdate.Leave += new System.EventHandler(this.assdate_Leave);
            // 
            // AddAssesmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.assdate);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.totalmarks);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.asstype);
            this.Name = "AddAssesmentForm";
            this.Text = "AddAssesmentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox totalmarks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox asstype;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox assdate;
    }
}