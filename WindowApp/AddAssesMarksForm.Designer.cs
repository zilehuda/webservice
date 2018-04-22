namespace WindowApp
{
    partial class AddAssesMarksForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.assid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.studentid = new System.Windows.Forms.TextBox();
            this.newstd_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.markid = new System.Windows.Forms.TextBox();
            this.stdid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stdid,
            this.marks});
            this.dataGridView1.Location = new System.Drawing.Point(0, 129);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 200;
            this.dataGridView1.Size = new System.Drawing.Size(421, 227);
            this.dataGridView1.TabIndex = 19;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(280, 100);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(127, 23);
            this.btn_back.TabIndex = 18;
            this.btn_back.Text = "BACK";
            this.btn_back.UseVisualStyleBackColor = true;
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(280, 71);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(127, 23);
            this.btn_insert.TabIndex = 17;
            this.btn_insert.Text = "INSERT";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "ASSES ID:";
            // 
            // assid
            // 
            this.assid.Location = new System.Drawing.Point(169, 12);
            this.assid.Name = "assid";
            this.assid.Size = new System.Drawing.Size(161, 20);
            this.assid.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "STUDENT ID:";
            // 
            // studentid
            // 
            this.studentid.Location = new System.Drawing.Point(151, 41);
            this.studentid.Name = "studentid";
            this.studentid.Size = new System.Drawing.Size(100, 20);
            this.studentid.TabIndex = 13;
            // 
            // newstd_btn
            // 
            this.newstd_btn.Location = new System.Drawing.Point(124, 100);
            this.newstd_btn.Name = "newstd_btn";
            this.newstd_btn.Size = new System.Drawing.Size(127, 23);
            this.newstd_btn.TabIndex = 12;
            this.newstd_btn.Text = "ADD NEW MARKS";
            this.newstd_btn.UseVisualStyleBackColor = true;
            this.newstd_btn.Click += new System.EventHandler(this.newstd_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "MARKS:";
            // 
            // markid
            // 
            this.markid.Location = new System.Drawing.Point(151, 67);
            this.markid.Name = "markid";
            this.markid.Size = new System.Drawing.Size(100, 20);
            this.markid.TabIndex = 20;
            // 
            // stdid
            // 
            this.stdid.HeaderText = "STD ID";
            this.stdid.Name = "stdid";
            this.stdid.ReadOnly = true;
            // 
            // marks
            // 
            this.marks.HeaderText = "MARKS";
            this.marks.Name = "marks";
            this.marks.ReadOnly = true;
            // 
            // AddAssesMarksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 351);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.markid);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.assid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.studentid);
            this.Controls.Add(this.newstd_btn);
            this.Name = "AddAssesMarksForm";
            this.Text = "AddAssesMarksForm";
            this.Load += new System.EventHandler(this.AddAssesMarksForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox assid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox studentid;
        private System.Windows.Forms.Button newstd_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox markid;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdid;
        private System.Windows.Forms.DataGridViewTextBoxColumn marks;
    }
}