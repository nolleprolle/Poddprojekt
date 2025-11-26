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
            btnEditCategory = new Button();
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
            tabPage2.Controls.Add(btnEditCategory);
            tabPage2.Controls.Add(dgvPoddNames);
            tabPage2.Controls.Add(cbCategoryFiltration);
            tabPage2.Controls.Add(rtbDescription);
            tabPage2.Controls.Add(dgvEpisodeRegister);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(3, 2, 3, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 2, 3, 2);
            tabPage2.Size = new Size(1190, 449);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Poddregister";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnEditCat
            // 
            btnEditCat.Location = new Point(323, 396);
            btnEditCat.Name = "btnEditCat";
            btnEditCat.Size = new Size(100, 23);
            btnEditCat.TabIndex = 22;
            btnEditCat.Text = "Ändra kategori";
            btnEditCat.UseVisualStyleBackColor = true;
            btnEditCat.Click += btnEditCat_Click;
            // 
            // cbPoddCatEdit
            // 
            cbPoddCatEdit.FormattingEnabled = true;
            cbPoddCatEdit.Location = new Point(323, 421);
            cbPoddCatEdit.Name = "cbPoddCatEdit";
            cbPoddCatEdit.Size = new Size(121, 23);
            cbPoddCatEdit.TabIndex = 21;
            // 
            // txtEditPod
            // 
            txtEditPod.Location = new Point(180, 426);
            txtEditPod.Margin = new Padding(2);
            txtEditPod.Name = "txtEditPod";
            txtEditPod.Size = new Size(106, 23);
            txtEditPod.TabIndex = 20;
            // 
            // btnEditPod
            // 
            btnEditPod.Location = new Point(180, 402);
            btnEditPod.Margin = new Padding(2);
            btnEditPod.Name = "btnEditPod";
            btnEditPod.Size = new Size(98, 20);
            btnEditPod.TabIndex = 19;
            btnEditPod.Text = "Ändra Namn";
            btnEditPod.UseVisualStyleBackColor = true;
            btnEditPod.Click += btnEditPod_Click;
            // 
            // btnSaveName
            // 
            btnSaveName.Location = new Point(527, 19);
            btnSaveName.Margin = new Padding(2);
            btnSaveName.Name = "btnSaveName";
            btnSaveName.Size = new Size(111, 20);
            btnSaveName.TabIndex = 18;
            btnSaveName.Text = "Spara namn";
            btnSaveName.UseVisualStyleBackColor = true;
            btnSaveName.Click += btnEditCategory_Click;
            // 
            // btnSaveCategory
            // 
            btnSaveCategory.Location = new Point(881, 21);
            btnSaveCategory.Margin = new Padding(2);
            btnSaveCategory.Name = "btnSaveCategory";
            btnSaveCategory.Size = new Size(111, 20);
            btnSaveCategory.TabIndex = 17;
            btnSaveCategory.Text = "Spara kategori";
            btnSaveCategory.UseVisualStyleBackColor = true;
            btnSaveCategory.Click += btnCreateCategory_Click;
            // 
            // lblChangeName
            // 
            lblChangeName.AutoSize = true;
            lblChangeName.Location = new Point(337, 21);
            lblChangeName.Margin = new Padding(2, 0, 2, 0);
            lblChangeName.Name = "lblChangeName";
            lblChangeName.Size = new Size(73, 15);
            lblChangeName.TabIndex = 16;
            lblChangeName.Text = "Ändra namn";
            // 
            // lblCreateCategory
            // 
            lblCreateCategory.AutoSize = true;
            lblCreateCategory.Location = new Point(676, 21);
            lblCreateCategory.Margin = new Padding(2, 0, 2, 0);
            lblCreateCategory.Name = "lblCreateCategory";
            lblCreateCategory.Size = new Size(85, 15);
            lblCreateCategory.TabIndex = 15;
            lblCreateCategory.Text = "Skapa Kategori";
            lblCreateCategory.Click += label1_Click_1;
            // 
            // txtCreateCategory
            // 
            txtCreateCategory.Location = new Point(771, 21);
            txtCreateCategory.Margin = new Padding(2);
            txtCreateCategory.Name = "txtCreateCategory";
            txtCreateCategory.Size = new Size(106, 23);
            txtCreateCategory.TabIndex = 14;
            // 
            // txtChangeName
            // 
            txtChangeName.Location = new Point(418, 21);
            txtChangeName.Margin = new Padding(2);
            txtChangeName.Name = "txtChangeName";
            txtChangeName.Size = new Size(106, 23);
            txtChangeName.TabIndex = 13;
            // 
            // btnRemoveCat
            // 
            btnRemoveCat.Location = new Point(556, 54);
            btnRemoveCat.Margin = new Padding(2);
            btnRemoveCat.Name = "btnRemoveCat";
            btnRemoveCat.Size = new Size(127, 20);
            btnRemoveCat.TabIndex = 12;
            btnRemoveCat.Text = "Radera kategori";
            btnRemoveCat.UseVisualStyleBackColor = true;
            btnRemoveCat.Click += btnRemoveCat_Click;
            // 
            // lblFilterCategory
            // 
            lblFilterCategory.AutoSize = true;
            lblFilterCategory.Location = new Point(26, 37);
            lblFilterCategory.Margin = new Padding(2, 0, 2, 0);
            lblFilterCategory.Name = "lblFilterCategory";
            lblFilterCategory.Size = new Size(119, 15);
            lblFilterCategory.TabIndex = 10;
            lblFilterCategory.Text = "Filtrera efter kategori:";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(612, 86);
            lblDescription.Margin = new Padding(2, 0, 2, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(68, 15);
            lblDescription.TabIndex = 9;
            lblDescription.Text = "Beskrivning";
            lblDescription.Click += label3_Click;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(323, 84);
            lblCategory.Margin = new Padding(2, 0, 2, 0);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(44, 15);
            lblCategory.TabIndex = 8;
            lblCategory.Text = "Avsnitt";
            // 
            // lblPods
            // 
            lblPods.AutoSize = true;
            lblPods.Location = new Point(26, 86);
            lblPods.Margin = new Padding(2, 0, 2, 0);
            lblPods.Name = "lblPods";
            lblPods.Size = new Size(68, 15);
            lblPods.TabIndex = 7;
            lblPods.Text = "Dina flöden";
            lblPods.Click += label1_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(26, 402);
            btnDelete.Margin = new Padding(2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(78, 20);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Radera";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEditCategory
            // 
            btnEditCategory.Location = new Point(285, 54);
            btnEditCategory.Margin = new Padding(2);
            btnEditCategory.Name = "btnEditCategory";
            btnEditCategory.Size = new Size(116, 20);
            btnEditCategory.TabIndex = 5;
            btnEditCategory.Text = "Redigera kategori";
            btnEditCategory.UseVisualStyleBackColor = true;
            // 
            // dgvPoddNames
            // 
            dgvPoddNames.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPoddNames.Location = new Point(26, 104);
            dgvPoddNames.Margin = new Padding(2);
            dgvPoddNames.Name = "dgvPoddNames";
            dgvPoddNames.RowHeadersWidth = 62;
            dgvPoddNames.Size = new Size(252, 287);
            dgvPoddNames.TabIndex = 3;
            // 
            // cbCategoryFiltration
            // 
            cbCategoryFiltration.FormattingEnabled = true;
            cbCategoryFiltration.Location = new Point(26, 54);
            cbCategoryFiltration.Margin = new Padding(2);
            cbCategoryFiltration.Name = "cbCategoryFiltration";
            cbCategoryFiltration.Size = new Size(256, 23);
            cbCategoryFiltration.TabIndex = 2;
            // 
            // rtbDescription
            // 
            rtbDescription.Location = new Point(610, 104);
            rtbDescription.Margin = new Padding(2);
            rtbDescription.Name = "rtbDescription";
            rtbDescription.Size = new Size(400, 289);
            rtbDescription.TabIndex = 1;
            rtbDescription.Text = "";
            // 
            // dgvEpisodeRegister
            // 
            dgvEpisodeRegister.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEpisodeRegister.Location = new Point(321, 104);
            dgvEpisodeRegister.Margin = new Padding(2);
            dgvEpisodeRegister.Name = "dgvEpisodeRegister";
            dgvEpisodeRegister.RowHeadersWidth = 62;
            dgvEpisodeRegister.Size = new Size(255, 287);
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
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(3, 2, 3, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 2, 3, 2);
            tabPage1.Size = new Size(1190, 449);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Källa";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // lblSlctCategory
            // 
            lblSlctCategory.AutoSize = true;
            lblSlctCategory.Location = new Point(76, 412);
            lblSlctCategory.Margin = new Padding(2, 0, 2, 0);
            lblSlctCategory.Name = "lblSlctCategory";
            lblSlctCategory.Size = new Size(75, 15);
            lblSlctCategory.TabIndex = 18;
            lblSlctCategory.Text = "Välj kategori:";
            // 
            // lblSlctName
            // 
            lblSlctName.AutoSize = true;
            lblSlctName.Location = new Point(35, 384);
            lblSlctName.Margin = new Padding(2, 0, 2, 0);
            lblSlctName.Name = "lblSlctName";
            lblSlctName.Size = new Size(122, 15);
            lblSlctName.TabIndex = 17;
            lblSlctName.Text = "Ange namn på flödet:";
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(160, 410);
            cbCategory.Margin = new Padding(2);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(141, 23);
            cbCategory.TabIndex = 16;
            // 
            // txtPoddName
            // 
            txtPoddName.AccessibleName = "Vänligen ";
            txtPoddName.Location = new Point(160, 384);
            txtPoddName.Margin = new Padding(1);
            txtPoddName.Name = "txtPoddName";
            txtPoddName.Size = new Size(141, 23);
            txtPoddName.TabIndex = 15;
            // 
            // rtbEpisodeInfo
            // 
            rtbEpisodeInfo.Location = new Point(437, 114);
            rtbEpisodeInfo.Margin = new Padding(1);
            rtbEpisodeInfo.Name = "rtbEpisodeInfo";
            rtbEpisodeInfo.Size = new Size(390, 266);
            rtbEpisodeInfo.TabIndex = 13;
            rtbEpisodeInfo.Text = "";
            // 
            // txtUrlInput
            // 
            txtUrlInput.Location = new Point(35, 53);
            txtUrlInput.Margin = new Padding(1);
            txtUrlInput.Name = "txtUrlInput";
            txtUrlInput.Size = new Size(164, 23);
            txtUrlInput.TabIndex = 9;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(329, 412);
            btnSave.Margin = new Padding(1);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(190, 20);
            btnSave.TabIndex = 14;
            btnSave.Text = "Spara ner flödet till ditt register.";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // dgvEpisodes
            // 
            dgvEpisodes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEpisodes.Location = new Point(35, 114);
            dgvEpisodes.Margin = new Padding(1);
            dgvEpisodes.Name = "dgvEpisodes";
            dgvEpisodes.RowHeadersWidth = 62;
            dgvEpisodes.Size = new Size(391, 264);
            dgvEpisodes.TabIndex = 12;
            // 
            // btnGetInfo
            // 
            btnGetInfo.Location = new Point(36, 75);
            btnGetInfo.Margin = new Padding(1);
            btnGetInfo.Name = "btnGetInfo";
            btnGetInfo.Size = new Size(78, 20);
            btnGetInfo.TabIndex = 11;
            btnGetInfo.Text = "Hämta";
            btnGetInfo.UseVisualStyleBackColor = true;
            btnGetInfo.Click += btnGetInfo_Click;
            // 
            // lblUrlInput
            // 
            lblUrlInput.AutoSize = true;
            lblUrlInput.Location = new Point(35, 36);
            lblUrlInput.Margin = new Padding(1, 0, 1, 0);
            lblUrlInput.Name = "lblUrlInput";
            lblUrlInput.Size = new Size(155, 15);
            lblUrlInput.TabIndex = 10;
            lblUrlInput.Text = "Ange källans URL (RSS-länk)";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Font = new Font("Segoe UI Symbol", 9F);
            tabControl1.Location = new Point(10, 9);
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1198, 477);
            tabControl1.TabIndex = 9;
            // 
            // FirstWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1270, 550);
            Controls.Add(tabControl1);
            Margin = new Padding(1);
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
        //private Button btnEditPodd;
    }
}