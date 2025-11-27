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
            btnEditCat = new Button();
            cbPoddCatEdit = new ComboBox();
            txtEditPod = new TextBox();
            btnEditPod = new Button();
            btnSaveName = new Button();
            btnSaveCategory = new Button();
            lblChangeName = new Label();
            lblCreateCategory = new Label();
            txtCreateCategory = new TextBox();
            txtChangeName = new TextBox();
            btnRemoveCat = new Button();
            lblFilterCategory = new Label();
            lblDescription = new Label();
            lblCategory = new Label();
            lblPods = new Label();
            btnDelete = new Button();
            btnShowAll = new Button();
            dgvPoddNames = new DataGridView();
            cbCategoryFiltration = new ComboBox();
            rtbDescription = new RichTextBox();
            dgvEpisodeRegister = new DataGridView();
            tabPage1 = new TabPage();
            lblSlctCategory = new Label();
            lblSlctName = new Label();
            cbCategory = new ComboBox();
            txtPoddName = new TextBox();
            rtbEpisodeInfo = new RichTextBox();
            txtUrlInput = new TextBox();
            btnSave = new Button();
            dgvEpisodes = new DataGridView();
            btnGetInfo = new Button();
            lblUrlInput = new Label();
            tabControl1 = new TabControl();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
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
            tabPage2.Controls.Add(btnEditCat);
            tabPage2.Controls.Add(cbPoddCatEdit);
            tabPage2.Controls.Add(txtEditPod);
            tabPage2.Controls.Add(btnEditPod);
            tabPage2.Controls.Add(btnSaveName);
            tabPage2.Controls.Add(btnSaveCategory);
            tabPage2.Controls.Add(lblChangeName);
            tabPage2.Controls.Add(lblCreateCategory);
            tabPage2.Controls.Add(txtCreateCategory);
            tabPage2.Controls.Add(txtChangeName);
            tabPage2.Controls.Add(btnRemoveCat);
            tabPage2.Controls.Add(lblFilterCategory);
            tabPage2.Controls.Add(lblDescription);
            tabPage2.Controls.Add(lblCategory);
            tabPage2.Controls.Add(lblPods);
            tabPage2.Controls.Add(btnDelete);
            tabPage2.Controls.Add(btnShowAll);
            tabPage2.Controls.Add(dgvPoddNames);
            tabPage2.Controls.Add(cbCategoryFiltration);
            tabPage2.Controls.Add(rtbDescription);
            tabPage2.Controls.Add(dgvEpisodeRegister);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Margin = new Padding(4, 3, 4, 3);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(4, 3, 4, 3);
            tabPage2.Size = new Size(1703, 757);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Poddregister";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnEditCat
            // 
            btnEditCat.Location = new Point(461, 660);
            btnEditCat.Margin = new Padding(4, 5, 4, 5);
            btnEditCat.Name = "btnEditCat";
            btnEditCat.Size = new Size(143, 38);
            btnEditCat.TabIndex = 22;
            btnEditCat.Text = "Ändra kategori";
            btnEditCat.UseVisualStyleBackColor = true;
            btnEditCat.Click += btnEditCat_Click;
            // 
            // cbPoddCatEdit
            // 
            cbPoddCatEdit.FormattingEnabled = true;
            cbPoddCatEdit.Location = new Point(461, 702);
            cbPoddCatEdit.Margin = new Padding(4, 5, 4, 5);
            cbPoddCatEdit.Name = "cbPoddCatEdit";
            cbPoddCatEdit.Size = new Size(171, 33);
            cbPoddCatEdit.TabIndex = 21;
            // 
            // txtEditPod
            // 
            txtEditPod.Location = new Point(257, 710);
            txtEditPod.Name = "txtEditPod";
            txtEditPod.Size = new Size(150, 31);
            txtEditPod.TabIndex = 20;
            // 
            // btnEditPod
            // 
            btnEditPod.Location = new Point(257, 670);
            btnEditPod.Name = "btnEditPod";
            btnEditPod.Size = new Size(140, 33);
            btnEditPod.TabIndex = 19;
            btnEditPod.Text = "Ändra Namn";
            btnEditPod.UseVisualStyleBackColor = true;
            btnEditPod.Click += btnEditPod_Click;
            // 
            // btnSaveName
            // 
            btnSaveName.Location = new Point(753, 32);
            btnSaveName.Name = "btnSaveName";
            btnSaveName.Size = new Size(159, 33);
            btnSaveName.TabIndex = 18;
            btnSaveName.Text = "Spara namn";
            btnSaveName.UseVisualStyleBackColor = true;
            btnSaveName.Click += btnEditCategory_Click;
            // 
            // btnSaveCategory
            // 
            btnSaveCategory.Location = new Point(1259, 35);
            btnSaveCategory.Name = "btnSaveCategory";
            btnSaveCategory.Size = new Size(159, 33);
            btnSaveCategory.TabIndex = 17;
            btnSaveCategory.Text = "Spara kategori";
            btnSaveCategory.UseVisualStyleBackColor = true;
            btnSaveCategory.Click += btnCreateCategory_Click;
            // 
            // lblChangeName
            // 
            lblChangeName.AutoSize = true;
            lblChangeName.Location = new Point(481, 35);
            lblChangeName.Name = "lblChangeName";
            lblChangeName.Size = new Size(110, 25);
            lblChangeName.TabIndex = 16;
            lblChangeName.Text = "Ändra namn";
            // 
            // lblCreateCategory
            // 
            lblCreateCategory.AutoSize = true;
            lblCreateCategory.Location = new Point(966, 35);
            lblCreateCategory.Name = "lblCreateCategory";
            lblCreateCategory.Size = new Size(131, 25);
            lblCreateCategory.TabIndex = 15;
            lblCreateCategory.Text = "Skapa Kategori";
            lblCreateCategory.Click += label1_Click_1;
            // 
            // txtCreateCategory
            // 
            txtCreateCategory.Location = new Point(1101, 35);
            txtCreateCategory.Name = "txtCreateCategory";
            txtCreateCategory.Size = new Size(150, 31);
            txtCreateCategory.TabIndex = 14;
            // 
            // txtChangeName
            // 
            txtChangeName.Location = new Point(597, 35);
            txtChangeName.Name = "txtChangeName";
            txtChangeName.Size = new Size(150, 31);
            txtChangeName.TabIndex = 13;
            // 
            // btnRemoveCat
            // 
            btnRemoveCat.Location = new Point(794, 90);
            btnRemoveCat.Name = "btnRemoveCat";
            btnRemoveCat.Size = new Size(181, 33);
            btnRemoveCat.TabIndex = 12;
            btnRemoveCat.Text = "Radera kategori";
            btnRemoveCat.UseVisualStyleBackColor = true;
            btnRemoveCat.Click += btnRemoveCat_Click;
            // 
            // lblFilterCategory
            // 
            lblFilterCategory.AutoSize = true;
            lblFilterCategory.Location = new Point(37, 62);
            lblFilterCategory.Name = "lblFilterCategory";
            lblFilterCategory.Size = new Size(180, 25);
            lblFilterCategory.TabIndex = 10;
            lblFilterCategory.Text = "Filtrera efter kategori:";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(874, 143);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(102, 25);
            lblDescription.TabIndex = 9;
            lblDescription.Text = "Beskrivning";
            lblDescription.Click += label3_Click;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(461, 140);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(67, 25);
            lblCategory.TabIndex = 8;
            lblCategory.Text = "Avsnitt";
            // 
            // lblPods
            // 
            lblPods.AutoSize = true;
            lblPods.Location = new Point(37, 143);
            lblPods.Name = "lblPods";
            lblPods.Size = new Size(104, 25);
            lblPods.TabIndex = 7;
            lblPods.Text = "Dina flöden";
            lblPods.Click += label1_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(37, 670);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(111, 33);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Radera";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnShowAll
            // 
            btnShowAll.Location = new Point(407, 90);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(166, 33);
            btnShowAll.TabIndex = 5;
            btnShowAll.Text = "Visa alla flöden";
            btnShowAll.UseVisualStyleBackColor = true;
            btnShowAll.Click += btnShowAll_Click;
            // 
            // dgvPoddNames
            // 
            dgvPoddNames.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPoddNames.Location = new Point(37, 173);
            dgvPoddNames.Name = "dgvPoddNames";
            dgvPoddNames.RowHeadersWidth = 62;
            dgvPoddNames.Size = new Size(360, 478);
            dgvPoddNames.TabIndex = 3;
            // 
            // cbCategoryFiltration
            // 
            cbCategoryFiltration.FormattingEnabled = true;
            cbCategoryFiltration.Location = new Point(37, 90);
            cbCategoryFiltration.Name = "cbCategoryFiltration";
            cbCategoryFiltration.Size = new Size(364, 33);
            cbCategoryFiltration.TabIndex = 2;
            // 
            // rtbDescription
            // 
            rtbDescription.Location = new Point(871, 173);
            rtbDescription.Name = "rtbDescription";
            rtbDescription.Size = new Size(570, 479);
            rtbDescription.TabIndex = 1;
            rtbDescription.Text = "";
            // 
            // dgvEpisodeRegister
            // 
            dgvEpisodeRegister.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEpisodeRegister.Location = new Point(459, 173);
            dgvEpisodeRegister.Name = "dgvEpisodeRegister";
            dgvEpisodeRegister.RowHeadersWidth = 62;
            dgvEpisodeRegister.Size = new Size(364, 478);
            dgvEpisodeRegister.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(lblSlctCategory);
            tabPage1.Controls.Add(lblSlctName);
            tabPage1.Controls.Add(cbCategory);
            tabPage1.Controls.Add(txtPoddName);
            tabPage1.Controls.Add(rtbEpisodeInfo);
            tabPage1.Controls.Add(txtUrlInput);
            tabPage1.Controls.Add(btnSave);
            tabPage1.Controls.Add(dgvEpisodes);
            tabPage1.Controls.Add(btnGetInfo);
            tabPage1.Controls.Add(lblUrlInput);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Margin = new Padding(4, 3, 4, 3);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(4, 3, 4, 3);
            tabPage1.Size = new Size(1703, 757);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Källa";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // lblSlctCategory
            // 
            lblSlctCategory.AutoSize = true;
            lblSlctCategory.Location = new Point(109, 687);
            lblSlctCategory.Name = "lblSlctCategory";
            lblSlctCategory.Size = new Size(114, 25);
            lblSlctCategory.TabIndex = 18;
            lblSlctCategory.Text = "Välj kategori:";
            // 
            // lblSlctName
            // 
            lblSlctName.AutoSize = true;
            lblSlctName.Location = new Point(50, 640);
            lblSlctName.Name = "lblSlctName";
            lblSlctName.Size = new Size(185, 25);
            lblSlctName.TabIndex = 17;
            lblSlctName.Text = "Ange namn på flödet:";
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(229, 683);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(200, 33);
            cbCategory.TabIndex = 16;
            // 
            // txtPoddName
            // 
            txtPoddName.AccessibleName = "Vänligen ";
            txtPoddName.Location = new Point(229, 640);
            txtPoddName.Margin = new Padding(1, 2, 1, 2);
            txtPoddName.Name = "txtPoddName";
            txtPoddName.Size = new Size(200, 31);
            txtPoddName.TabIndex = 15;
            // 
            // rtbEpisodeInfo
            // 
            rtbEpisodeInfo.Location = new Point(624, 190);
            rtbEpisodeInfo.Margin = new Padding(1, 2, 1, 2);
            rtbEpisodeInfo.Name = "rtbEpisodeInfo";
            rtbEpisodeInfo.Size = new Size(555, 441);
            rtbEpisodeInfo.TabIndex = 13;
            rtbEpisodeInfo.Text = "";
            // 
            // txtUrlInput
            // 
            txtUrlInput.Location = new Point(50, 88);
            txtUrlInput.Margin = new Padding(1, 2, 1, 2);
            txtUrlInput.Name = "txtUrlInput";
            txtUrlInput.Size = new Size(233, 31);
            txtUrlInput.TabIndex = 9;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(470, 687);
            btnSave.Margin = new Padding(1, 2, 1, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(271, 33);
            btnSave.TabIndex = 14;
            btnSave.Text = "Spara ner flödet till ditt register.";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // dgvEpisodes
            // 
            dgvEpisodes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEpisodes.Location = new Point(50, 190);
            dgvEpisodes.Margin = new Padding(1, 2, 1, 2);
            dgvEpisodes.Name = "dgvEpisodes";
            dgvEpisodes.RowHeadersWidth = 62;
            dgvEpisodes.Size = new Size(559, 440);
            dgvEpisodes.TabIndex = 12;
            // 
            // btnGetInfo
            // 
            btnGetInfo.Location = new Point(51, 125);
            btnGetInfo.Margin = new Padding(1, 2, 1, 2);
            btnGetInfo.Name = "btnGetInfo";
            btnGetInfo.Size = new Size(111, 33);
            btnGetInfo.TabIndex = 11;
            btnGetInfo.Text = "Hämta";
            btnGetInfo.UseVisualStyleBackColor = true;
            btnGetInfo.Click += btnGetInfo_Click;
            // 
            // lblUrlInput
            // 
            lblUrlInput.AutoSize = true;
            lblUrlInput.Location = new Point(50, 60);
            lblUrlInput.Margin = new Padding(1, 0, 1, 0);
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
            tabControl1.Location = new Point(14, 15);
            tabControl1.Margin = new Padding(4, 3, 4, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1711, 795);
            tabControl1.TabIndex = 9;
            // 
            // FirstWindow
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1814, 917);
            Controls.Add(tabControl1);
            Margin = new Padding(1, 2, 1, 2);
            Name = "FirstWindow";
            Text = "FirstWindow";
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
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
        private ComboBox cbCategory;
        private Button btnDelete;
        private Button btnEditCategory;
        private Label lblSlctCategory;
        private Label lblSlctName;
        private Label lblDescription;
        private Label lblCategory;
        private Label lblPods;
        private Label lblFilterCategory;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btnRemoveCat;
        private Label lblCreateCategory;
        private TextBox txtCreateCategory;
        private TextBox txtChangeName;
        private Label lblChangeName;
        private Button btnSaveName;
        private Button btnSaveCategory;
        private Button btnEditPod;
        private TextBox txtEditPod;
        private ComboBox cbPoddCatEdit;
        private Button btnEditCat;
        private Button btnShowAll;
        //private Button btnEditPodd;
    }
}