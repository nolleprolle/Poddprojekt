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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            tabPage2 = new TabPage();
            lblDeleteCategory = new Label();
            lblDeletePodd = new Label();
            lblSwitchCategory = new Label();
            lblChangeNamePodd = new Label();
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
            lblPoddFlowInfo = new Label();
            lblShowPoddFlow = new Label();
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
            tabPage2.BackColor = Color.White;
            tabPage2.Controls.Add(lblDeleteCategory);
            tabPage2.Controls.Add(lblDeletePodd);
            tabPage2.Controls.Add(lblSwitchCategory);
            tabPage2.Controls.Add(lblChangeNamePodd);
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
            tabPage2.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Margin = new Padding(4, 3, 4, 3);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(4, 3, 4, 3);
            tabPage2.Size = new Size(1477, 747);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Register";
            tabPage2.Click += tabPage2_Click;
            // 
            // lblDeleteCategory
            // 
            lblDeleteCategory.AutoSize = true;
            lblDeleteCategory.Location = new Point(1162, 32);
            lblDeleteCategory.Name = "lblDeleteCategory";
            lblDeleteCategory.Size = new Size(157, 25);
            lblDeleteCategory.TabIndex = 26;
            lblDeleteCategory.Text = "Radera kategori:";
            // 
            // lblDeletePodd
            // 
            lblDeletePodd.AutoSize = true;
            lblDeletePodd.Location = new Point(773, 660);
            lblDeletePodd.Name = "lblDeletePodd";
            lblDeletePodd.Size = new Size(178, 25);
            lblDeletePodd.TabIndex = 25;
            lblDeletePodd.Text = "Radera poddflöde:";
            lblDeletePodd.Click += lblDeletePodd_Click;
            // 
            // lblSwitchCategory
            // 
            lblSwitchCategory.AutoSize = true;
            lblSwitchCategory.Location = new Point(393, 659);
            lblSwitchCategory.Name = "lblSwitchCategory";
            lblSwitchCategory.Size = new Size(149, 25);
            lblSwitchCategory.TabIndex = 24;
            lblSwitchCategory.Text = "Ändra kategori:";
            lblSwitchCategory.Click += lblSwitchCategory_Click;
            // 
            // lblChangeNamePodd
            // 
            lblChangeNamePodd.AutoSize = true;
            lblChangeNamePodd.Location = new Point(37, 658);
            lblChangeNamePodd.Name = "lblChangeNamePodd";
            lblChangeNamePodd.Size = new Size(197, 25);
            lblChangeNamePodd.TabIndex = 23;
            lblChangeNamePodd.Text = "Ändra visningsnamn:";
            lblChangeNamePodd.Click += label1_Click_2;
            // 
            // btnEditCat
            // 
            btnEditCat.BackColor = Color.WhiteSmoke;
            btnEditCat.Location = new Point(574, 689);
            btnEditCat.Margin = new Padding(4, 5, 4, 5);
            btnEditCat.Name = "btnEditCat";
            btnEditCat.Size = new Size(140, 33);
            btnEditCat.TabIndex = 22;
            btnEditCat.Text = "Spara";
            btnEditCat.UseVisualStyleBackColor = false;
            btnEditCat.Click += btnEditCat_Click;
            // 
            // cbPoddCatEdit
            // 
            cbPoddCatEdit.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbPoddCatEdit.FormattingEnabled = true;
            cbPoddCatEdit.Location = new Point(393, 688);
            cbPoddCatEdit.Margin = new Padding(4, 5, 4, 5);
            cbPoddCatEdit.Name = "cbPoddCatEdit";
            cbPoddCatEdit.Size = new Size(171, 33);
            cbPoddCatEdit.TabIndex = 21;
            // 
            // txtEditPod
            // 
            txtEditPod.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEditPod.Location = new Point(37, 689);
            txtEditPod.Name = "txtEditPod";
            txtEditPod.Size = new Size(150, 31);
            txtEditPod.TabIndex = 20;
            // 
            // btnEditPod
            // 
            btnEditPod.BackColor = Color.WhiteSmoke;
            btnEditPod.Location = new Point(196, 688);
            btnEditPod.Name = "btnEditPod";
            btnEditPod.Size = new Size(140, 33);
            btnEditPod.TabIndex = 19;
            btnEditPod.Text = "Spara";
            btnEditPod.UseVisualStyleBackColor = false;
            btnEditPod.Click += btnEditPod_Click;
            // 
            // btnSaveName
            // 
            btnSaveName.BackColor = Color.WhiteSmoke;
            btnSaveName.Location = new Point(610, 62);
            btnSaveName.Name = "btnSaveName";
            btnSaveName.Size = new Size(140, 33);
            btnSaveName.TabIndex = 18;
            btnSaveName.Text = "Spara";
            btnSaveName.UseVisualStyleBackColor = false;
            btnSaveName.Click += btnEditCategory_Click;
            // 
            // btnSaveCategory
            // 
            btnSaveCategory.BackColor = Color.WhiteSmoke;
            btnSaveCategory.Location = new Point(972, 62);
            btnSaveCategory.Name = "btnSaveCategory";
            btnSaveCategory.Size = new Size(140, 33);
            btnSaveCategory.TabIndex = 17;
            btnSaveCategory.Text = "Spara";
            btnSaveCategory.UseVisualStyleBackColor = false;
            btnSaveCategory.Click += btnCreateCategory_Click;
            // 
            // lblChangeName
            // 
            lblChangeName.AutoSize = true;
            lblChangeName.Location = new Point(451, 32);
            lblChangeName.Name = "lblChangeName";
            lblChangeName.Size = new Size(198, 25);
            lblChangeName.TabIndex = 16;
            lblChangeName.Text = "Ändra kategorinamn:";
            lblChangeName.Click += lblChangeName_Click;
            // 
            // lblCreateCategory
            // 
            lblCreateCategory.AutoSize = true;
            lblCreateCategory.Location = new Point(813, 32);
            lblCreateCategory.Name = "lblCreateCategory";
            lblCreateCategory.Size = new Size(150, 25);
            lblCreateCategory.TabIndex = 15;
            lblCreateCategory.Text = "Skapa Kategori:";
            lblCreateCategory.Click += label1_Click_1;
            // 
            // txtCreateCategory
            // 
            txtCreateCategory.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCreateCategory.Location = new Point(813, 62);
            txtCreateCategory.Name = "txtCreateCategory";
            txtCreateCategory.Size = new Size(150, 31);
            txtCreateCategory.TabIndex = 14;
            // 
            // txtChangeName
            // 
            txtChangeName.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtChangeName.Location = new Point(451, 62);
            txtChangeName.Name = "txtChangeName";
            txtChangeName.Size = new Size(150, 31);
            txtChangeName.TabIndex = 13;
            // 
            // btnRemoveCat
            // 
            btnRemoveCat.BackColor = Color.WhiteSmoke;
            btnRemoveCat.ForeColor = Color.Black;
            btnRemoveCat.Location = new Point(1166, 62);
            btnRemoveCat.Name = "btnRemoveCat";
            btnRemoveCat.Size = new Size(140, 33);
            btnRemoveCat.TabIndex = 12;
            btnRemoveCat.Text = "Radera";
            btnRemoveCat.UseVisualStyleBackColor = false;
            btnRemoveCat.Click += btnRemoveCat_Click;
            // 
            // lblFilterCategory
            // 
            lblFilterCategory.AutoSize = true;
            lblFilterCategory.Location = new Point(32, 30);
            lblFilterCategory.Name = "lblFilterCategory";
            lblFilterCategory.Size = new Size(204, 25);
            lblFilterCategory.TabIndex = 10;
            lblFilterCategory.Text = "Filtrera efter kategori:";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescription.Location = new Point(871, 123);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(117, 25);
            lblDescription.TabIndex = 9;
            lblDescription.Text = "Information";
            lblDescription.Click += label3_Click;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(451, 123);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(74, 25);
            lblCategory.TabIndex = 8;
            lblCategory.Text = "Avsnitt";
            // 
            // lblPods
            // 
            lblPods.AutoSize = true;
            lblPods.Location = new Point(37, 123);
            lblPods.Name = "lblPods";
            lblPods.Size = new Size(115, 25);
            lblPods.TabIndex = 7;
            lblPods.Text = "Dina flöden";
            lblPods.Click += label1_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.WhiteSmoke;
            btnDelete.Location = new Point(776, 689);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(140, 33);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Radera";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnShowAll
            // 
            btnShowAll.BackColor = Color.WhiteSmoke;
            btnShowAll.Location = new Point(234, 61);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(166, 33);
            btnShowAll.TabIndex = 5;
            btnShowAll.Text = "Visa alla flöden";
            btnShowAll.UseVisualStyleBackColor = false;
            btnShowAll.Click += btnShowAll_Click;
            // 
            // dgvPoddNames
            // 
            dgvPoddNames.BackgroundColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPoddNames.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPoddNames.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvPoddNames.DefaultCellStyle = dataGridViewCellStyle2;
            dgvPoddNames.Location = new Point(37, 151);
            dgvPoddNames.Name = "dgvPoddNames";
            dgvPoddNames.RowHeadersWidth = 62;
            dgvPoddNames.Size = new Size(360, 480);
            dgvPoddNames.TabIndex = 3;
            // 
            // cbCategoryFiltration
            // 
            cbCategoryFiltration.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbCategoryFiltration.FormattingEnabled = true;
            cbCategoryFiltration.Location = new Point(37, 60);
            cbCategoryFiltration.Name = "cbCategoryFiltration";
            cbCategoryFiltration.Size = new Size(188, 33);
            cbCategoryFiltration.TabIndex = 2;
            // 
            // rtbDescription
            // 
            rtbDescription.BackColor = Color.WhiteSmoke;
            rtbDescription.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtbDescription.Location = new Point(871, 151);
            rtbDescription.Name = "rtbDescription";
            rtbDescription.Size = new Size(570, 480);
            rtbDescription.TabIndex = 1;
            rtbDescription.Text = "";
            // 
            // dgvEpisodeRegister
            // 
            dgvEpisodeRegister.AllowUserToResizeColumns = false;
            dgvEpisodeRegister.BackgroundColor = Color.WhiteSmoke;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvEpisodeRegister.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvEpisodeRegister.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvEpisodeRegister.DefaultCellStyle = dataGridViewCellStyle4;
            dgvEpisodeRegister.Location = new Point(451, 151);
            dgvEpisodeRegister.Name = "dgvEpisodeRegister";
            dgvEpisodeRegister.RowHeadersWidth = 62;
            dgvEpisodeRegister.Size = new Size(364, 480);
            dgvEpisodeRegister.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.White;
            tabPage1.Controls.Add(lblPoddFlowInfo);
            tabPage1.Controls.Add(lblShowPoddFlow);
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
            tabPage1.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Margin = new Padding(4, 3, 4, 3);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(4, 3, 4, 3);
            tabPage1.Size = new Size(1477, 747);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Källa";
            tabPage1.Click += tabPage1_Click;
            // 
            // lblPoddFlowInfo
            // 
            lblPoddFlowInfo.AutoSize = true;
            lblPoddFlowInfo.Location = new Point(761, 161);
            lblPoddFlowInfo.Name = "lblPoddFlowInfo";
            lblPoddFlowInfo.Size = new Size(117, 25);
            lblPoddFlowInfo.TabIndex = 20;
            lblPoddFlowInfo.Text = "Information";
            // 
            // lblShowPoddFlow
            // 
            lblShowPoddFlow.AutoSize = true;
            lblShowPoddFlow.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblShowPoddFlow.Location = new Point(45, 161);
            lblShowPoddFlow.Name = "lblShowPoddFlow";
            lblShowPoddFlow.Size = new Size(148, 25);
            lblShowPoddFlow.TabIndex = 19;
            lblShowPoddFlow.Text = "Visa poddflöde";
            // 
            // lblSlctCategory
            // 
            lblSlctCategory.AutoSize = true;
            lblSlctCategory.Location = new Point(122, 694);
            lblSlctCategory.Name = "lblSlctCategory";
            lblSlctCategory.Size = new Size(128, 25);
            lblSlctCategory.TabIndex = 18;
            lblSlctCategory.Text = "Välj kategori:";
            // 
            // lblSlctName
            // 
            lblSlctName.AutoSize = true;
            lblSlctName.Location = new Point(45, 652);
            lblSlctName.Name = "lblSlctName";
            lblSlctName.Size = new Size(205, 25);
            lblSlctName.TabIndex = 17;
            lblSlctName.Text = "Ange namn på flödet:";
            // 
            // cbCategory
            // 
            cbCategory.BackColor = Color.White;
            cbCategory.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(256, 693);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(200, 33);
            cbCategory.TabIndex = 16;
            // 
            // txtPoddName
            // 
            txtPoddName.AccessibleName = "Vänligen ";
            txtPoddName.BackColor = Color.White;
            txtPoddName.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPoddName.ForeColor = Color.Black;
            txtPoddName.Location = new Point(256, 651);
            txtPoddName.Margin = new Padding(1, 2, 1, 2);
            txtPoddName.Name = "txtPoddName";
            txtPoddName.Size = new Size(200, 31);
            txtPoddName.TabIndex = 15;
            // 
            // rtbEpisodeInfo
            // 
            rtbEpisodeInfo.BackColor = Color.WhiteSmoke;
            rtbEpisodeInfo.Location = new Point(761, 190);
            rtbEpisodeInfo.Margin = new Padding(1, 2, 1, 2);
            rtbEpisodeInfo.Name = "rtbEpisodeInfo";
            rtbEpisodeInfo.Size = new Size(672, 441);
            rtbEpisodeInfo.TabIndex = 13;
            rtbEpisodeInfo.Text = "";
            // 
            // txtUrlInput
            // 
            txtUrlInput.BackColor = Color.White;
            txtUrlInput.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUrlInput.Location = new Point(45, 65);
            txtUrlInput.Margin = new Padding(1, 2, 1, 2);
            txtUrlInput.Name = "txtUrlInput";
            txtUrlInput.Size = new Size(233, 31);
            txtUrlInput.TabIndex = 9;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.WhiteSmoke;
            btnSave.Location = new Point(465, 694);
            btnSave.Margin = new Padding(1, 2, 1, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(140, 33);
            btnSave.TabIndex = 14;
            btnSave.Text = "Spara";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // dgvEpisodes
            // 
            dgvEpisodes.BackgroundColor = Color.WhiteSmoke;
            dgvEpisodes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = Color.DarkSeaGreen;
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvEpisodes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvEpisodes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = Color.Black;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvEpisodes.DefaultCellStyle = dataGridViewCellStyle6;
            dgvEpisodes.Location = new Point(45, 190);
            dgvEpisodes.Margin = new Padding(1, 2, 1, 2);
            dgvEpisodes.Name = "dgvEpisodes";
            dgvEpisodes.RowHeadersWidth = 62;
            dgvEpisodes.Size = new Size(672, 441);
            dgvEpisodes.TabIndex = 12;
            // 
            // btnGetInfo
            // 
            btnGetInfo.BackColor = Color.WhiteSmoke;
            btnGetInfo.Location = new Point(45, 105);
            btnGetInfo.Margin = new Padding(1, 2, 1, 2);
            btnGetInfo.Name = "btnGetInfo";
            btnGetInfo.Size = new Size(140, 33);
            btnGetInfo.TabIndex = 11;
            btnGetInfo.Text = "Hämta";
            btnGetInfo.UseVisualStyleBackColor = false;
            btnGetInfo.Click += btnGetInfo_Click;
            // 
            // lblUrlInput
            // 
            lblUrlInput.AutoSize = true;
            lblUrlInput.Location = new Point(45, 35);
            lblUrlInput.Margin = new Padding(1, 0, 1, 0);
            lblUrlInput.Name = "lblUrlInput";
            lblUrlInput.Size = new Size(265, 25);
            lblUrlInput.TabIndex = 10;
            lblUrlInput.Text = "Ange källans URL: (RSS-länk)";
            lblUrlInput.Click += lblUrlInput_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(14, 15);
            tabControl1.Margin = new Padding(4, 3, 4, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1485, 785);
            tabControl1.TabIndex = 9;
            // 
            // FirstWindow
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1515, 825);
            Controls.Add(tabControl1);
            Margin = new Padding(1, 2, 1, 2);
            Name = "FirstWindow";
            Text = "RSSify";
            Load += FirstWindow_Load_1;
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
        private Label lblChangeNamePodd;
        private Label lblSwitchCategory;
        private Label lblDeletePodd;
        private Label lblDeleteCategory;
        private Label lblShowPoddFlow;
        private Label lblPoddFlowInfo;
        //private Button btnEditPodd;
    }
}