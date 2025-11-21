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
            btnDelete = new Button();
            btnEditCategory = new Button();
            dgvPoddNames = new DataGridView();
            cbCategoryFiltration = new ComboBox();
            rtbDescription = new RichTextBox();
            dgvEpisodeRegister = new DataGridView();
            tabPage1 = new TabPage();
            cbCategory = new ComboBox();
            txtPoddName = new TextBox();
            rtbEpisodeInfo = new RichTextBox();
            txtUrlInput = new TextBox();
            btnSave = new Button();
            dgvEpisodes = new DataGridView();
            btnGetInfo = new Button();
            lblUrlInput = new Label();
            tabControl1 = new TabControl();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPoddNames).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvEpisodeRegister).BeginInit();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEpisodes).BeginInit();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnDelete);
            tabPage2.Controls.Add(btnEditCategory);
            tabPage2.Controls.Add(dgvPoddNames);
            tabPage2.Controls.Add(cbCategoryFiltration);
            tabPage2.Controls.Add(rtbDescription);
            tabPage2.Controls.Add(dgvEpisodeRegister);
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
            // btnDelete
            // 
            btnDelete.Location = new Point(458, 667);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Radera";
            btnDelete.UseVisualStyleBackColor = true;
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
            // dgvPoddNames
            // 
            dgvPoddNames.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPoddNames.Location = new Point(37, 173);
            dgvPoddNames.Name = "dgvPoddNames";
            dgvPoddNames.RowHeadersWidth = 62;
            dgvPoddNames.Size = new Size(360, 479);
            dgvPoddNames.TabIndex = 3;
            // 
            // cbCategoryFiltration
            // 
            cbCategoryFiltration.FormattingEnabled = true;
            cbCategoryFiltration.Location = new Point(458, 72);
            cbCategoryFiltration.Name = "cbCategoryFiltration";
            cbCategoryFiltration.Size = new Size(364, 33);
            cbCategoryFiltration.TabIndex = 2;
            // 
            // rtbDescription
            // 
            rtbDescription.Location = new Point(872, 173);
            rtbDescription.Name = "rtbDescription";
            rtbDescription.Size = new Size(570, 479);
            rtbDescription.TabIndex = 1;
            rtbDescription.Text = "";
            // 
            // dgvEpisodeRegister
            // 
            dgvEpisodeRegister.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEpisodeRegister.Location = new Point(458, 173);
            dgvEpisodeRegister.Name = "dgvEpisodeRegister";
            dgvEpisodeRegister.RowHeadersWidth = 62;
            dgvEpisodeRegister.Size = new Size(364, 479);
            dgvEpisodeRegister.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(cbCategory);
            tabPage1.Controls.Add(txtPoddName);
            tabPage1.Controls.Add(rtbEpisodeInfo);
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
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(624, 686);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(182, 33);
            cbCategory.TabIndex = 16;
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
            // rtbEpisodeInfo
            // 
            rtbEpisodeInfo.Location = new Point(624, 190);
            rtbEpisodeInfo.Margin = new Padding(2);
            rtbEpisodeInfo.Name = "rtbEpisodeInfo";
            rtbEpisodeInfo.Size = new Size(556, 440);
            rtbEpisodeInfo.TabIndex = 13;
            rtbEpisodeInfo.Text = "";
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
            btnSave.Click += btnSave_Click;
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
            btnGetInfo.Click += btnGetInfo_Click;
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
            ((System.ComponentModel.ISupportInitialize)dgvPoddNames).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvEpisodeRegister).EndInit();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEpisodes).EndInit();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage tabPage2;
        private RichTextBox rtbDescription;
        private DataGridView dgvEpisodeRegister;
        private TabPage tabPage1;
        private TextBox txtPoddName;
        private RichTextBox rtbEpisodeInfo;
        private TextBox txtUrlInput;
        private Button btnSave;
        private DataGridView dgvEpisodes;
        private Button btnGetInfo;
        private Label lblUrlInput;
        private TabControl tabControl1;
        private DataGridView dgvPoddNames;
        private ComboBox cbCategoryFiltration;
        private Button btnEditPodd;
        private ComboBox cbCategory;
        private Button btnDelete;
        private Button btnEditCategory;
        //private Button btnEditPodd;
    }
}