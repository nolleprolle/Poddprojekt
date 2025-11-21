namespace PresentationLayer
{
    partial class FirstWindow
    {
   
        private System.ComponentModel.IContainer components = null;


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
            tabPage2 = new TabPage();
            dataGridView2 = new DataGridView();
            cbCategoryFiltration = new ComboBox();
            richTextBox1 = new RichTextBox();
            dataGridView1 = new DataGridView();
            tabPage1 = new TabPage();
            txtPoddName = new TextBox();
            rtxtEpisodeInfo = new RichTextBox();
            txtUrlInput = new TextBox();
            btnSave = new Button();
            dgvEpisodes = new DataGridView();
            btnGetInfo = new Button();
            lblUrlInput = new Label();
            tabControl1 = new TabControl();
            //btnEditPodd = new Button();
            cbCategory = new ComboBox();
            btnEditCategory = new Button();
            btnDelete = new Button();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEpisodes).BeginInit();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnDelete);
            tabPage2.Controls.Add(btnEditCategory);
            //tabPage2.Controls.Add(btnEditPodd);
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Controls.Add(cbCategoryFiltration);
            tabPage2.Controls.Add(richTextBox1);
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Margin = new Padding(4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(4);
            tabPage2.Size = new Size(1704, 757);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Poddregister";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += btnEditPodd_click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(37, 173);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(360, 479);
            dataGridView2.TabIndex = 3;
            // 
            // cbCategoryFiltration
            // 
            cbCategoryFiltration.FormattingEnabled = true;
            cbCategoryFiltration.Location = new Point(458, 72);
            cbCategoryFiltration.Name = "cbCategoryFiltration";
            cbCategoryFiltration.Size = new Size(364, 33);
            cbCategoryFiltration.TabIndex = 2;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(872, 173);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(570, 479);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(458, 173);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(364, 479);
            dataGridView1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(cbCategory);
            tabPage1.Controls.Add(txtPoddName);
            tabPage1.Controls.Add(rtxtEpisodeInfo);
            tabPage1.Controls.Add(txtUrlInput);
            tabPage1.Controls.Add(btnSave);
            tabPage1.Controls.Add(dgvEpisodes);
            tabPage1.Controls.Add(btnGetInfo);
            tabPage1.Controls.Add(lblUrlInput);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Margin = new Padding(4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(4);
            tabPage1.Size = new Size(1704, 757);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Källa";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // txtPoddName
            // 
            txtPoddName.AccessibleName = "Vänligen ";
            txtPoddName.Location = new Point(624, 640);
            txtPoddName.Margin = new Padding(2);
            txtPoddName.Name = "txtPoddName";
            txtPoddName.Size = new Size(200, 31);
            txtPoddName.TabIndex = 15;
            txtPoddName.Text = "Ange namn till flödet";
            // 
            // rtxtEpisodeInfo
            // 
            rtxtEpisodeInfo.Location = new Point(624, 190);
            rtxtEpisodeInfo.Margin = new Padding(2);
            rtxtEpisodeInfo.Name = "rtxtEpisodeInfo";
            rtxtEpisodeInfo.Size = new Size(556, 440);
            rtxtEpisodeInfo.TabIndex = 13;
            rtxtEpisodeInfo.Text = "";
            // 
            // txtUrlInput
            // 
            txtUrlInput.Location = new Point(50, 88);
            txtUrlInput.Margin = new Padding(2);
            txtUrlInput.Name = "txtUrlInput";
            txtUrlInput.Size = new Size(232, 31);
            txtUrlInput.TabIndex = 9;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(50, 636);
            btnSave.Margin = new Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(272, 34);
            btnSave.TabIndex = 14;
            btnSave.Text = "Spara ner flödet till ditt register.";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // dgvEpisodes
            // 
            dgvEpisodes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEpisodes.Location = new Point(50, 190);
            dgvEpisodes.Margin = new Padding(2);
            dgvEpisodes.Name = "dgvEpisodes";
            dgvEpisodes.RowHeadersWidth = 62;
            dgvEpisodes.Size = new Size(558, 440);
            dgvEpisodes.TabIndex = 12;
            // 
            // btnGetInfo
            // 
            btnGetInfo.Location = new Point(52, 125);
            btnGetInfo.Margin = new Padding(2);
            btnGetInfo.Name = "btnGetInfo";
            btnGetInfo.Size = new Size(112, 34);
            btnGetInfo.TabIndex = 11;
            btnGetInfo.Text = "Hämta";
            btnGetInfo.UseVisualStyleBackColor = true;
            // 
            // lblUrlInput
            // 
            lblUrlInput.AutoSize = true;
            lblUrlInput.Location = new Point(50, 60);
            lblUrlInput.Margin = new Padding(2, 0, 2, 0);
            lblUrlInput.Name = "lblUrlInput";
            lblUrlInput.Size = new Size(233, 25);
            lblUrlInput.TabIndex = 10;
            lblUrlInput.Text = "Ange källans URL (RSS-länk)";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Font = new Font("Segoe UI Symbol", 9F);
            tabControl1.Location = new Point(15, 15);
            tabControl1.Margin = new Padding(4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1712, 795);
            tabControl1.TabIndex = 9;
            // 
            // btnEditPodd
            // 
            //btnEditPodd.Location = new Point(37, 667);
            //btnEditPodd.Name = "btnEditPodd";
            ////btnEditPodd.Size = new Size(167, 34);
            //btnEditPodd.TabIndex = 4;
            //btnEditPodd.Text = "Redigera Flöde";
            //btnEditPodd.UseVisualStyleBackColor = true;
            //btnEditPodd.Click += this.btnEditPodd_click;
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(624, 686);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(182, 33);
            cbCategory.TabIndex = 16;
            // 
            // btnEditCategory
            // 
            btnEditCategory.Location = new Point(231, 667);
            btnEditCategory.Name = "btnEditCategory";
            btnEditCategory.Size = new Size(166, 34);
            btnEditCategory.TabIndex = 5;
            btnEditCategory.Text = "Redigera kategori";
            btnEditCategory.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(458, 667);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Radera";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // FirstWindow
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1814, 916);
            Controls.Add(tabControl1);
            Margin = new Padding(2);
            Name = "FirstWindow";
            Text = "FirstWindow";
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEpisodes).EndInit();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage tabPage2;
        private RichTextBox richTextBox1;
        private DataGridView dataGridView1;
        private TabPage tabPage1;
        private TextBox txtPoddName;
        private RichTextBox rtxtEpisodeInfo;
        private TextBox txtUrlInput;
        private Button btnSave;
        private DataGridView dgvEpisodes;
        private Button btnGetInfo;
        private Label lblUrlInput;
        private TabControl tabControl1;
        private DataGridView dataGridView2;
        private ComboBox cbCategoryFiltration;
        private Button btnEditPodd;
        private ComboBox cbCategory;
        private Button btnDelete;
        private Button btnEditCategory;
        //private Button btnEditPodd;
    }
}