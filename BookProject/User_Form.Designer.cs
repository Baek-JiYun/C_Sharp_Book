namespace BookProject
{
    partial class User_Form
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView_user = new System.Windows.Forms.DataGridView();
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_modify = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_Id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_close = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_reset = new System.Windows.Forms.Button();
            this.button_search = new System.Windows.Forms.Button();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(238)))));
            this.groupBox1.Controls.Add(this.dataGridView_user);
            this.groupBox1.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.groupBox1.Location = new System.Drawing.Point(48, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "사용자 현황";
            // 
            // dataGridView_user
            // 
            this.dataGridView_user.AutoGenerateColumns = false;
            this.dataGridView_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_user.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dataGridView_user.DataSource = this.userBindingSource;
            this.dataGridView_user.Location = new System.Drawing.Point(6, 20);
            this.dataGridView_user.Name = "dataGridView_user";
            this.dataGridView_user.RowTemplate.Height = 23;
            this.dataGridView_user.Size = new System.Drawing.Size(248, 400);
            this.dataGridView_user.TabIndex = 0;
            this.dataGridView_user.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.user_cellclick);
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            this.userIdDataGridViewTextBoxColumn.DataPropertyName = "UserId";
            this.userIdDataGridViewTextBoxColumn.HeaderText = "UserId";
            this.userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(BookProject.User);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(238)))));
            this.groupBox2.Controls.Add(this.button_delete);
            this.groupBox2.Controls.Add(this.button_modify);
            this.groupBox2.Controls.Add(this.button_add);
            this.groupBox2.Controls.Add(this.textBox_Name);
            this.groupBox2.Controls.Add(this.textBox_Id);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.groupBox2.Location = new System.Drawing.Point(325, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(292, 180);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(219)))), ((int)(((byte)(207)))));
            this.button_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delete.Image = global::BookProject.Properties.Resources.icons8_subtract_30px;
            this.button_delete.Location = new System.Drawing.Point(205, 120);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(40, 40);
            this.button_delete.TabIndex = 6;
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_modify
            // 
            this.button_modify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(219)))), ((int)(((byte)(207)))));
            this.button_modify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_modify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_modify.Image = global::BookProject.Properties.Resources.icons8_pencil_30px;
            this.button_modify.Location = new System.Drawing.Point(124, 120);
            this.button_modify.Name = "button_modify";
            this.button_modify.Size = new System.Drawing.Size(40, 40);
            this.button_modify.TabIndex = 5;
            this.button_modify.UseVisualStyleBackColor = false;
            this.button_modify.Click += new System.EventHandler(this.button_modify_Click);
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(219)))), ((int)(((byte)(207)))));
            this.button_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add.Image = global::BookProject.Properties.Resources.icons8_plus_math_30px;
            this.button_add.Location = new System.Drawing.Point(45, 120);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(40, 40);
            this.button_add.TabIndex = 4;
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(114, 78);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(100, 23);
            this.textBox_Name.TabIndex = 3;
            // 
            // textBox_Id
            // 
            this.textBox_Id.Location = new System.Drawing.Point(114, 40);
            this.textBox_Id.Name = "textBox_Id";
            this.textBox_Id.Size = new System.Drawing.Size(100, 23);
            this.textBox_Id.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "이름";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Image = global::BookProject.Properties.Resources.T_back;
            this.label3.Location = new System.Drawing.Point(110, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(420, 44);
            this.label3.TabIndex = 3;
            this.label3.Text = "사용자 관리";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_close
            // 
            this.button_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_close.Image = global::BookProject.Properties.Resources.icons8_delete_50px;
            this.button_close.Location = new System.Drawing.Point(633, 0);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(27, 27);
            this.button_close.TabIndex = 2;
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::BookProject.Properties.Resources.back_user;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(25, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(612, 472);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(238)))));
            this.groupBox3.Controls.Add(this.button_reset);
            this.groupBox3.Controls.Add(this.button_search);
            this.groupBox3.Controls.Add(this.textBox_search);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.groupBox3.Location = new System.Drawing.Point(327, 308);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(290, 152);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "사용자 검색";
            // 
            // button_reset
            // 
            this.button_reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(219)))), ((int)(((byte)(207)))));
            this.button_reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_reset.Image = global::BookProject.Properties.Resources.icons8_reset_32px;
            this.button_reset.Location = new System.Drawing.Point(170, 88);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(40, 40);
            this.button_reset.TabIndex = 14;
            this.button_reset.UseVisualStyleBackColor = false;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // button_search
            // 
            this.button_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(219)))), ((int)(((byte)(207)))));
            this.button_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_search.Image = global::BookProject.Properties.Resources.icons8_search_30px;
            this.button_search.Location = new System.Drawing.Point(82, 88);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(40, 40);
            this.button_search.TabIndex = 13;
            this.button_search.UseVisualStyleBackColor = false;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(112, 39);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(100, 23);
            this.textBox_search.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "ID";
            // 
            // User_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(219)))), ((int)(((byte)(207)))));
            this.ClientSize = new System.Drawing.Size(660, 568);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "User_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User_Form";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView_user;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_Id;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_modify;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.Button button_search;
    }
}