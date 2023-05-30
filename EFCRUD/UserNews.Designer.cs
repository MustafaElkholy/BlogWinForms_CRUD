namespace EFCRUD
{
    partial class UserNews
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
            lbl_welcome = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txt_title = new TextBox();
            txt_desc = new TextBox();
            label5 = new Label();
            label4 = new Label();
            txt_brief = new TextBox();
            txt_photo = new TextBox();
            label6 = new Label();
            label7 = new Label();
            cb_category = new ComboBox();
            btn_add = new Button();
            btn_update = new Button();
            btn_delete = new Button();
            btn_news = new Button();
            dgv_usernews = new DataGridView();
            txt_date = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgv_usernews).BeginInit();
            SuspendLayout();
            // 
            // lbl_welcome
            // 
            lbl_welcome.AutoSize = true;
            lbl_welcome.Location = new Point(358, 23);
            lbl_welcome.Name = "lbl_welcome";
            lbl_welcome.Size = new Size(0, 15);
            lbl_welcome.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 36);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 1;
            label1.Text = "Add Your News";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 83);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 2;
            label2.Text = "Title";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 123);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 3;
            label3.Text = "Description";
            // 
            // txt_title
            // 
            txt_title.Location = new Point(79, 83);
            txt_title.Name = "txt_title";
            txt_title.Size = new Size(174, 23);
            txt_title.TabIndex = 4;
            // 
            // txt_desc
            // 
            txt_desc.Location = new Point(79, 120);
            txt_desc.Name = "txt_desc";
            txt_desc.Size = new Size(174, 23);
            txt_desc.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(270, 83);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 6;
            label5.Text = "Brief";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(270, 123);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 7;
            label4.Text = "Photo";
            // 
            // txt_brief
            // 
            txt_brief.Location = new Point(332, 83);
            txt_brief.Name = "txt_brief";
            txt_brief.Size = new Size(110, 23);
            txt_brief.TabIndex = 8;
            // 
            // txt_photo
            // 
            txt_photo.Location = new Point(332, 120);
            txt_photo.Name = "txt_photo";
            txt_photo.Size = new Size(110, 23);
            txt_photo.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(454, 123);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 11;
            label6.Text = "Category";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(462, 83);
            label7.Name = "label7";
            label7.Size = new Size(31, 15);
            label7.TabIndex = 10;
            label7.Text = "Date";
            // 
            // cb_category
            // 
            cb_category.FormattingEnabled = true;
            cb_category.Location = new Point(515, 120);
            cb_category.Name = "cb_category";
            cb_category.Size = new Size(188, 23);
            cb_category.TabIndex = 13;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(434, 173);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(75, 23);
            btn_add.TabIndex = 14;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(525, 173);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(75, 23);
            btn_update.TabIndex = 15;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(616, 173);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(75, 23);
            btn_delete.TabIndex = 16;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_news
            // 
            btn_news.BackColor = SystemColors.ActiveCaption;
            btn_news.Location = new Point(39, 173);
            btn_news.Name = "btn_news";
            btn_news.Size = new Size(111, 23);
            btn_news.TabIndex = 17;
            btn_news.Text = "News";
            btn_news.UseVisualStyleBackColor = false;
            btn_news.Click += btn_news_Click;
            // 
            // dgv_usernews
            // 
            dgv_usernews.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_usernews.Location = new Point(39, 251);
            dgv_usernews.Name = "dgv_usernews";
            dgv_usernews.RowTemplate.Height = 25;
            dgv_usernews.Size = new Size(639, 150);
            dgv_usernews.TabIndex = 18;
            dgv_usernews.RowHeaderMouseDoubleClick += dgv_usernews_RowHeaderMouseDoubleClick;
            // 
            // txt_date
            // 
            txt_date.Location = new Point(515, 77);
            txt_date.Name = "txt_date";
            txt_date.Size = new Size(188, 23);
            txt_date.TabIndex = 19;
            // 
            // UserNews
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(735, 469);
            Controls.Add(txt_date);
            Controls.Add(dgv_usernews);
            Controls.Add(btn_news);
            Controls.Add(btn_delete);
            Controls.Add(btn_update);
            Controls.Add(btn_add);
            Controls.Add(cb_category);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(txt_photo);
            Controls.Add(txt_brief);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(txt_desc);
            Controls.Add(txt_title);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbl_welcome);
            Name = "UserNews";
            Text = "UserNews";
            Load += UserNews_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_usernews).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_welcome;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_title;
        private TextBox txt_desc;
        private Label label5;
        private Label label4;
        private TextBox txt_brief;
        private TextBox txt_photo;
        private Label label6;
        private Label label7;
        private ComboBox cb_category;
        private Button btn_add;
        private Button btn_update;
        private Button btn_delete;
        private Button btn_news;
        private DataGridView dgv_usernews;
        private DateTimePicker txt_date;
    }
}