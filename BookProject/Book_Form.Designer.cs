namespace BookProject
{
    partial class Book_Form
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
            this.textBox_page = new System.Windows.Forms.TextBox();
            this.textBox_publisher = new System.Windows.Forms.TextBox();
            this.textBox_bookName = new System.Windows.Forms.TextBox();
            this.textBox_Isbn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView_book = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_modify = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.isbnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isBorrowedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowedAtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_book)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(238)))));
            this.groupBox1.Controls.Add(this.button_delete);
            this.groupBox1.Controls.Add(this.button_modify);
            this.groupBox1.Controls.Add(this.button_add);
            this.groupBox1.Controls.Add(this.textBox_page);
            this.groupBox1.Controls.Add(this.textBox_publisher);
            this.groupBox1.Controls.Add(this.textBox_bookName);
            this.groupBox1.Controls.Add(this.textBox_Isbn);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(169, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(564, 113);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // textBox_page
            // 
            this.textBox_page.Location = new System.Drawing.Point(103, 86);
            this.textBox_page.Name = "textBox_page";
            this.textBox_page.Size = new System.Drawing.Size(244, 21);
            this.textBox_page.TabIndex = 7;
            // 
            // textBox_publisher
            // 
            this.textBox_publisher.Location = new System.Drawing.Point(103, 62);
            this.textBox_publisher.Name = "textBox_publisher";
            this.textBox_publisher.Size = new System.Drawing.Size(244, 21);
            this.textBox_publisher.TabIndex = 6;
            // 
            // textBox_bookName
            // 
            this.textBox_bookName.Location = new System.Drawing.Point(103, 39);
            this.textBox_bookName.Name = "textBox_bookName";
            this.textBox_bookName.Size = new System.Drawing.Size(244, 21);
            this.textBox_bookName.TabIndex = 5;
            // 
            // textBox_Isbn
            // 
            this.textBox_Isbn.Location = new System.Drawing.Point(103, 16);
            this.textBox_Isbn.Name = "textBox_Isbn";
            this.textBox_Isbn.Size = new System.Drawing.Size(244, 21);
            this.textBox_Isbn.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.label4.Location = new System.Drawing.Point(24, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "페이지";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.label3.Location = new System.Drawing.Point(24, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "출판사";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.label2.Location = new System.Drawing.Point(24, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "도서 제목";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.label1.Location = new System.Drawing.Point(27, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Isbn";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(238)))));
            this.groupBox2.Controls.Add(this.dataGridView_book);
            this.groupBox2.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.groupBox2.Location = new System.Drawing.Point(59, 214);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(761, 286);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "도서 목록";
            // 
            // dataGridView_book
            // 
            this.dataGridView_book.AutoGenerateColumns = false;
            this.dataGridView_book.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_book.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.isbnDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.publisherDataGridViewTextBoxColumn,
            this.pageDataGridViewTextBoxColumn,
            this.userIdDataGridViewTextBoxColumn,
            this.isBorrowedDataGridViewTextBoxColumn,
            this.borrowedAtDataGridViewTextBoxColumn});
            this.dataGridView_book.DataSource = this.bookBindingSource;
            this.dataGridView_book.Location = new System.Drawing.Point(6, 20);
            this.dataGridView_book.Name = "dataGridView_book";
            this.dataGridView_book.RowTemplate.Height = 23;
            this.dataGridView_book.Size = new System.Drawing.Size(747, 260);
            this.dataGridView_book.TabIndex = 0;
            this.dataGridView_book.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_book_CellClick);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Image = global::BookProject.Properties.Resources.T_back;
            this.label5.Location = new System.Drawing.Point(204, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(444, 41);
            this.label5.TabIndex = 3;
            this.label5.Text = "도서 관리";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(219)))), ((int)(((byte)(207)))));
            this.button_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delete.Image = global::BookProject.Properties.Resources.icons8_subtract_30px;
            this.button_delete.Location = new System.Drawing.Point(501, 41);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(40, 40);
            this.button_delete.TabIndex = 9;
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_modify
            // 
            this.button_modify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(219)))), ((int)(((byte)(207)))));
            this.button_modify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_modify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_modify.Image = global::BookProject.Properties.Resources.icons8_pencil_30px;
            this.button_modify.Location = new System.Drawing.Point(439, 40);
            this.button_modify.Name = "button_modify";
            this.button_modify.Size = new System.Drawing.Size(40, 40);
            this.button_modify.TabIndex = 8;
            this.button_modify.UseVisualStyleBackColor = false;
            this.button_modify.Click += new System.EventHandler(this.button_modify_Click);
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(219)))), ((int)(((byte)(207)))));
            this.button_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add.Image = global::BookProject.Properties.Resources.icons8_plus_math_30px;
            this.button_add.Location = new System.Drawing.Point(378, 40);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(40, 40);
            this.button_add.TabIndex = 3;
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_close
            // 
            this.button_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_close.Image = global::BookProject.Properties.Resources.icons8_delete_50px;
            this.button_close.Location = new System.Drawing.Point(840, 0);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(30, 29);
            this.button_close.TabIndex = 0;
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::BookProject.Properties.Resources.back_user;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(23, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(826, 441);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
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
            // Book_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(219)))), ((int)(((byte)(207)))));
            this.ClientSize = new System.Drawing.Size(870, 539);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Book_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_book)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView_book;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isBorrowedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrowedAtDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private System.Windows.Forms.TextBox textBox_page;
        private System.Windows.Forms.TextBox textBox_publisher;
        private System.Windows.Forms.TextBox textBox_bookName;
        private System.Windows.Forms.TextBox textBox_Isbn;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_modify;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}