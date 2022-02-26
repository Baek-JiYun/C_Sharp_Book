namespace BookProject
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Return = new System.Windows.Forms.Button();
            this.button_Borrow = new System.Windows.Forms.Button();
            this.textBox_userId = new System.Windows.Forms.TextBox();
            this.textBox_bookName = new System.Windows.Forms.TextBox();
            this.textBox_Isbn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView_bookManager = new System.Windows.Forms.DataGridView();
            this.timer_now = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_now = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView_user = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.userIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button_close = new System.Windows.Forms.Button();
            this.isbnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isBorrowedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowedAtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userManager = new System.Windows.Forms.Button();
            this.bookManeger = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_bookManager)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(238)))));
            this.groupBox1.Controls.Add(this.button_Return);
            this.groupBox1.Controls.Add(this.button_Borrow);
            this.groupBox1.Controls.Add(this.textBox_userId);
            this.groupBox1.Controls.Add(this.textBox_bookName);
            this.groupBox1.Controls.Add(this.textBox_Isbn);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(166, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 133);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "대여 / 반납";
            // 
            // button_Return
            // 
            this.button_Return.Location = new System.Drawing.Point(304, 76);
            this.button_Return.Name = "button_Return";
            this.button_Return.Size = new System.Drawing.Size(75, 23);
            this.button_Return.TabIndex = 7;
            this.button_Return.Text = "반납";
            this.button_Return.UseVisualStyleBackColor = true;
            this.button_Return.Click += new System.EventHandler(this.button_Return_Click);
            // 
            // button_Borrow
            // 
            this.button_Borrow.Location = new System.Drawing.Point(304, 36);
            this.button_Borrow.Name = "button_Borrow";
            this.button_Borrow.Size = new System.Drawing.Size(75, 23);
            this.button_Borrow.TabIndex = 6;
            this.button_Borrow.Text = "대여";
            this.button_Borrow.UseVisualStyleBackColor = true;
            this.button_Borrow.Click += new System.EventHandler(this.button_Borrow_Click);
            // 
            // textBox_userId
            // 
            this.textBox_userId.Location = new System.Drawing.Point(105, 84);
            this.textBox_userId.Name = "textBox_userId";
            this.textBox_userId.Size = new System.Drawing.Size(166, 21);
            this.textBox_userId.TabIndex = 5;
            // 
            // textBox_bookName
            // 
            this.textBox_bookName.Location = new System.Drawing.Point(105, 57);
            this.textBox_bookName.Name = "textBox_bookName";
            this.textBox_bookName.Size = new System.Drawing.Size(166, 21);
            this.textBox_bookName.TabIndex = 4;
            // 
            // textBox_Isbn
            // 
            this.textBox_Isbn.Location = new System.Drawing.Point(105, 30);
            this.textBox_Isbn.Name = "textBox_Isbn";
            this.textBox_Isbn.Size = new System.Drawing.Size(166, 21);
            this.textBox_Isbn.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "사용자 ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "도서 이름";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Isbn";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(238)))));
            this.groupBox2.Controls.Add(this.dataGridView_bookManager);
            this.groupBox2.Location = new System.Drawing.Point(122, 328);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(796, 248);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "도서 목록";
            // 
            // dataGridView_bookManager
            // 
            this.dataGridView_bookManager.AutoGenerateColumns = false;
            this.dataGridView_bookManager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_bookManager.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.isbnDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.publisherDataGridViewTextBoxColumn,
            this.pageDataGridViewTextBoxColumn,
            this.userIdDataGridViewTextBoxColumn,
            this.isBorrowedDataGridViewTextBoxColumn,
            this.borrowedAtDataGridViewTextBoxColumn});
            this.dataGridView_bookManager.DataSource = this.bookBindingSource;
            this.dataGridView_bookManager.Location = new System.Drawing.Point(20, 20);
            this.dataGridView_bookManager.Name = "dataGridView_bookManager";
            this.dataGridView_bookManager.RowTemplate.Height = 23;
            this.dataGridView_bookManager.Size = new System.Drawing.Size(770, 222);
            this.dataGridView_bookManager.TabIndex = 0;
            this.dataGridView_bookManager.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Book_GridView_CellClick);
            // 
            // timer_now
            // 
            this.timer_now.Enabled = true;
            this.timer_now.Interval = 1000;
            this.timer_now.Tick += new System.EventHandler(this.timer_now_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_now});
            this.statusStrip1.Location = new System.Drawing.Point(0, 604);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(952, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_now
            // 
            this.toolStripStatusLabel_now.Name = "toolStripStatusLabel_now";
            this.toolStripStatusLabel_now.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel_now.Text = ".";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(238)))));
            this.groupBox3.Controls.Add(this.dataGridView_user);
            this.groupBox3.Location = new System.Drawing.Point(637, 96);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(257, 232);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "사용자 목록";
            // 
            // dataGridView_user
            // 
            this.dataGridView_user.AutoGenerateColumns = false;
            this.dataGridView_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_user.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userIdDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn1});
            this.dataGridView_user.DataSource = this.userBindingSource;
            this.dataGridView_user.Location = new System.Drawing.Point(6, 20);
            this.dataGridView_user.Name = "dataGridView_user";
            this.dataGridView_user.RowTemplate.Height = 23;
            this.dataGridView_user.Size = new System.Drawing.Size(245, 206);
            this.dataGridView_user.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(219)))), ((int)(((byte)(207)))));
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 23F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(161, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(697, 52);
            this.label4.TabIndex = 9;
            this.label4.Text = "도서관리 프로그램";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(15, 15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(56, 44);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // userIdDataGridViewTextBoxColumn1
            // 
            this.userIdDataGridViewTextBoxColumn1.DataPropertyName = "UserId";
            this.userIdDataGridViewTextBoxColumn1.HeaderText = "UserId";
            this.userIdDataGridViewTextBoxColumn1.Name = "userIdDataGridViewTextBoxColumn1";
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(BookProject.User);
            // 
            // button_close
            // 
            this.button_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_close.Location = new System.Drawing.Point(892, 0);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(25, 27);
            this.button_close.TabIndex = 4;
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // isbnDataGridViewTextBoxColumn
            // 
            this.isbnDataGridViewTextBoxColumn.DataPropertyName = "Isbn";
            this.isbnDataGridViewTextBoxColumn.HeaderText = "Isbn";
            this.isbnDataGridViewTextBoxColumn.Name = "isbnDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // publisherDataGridViewTextBoxColumn
            // 
            this.publisherDataGridViewTextBoxColumn.DataPropertyName = "Publisher";
            this.publisherDataGridViewTextBoxColumn.HeaderText = "Publisher";
            this.publisherDataGridViewTextBoxColumn.Name = "publisherDataGridViewTextBoxColumn";
            // 
            // pageDataGridViewTextBoxColumn
            // 
            this.pageDataGridViewTextBoxColumn.DataPropertyName = "Page";
            this.pageDataGridViewTextBoxColumn.HeaderText = "Page";
            this.pageDataGridViewTextBoxColumn.Name = "pageDataGridViewTextBoxColumn";
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            this.userIdDataGridViewTextBoxColumn.DataPropertyName = "UserId";
            this.userIdDataGridViewTextBoxColumn.HeaderText = "UserId";
            this.userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            // 
            // isBorrowedDataGridViewTextBoxColumn
            // 
            this.isBorrowedDataGridViewTextBoxColumn.DataPropertyName = "isBorrowed";
            this.isBorrowedDataGridViewTextBoxColumn.HeaderText = "isBorrowed";
            this.isBorrowedDataGridViewTextBoxColumn.Name = "isBorrowedDataGridViewTextBoxColumn";
            // 
            // borrowedAtDataGridViewTextBoxColumn
            // 
            this.borrowedAtDataGridViewTextBoxColumn.DataPropertyName = "BorrowedAt";
            this.borrowedAtDataGridViewTextBoxColumn.HeaderText = "BorrowedAt";
            this.borrowedAtDataGridViewTextBoxColumn.Name = "borrowedAtDataGridViewTextBoxColumn";
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataSource = typeof(BookProject.Book);
            // 
            // userManager
            // 
            this.userManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(238)))));
            this.userManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userManager.Location = new System.Drawing.Point(15, 208);
            this.userManager.Name = "userManager";
            this.userManager.Size = new System.Drawing.Size(56, 57);
            this.userManager.TabIndex = 1;
            this.userManager.UseVisualStyleBackColor = false;
            this.userManager.Click += new System.EventHandler(this.userManager_Click);
            // 
            // bookManeger
            // 
            this.bookManeger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(238)))));
            this.bookManeger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookManeger.Location = new System.Drawing.Point(15, 103);
            this.bookManeger.Name = "bookManeger";
            this.bookManeger.Size = new System.Drawing.Size(56, 57);
            this.bookManeger.TabIndex = 0;
            this.bookManeger.UseVisualStyleBackColor = false;
            this.bookManeger.Click += new System.EventHandler(this.bookManager_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 601);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(219)))), ((int)(((byte)(207)))));
            this.pictureBox3.BackgroundImage = global::BookProject.Properties.Resources.back1;
            this.pictureBox3.Location = new System.Drawing.Point(112, 90);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(817, 503);
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(219)))), ((int)(((byte)(207)))));
            this.ClientSize = new System.Drawing.Size(952, 626);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.userManager);
            this.Controls.Add(this.bookManeger);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_bookManager)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bookManeger;
        private System.Windows.Forms.Button userManager;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Button button_Return;
        private System.Windows.Forms.Button button_Borrow;
        private System.Windows.Forms.TextBox textBox_userId;
        private System.Windows.Forms.TextBox textBox_bookName;
        private System.Windows.Forms.TextBox textBox_Isbn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_bookManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isBorrowedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrowedAtDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private System.Windows.Forms.Timer timer_now;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_now;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView_user;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

