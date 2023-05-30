namespace EFCRUD
{
    partial class AllNews
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
            cb_catalog = new ComboBox();
            dgv_allNews = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_allNews).BeginInit();
            SuspendLayout();
            // 
            // cb_catalog
            // 
            cb_catalog.FormattingEnabled = true;
            cb_catalog.Location = new Point(562, 73);
            cb_catalog.Name = "cb_catalog";
            cb_catalog.Size = new Size(157, 23);
            cb_catalog.TabIndex = 0;
            cb_catalog.SelectedValueChanged += cb_catalog_SelectedValueChanged;
            // 
            // dgv_allNews
            // 
            dgv_allNews.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_allNews.Location = new Point(90, 161);
            dgv_allNews.Name = "dgv_allNews";
            dgv_allNews.RowTemplate.Height = 25;
            dgv_allNews.Size = new Size(639, 201);
            dgv_allNews.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(334, 9);
            label1.Name = "label1";
            label1.Size = new Size(87, 28);
            label1.TabIndex = 2;
            label1.Text = "All News";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(456, 73);
            label2.Name = "label2";
            label2.Size = new Size(56, 19);
            label2.TabIndex = 3;
            label2.Text = "Catalog";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // AllNews
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgv_allNews);
            Controls.Add(cb_catalog);
            Name = "AllNews";
            Text = "AllNews";
            Load += AllNews_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_allNews).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cb_catalog;
        private DataGridView dgv_allNews;
        private Label label1;
        private Label label2;
    }
}